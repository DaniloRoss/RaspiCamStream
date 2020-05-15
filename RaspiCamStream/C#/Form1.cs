using System;
using System.Drawing;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using AForge.Video;
using System.Linq;

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
            Rb_normal.Checked = true;
            Btn_change.Visible = false;
            Rb_tracking.Enabled = false;
            Rb_detection.Enabled = false;
            Btn_screenshot.Enabled = false;
            numIp = 0;           
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

        private void Btn_stream_Click(object sender, EventArgs e)  //AVVIO STREAM
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
            Rb_tracking.Enabled = true;
            Rb_detection.Enabled = true;
            Btn_screenshot.Enabled = true;
        }

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
                    using (Pen pen = new Pen(Color.Red, 2))
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
                Picturebox_colore.BackColor = Color.Transparent;                
            }
            sendmessage("Q");
            Btn_change.Visible = false;
        }

        private void Rb_tracking_Click(object sender, EventArgs e)
        {
            if (Timer_face.Enabled == true)
            {
                Timer_face.Stop();
                sendmessage("Q");
            }
            pictureBox1.Enabled = true;
            Btn_change.Visible = true;
        }

        private void Rb_detection_Click(object sender, EventArgs e)
        {
            if (Timer_tracking.Enabled == true)
            {
                Timer_tracking.Stop();
                Picturebox_colore.BackColor = Color.Transparent;
                Btn_change.Visible = false;
                sendmessage("Q");
            }
            Timer_face.Start();
            Btn_change.Visible = false;
        }

        private void Timer_tracking_Tick(object sender, EventArgs e)
        {
            sendmessage("T");
        }

        private void Timer_face_Tick(object sender, EventArgs e)
        {
            sendmessage("F");
        }

        private void Btn_change_Click(object sender, EventArgs e)
        {
            Timer_tracking.Stop();
            sendmessage("Q");
            pictureBox1.Enabled = true;
        }
        #endregion

        private void Btn_screenshot_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            bmp.Save("Screenshot" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".bmp");
        }

        private void Pb_exit_Click(object sender, EventArgs e)
        {
            if (streamexist == 1)
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
                Picturebox_colore.BackColor = target;

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
                pictureBox1.Enabled = false;
            }
        }

        private void Btn_go_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_search.Text) == true)
            {
                MessageBox.Show("inserire un valore come hostname");
                return;
            }
            string HostName = Txt_search.Text;

            IPAddress[] ipaddress = new IPAddress[100];
            try
            {
                ipaddress = Dns.GetHostAddresses(HostName);
            }
            catch (Exception a)
            {
                Label_search.Text = $"{a}, riprova";
            }

            try
            {
                foreach (IPAddress ip4 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    Label_search.Text = $"l' ip da nome è: {ip4.ToString()}";
                }
            }
            catch (NullReferenceException a)
            {
                Label_search.Text = $"l'hostname non esiste";
                return;
            }
        }

        
    }
}
