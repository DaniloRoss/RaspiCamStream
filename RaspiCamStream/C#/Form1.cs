using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using AForge.Video;

namespace RaspiCamStream
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = default(Bitmap);
        MJPEGStream Stream;
        private delegate void SafeCallDelegate(string ip, string nome, ListView listview);
        private int numIp;
        string ip = default(string);
        int streamexist = default(int);

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(640, 480);
            pictureBox1.Enabled = false;
            numIp = 0;
        }

        private void ListView_ip_Click(object sender, EventArgs e)
        {
            Txt_ip.Text = ListView_ip.SelectedItems[0].SubItems[0].Text;
        }

        private void Btn_ip_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(Txt_ip.Text, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b"))
            {
                Label_ip.Text = "indirizzo non valido";
                Txt_ip.Clear();
                return;
            }

            if (Label_Search_ip.Text != "")
            {
                Label_Search_ip.Text = "";
            }                

            ip = Txt_ip.Text.ToString();
            Stream = new MJPEGStream($"http://{ip}:8080/?action=stream");
            try
            {
                sendmessage("Q");
            }
            catch
            {
                MessageBox.Show("L'IP inserito non è corretto o il raspberry pi non risponde, riprova");
                return;
            }
            Stream.NewFrame += Stream_NewFrame;
            streamexist = 1;
            Txt_ip.Clear();
        }

        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
            // try/catch necessario perché interferisce con la stessa istruzione 
            // nel blocco DrawRectangle
            try
            {
                pictureBox1.Image = bitmap;
            }
            catch
            {

            }
        }      

        private void Btn_stream_Click(object sender, EventArgs e)  //AVVIO O PAUSA STREAMING
        {
            if (Stream.IsRunning == true)
            {
                Stream.Stop();
                Btn_stream.Normalcolor = Color.DarkGreen;
                Btn_stream.OnHovercolor = Color.Lime;
                Btn_stream.Iconimage = new Bitmap("play.png");
                return;
            }
            Stream.Start();
            Btn_stream.Normalcolor = Color.DarkRed;
            Btn_stream.OnHovercolor = Color.Red;
            Btn_stream.Iconimage = new Bitmap("stop.png");
        }

        //SOCKET
        private void sendmessage(string msg)
        {
            TcpClient clientSocket = new TcpClient();
            clientSocket.Connect($"{ip}", 8081);

            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = Encoding.ASCII.GetBytes(msg);
            serverStream.Write(outStream, 0, outStream.Length);

            byte[] inStream = new byte[4096];
            int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
            string tmp = Encoding.ASCII.GetString(inStream, 0, bytesRead);
            if (Rb_detection.Enabled == true || Rb_tracking.Enabled == true)
            {
                Draw_rectangle(tmp);
            }
            clientSocket.Close();
        }
        private void Draw_rectangle(string c)
        {
            // quando il modulo di face detection manda un set di coordinate, 
            // sovrappone un rettangolo rosso allo streaming della camera
            try
            {
                string[] coordinate = c.Split('-');
                int x = int.Parse(coordinate[0]);
                int y = int.Parse(coordinate[1]);
                int w = int.Parse(coordinate[2]);
                int h = int.Parse(coordinate[3]);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 5))
                    {
                        graphics.DrawRectangle(pen, x, y,  w,  h);
                    }
                }
                pictureBox1.Image = bitmap;
            }
            catch
            {

            }
        }       

        //CONTROLLI CAM-----------------------------------------------
        #region
        private void Pb_up_MouseDown(object sender, MouseEventArgs e)
        {
            Timer_up.Start();
        }

        private void Pb_up_MouseUp(object sender, MouseEventArgs e)
        {
            Timer_up.Stop();
        }

        private void Timer_up_Tick(object sender, EventArgs e)
        {
            sendmessage("U");
        }

        private void Pb_down_MouseDown(object sender, MouseEventArgs e)
        {
            Timer_down.Start();
        }

        private void Pb_down_MouseUp(object sender, MouseEventArgs e)
        {
            Timer_down.Stop();
        }

        private void Timer_down_Tick(object sender, EventArgs e)
        {
            sendmessage("D");
        }

        private void Pb_right_MouseDown(object sender, MouseEventArgs e)
        {
            Timer_right.Start();
        }

        private void Pb_right_MouseUp(object sender, MouseEventArgs e)
        {
            Timer_right.Stop();
        }

        private void Timer_right_Tick(object sender, EventArgs e)
        {
            sendmessage("R");
        }

        private void Pb_left_MouseDown(object sender, MouseEventArgs e)
        {
            Timer_left.Start();
        }

        private void Pb_left_MouseUp(object sender, MouseEventArgs e)
        {
            Timer_left.Stop();
        }

        private void Timer_left_Tick(object sender, EventArgs e)
        {
            sendmessage("L");
        }

        private void Pb_center_Click(object sender, EventArgs e)
        {
            sendmessage("C");
        }
        private void Rb_normal_Click(object sender, EventArgs e)
        {
            if (Timer_face.Enabled == true)
            {
                Timer_face.Stop();
            }
            if (Timer_tracking.Enabled == true)
            {
                Timer_tracking.Stop();
                pictureBox1.Enabled = false;
            }
            sendmessage("Q");
        }

        private void Rb_tracking_Click(object sender, EventArgs e)
        {
            if (Timer_face.Enabled == true)
            {
                Timer_face.Stop();
            }
            pictureBox1.Enabled = true;
            //Timer_tracking.Start();
        }

        private void Rb_detection_Click(object sender, EventArgs e)
        {
            if (Timer_tracking.Enabled == true)
            {
                Timer_tracking.Stop();
                pictureBox1.Enabled = false;
            }
            Timer_face.Start();
        }

        private void Timer_tracking_Tick(object sender, EventArgs e)
        {
            sendmessage("T");
        }

        private void Timer_face_Tick(object sender, EventArgs e)
        {
            sendmessage("F");
        }
        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null)
            {
                int min_h = default(int);
                int min_s = default(int);
                int min_v = default(int);
                int max_h = default(int);
                int max_s = default(int);
                int max_v = default(int);
                int px = mouseEventArgs.X;
                int py = mouseEventArgs.Y;
                var bmp = pictureBox1.Image as Bitmap;
                Color target = bmp.GetPixel(px, py);

                //converte dalla scala di c# con h 0-360 s 0-1 e v 0-1
                //alla scala di python con h 0-180 s 0-255 e v 0-255
                int h = (int)(target.GetHue()/2);
                int s = (int)(target.GetSaturation() * 255);
                int v = (int)(target.GetBrightness() * 255);

                if (h >= 10)
                    min_h = h - 10;
                else
                    min_h = 0;
                if (s >= 40)
                    min_s = s - 40;
                else
                    min_s = 0;
                if (v >= 40)
                    min_v = v - 40;
                else
                    min_v = 0;
                if (h <= 169)
                    max_h = h + 10;
                else
                    max_h = 179;
                if (s <= 245)
                    max_s = s + 10;
                else
                    max_s = 255;
                if (v <= 245)
                    max_v = v + 40;
                else
                    max_v = 255;


                string HSV = $"{min_h} {min_s} {min_v} {max_h} {max_s} {max_v}";
                sendmessage("T");
                sendmessage(HSV);
                Timer_tracking.Start();
            }
        }
        private void Pb_exit_Click(object sender, EventArgs e)
        {
            if(streamexist == 1)
            {
                if (Stream.IsRunning == true)
                {
                    Stream.Stop();
                }
            }
            
            this.Close();
        }

        private void Pb_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;           
        }

        private void Pb_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                return;
            }                

            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            Txt_Search_ip.Visible = true;
            ListView_ip.Visible = true;
            Btn_go.Visible = true;
        }

        private void Btn_go_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(Txt_Search_ip.Text, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\b"))
            {
                Label_Search_ip.Text = "indirizzo non valido";
                Txt_Search_ip.Clear();
                return;
            }
            if (Label_Search_ip.Text != "")          
                Label_Search_ip.Text = "";
            
            ListView_ip.Items.Clear();

            string ipt = Txt_Search_ip.Text;

            int i = 1;
            int x = 256;

            Thread thread = new Thread(new ThreadStart(delegate { loopIp(ipt, i, x, ListView_ip); }));

            thread.Start();            
        }

        private void ControlloPassaggio(string ip, string nome, ListView listview)
        {
            if (listview.InvokeRequired)
            {
                var d = new SafeCallDelegate(ControlloPassaggio);
                listview.Invoke(d, new object[] { ip, nome, listview });
            }
            else
            {
                listview.Items.Add(new ListViewItem(new string[] { ip, GetMachineNameFromIPAddress(ip), "Online" }));
                numIp++;
            }
        }// controlla il passaggio da Thread a UI

        private static void loopIp(string ipt, int i, int x, ListView listview)
        {
            while (i < x)
            {
                string ip = String.Concat(ipt, ".", i);

                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ip, 900);

                if (reply.Status == IPStatus.Success)
                {
                    Form1 foo = new Form1();
                    foo.ControlloPassaggio(ip, GetMachineNameFromIPAddress(ip).ToString(), listview);
                }
                i++;
            }
        } // riempe lista di ip nome e stato

        private static string GetMachineNameFromIPAddress(string ipAdress)
        {
            string machineName = string.Empty;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAdress);
                machineName = hostEntry.HostName;
            }
            catch (Exception ex)
            {
                machineName = ex.ToString();
            }
            return machineName;
        } // da ip a nome host        
    }
}
