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

            sendmessage("C");

            Stream.NewFrame += Stream_NewFrame;
            streamexist = 1;
            Txt_ip.Clear();
            Pb_up.Visible = true; Pb_left.Visible = true; Pb_right.Visible = true; Pb_down.Visible = true; Pb_center.Visible = true;
            Btn_stream.Visible = true; Btn_go.Visible = true; Rb_normal.Visible = true;
            Rb_tracking.Visible = true;
            Rb_detection.Visible = true;
            Picturebox_colore.Visible = true;
            Btn_change.Visible = true;
            Btn_screenshot.Visible = true;
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
                Btn_stream.Text = "Riprendi stream";
                return;
            }
            if (Stream.IsRunning == false)
            {
                Stream.Start();
                Btn_stream.Normalcolor = Color.DarkRed;
                Btn_stream.OnHovercolor = Color.Red;
                Btn_stream.Iconimage = new Bitmap("stop.png");
                Rb_tracking.Enabled = true;
                Rb_detection.Enabled = true;
                Btn_screenshot.Enabled = true;
                Btn_stream.Text = "Interrompi stream";
                return;
            }
        }

        private void sendmessage(string msg)
        {
            TcpClient clientSocket = new TcpClient();
            try
            {
                clientSocket.Connect($"{ip}", 8081);
            }
            catch (SocketException)
            {
                MessageBox.Show("L'IP inserito non è corretto o il raspberry pi non risponde, riprova");
                return;
            }

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
        //VARIABILI GLOBALI NECESSARIE PER LA RESPONSIVITA'
        Point btn_streamax = new Point(1536, 149); Point btn_streammin = new Point(746, 86);
        Point btn_gomax = new Point(1538, 221); Point btn_gomin = new Point(748, 158);
        Point txt_searchmax = new Point(1619, 233); Point txt_searchmin = new Point(829, 170);
        Point rbnormalmax = new Point(1547, 303); Point rbnormalmin = new Point(757, 240);
        Point rbtrackramx = new Point(1547, 325); Point rbtrackmin = new Point(757, 262);
        Point rbdetectmax = new Point(1547, 347); Point rbdetectmin = new Point(757, 284);
        Point pbcoloremax = new Point(1633, 303); Point pbcolormin = new Point(843, 240);
        Point btnchangemax = new Point(1692, 298); Point btnchangemin = new Point(902, 235);
        Point btnscreenmax = new Point(1547, 418); Point btn_screenmin = new Point(757, 355);
        Point pbupmax = new Point(507, 3); Point pbupmin = new Point(183, 0);
        Point pbleftmax = new Point(443, 63); Point pbleftmin = new Point(119, 60);
        Point pbrightmax = new Point(571, 63); Point pbrightmin = new Point(247, 60);
        Point pbdownmax = new Point(507, 121); Point pbdownmin = new Point(183, 118);
        Point pbcentermax = new Point(507, 63); Point pbcentermin = new Point(183, 60);
        Point label3max = new Point(777, 26); Point label3min = new Point(453, 23);
        Point txtipmax = new Point(737, 51); Point txtipmin = new Point(413, 48);
        Point btnipmax = new Point(737, 83); Point btn_ipmin = new Point(413, 80);
        Size panel2max = new Size(1500, 625); Size panel2min = new Size(716, 625);
        Size pb1max = new Size(1500, 625); Size pb1min = new Size(716, 625);
        //BOTTONE PER LA RIDUZIONE DELLA FINESTRA
        private void Pb_minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Btn_stream.Location = btn_streammin;
                Btn_go.Location = btn_gomin;
                Txt_search.Location = txt_searchmin;
                Rb_normal.Location = rbnormalmin;
                Rb_tracking.Location = rbtrackmin;
                Rb_detection.Location = rbdetectmin;
                Picturebox_colore.Location = pbcolormin;
                Btn_change.Location = btnchangemin;
                Btn_screenshot.Location = btn_screenmin;
                Pb_up.Location = pbupmin;
                Pb_left.Location = pbleftmin;
                Pb_right.Location = pbrightmin;
                Pb_down.Location = pbdownmin;
                Pb_center.Location = pbcentermin;
                label3.Location = label3min;
                Txt_ip.Location = txtipmin;
                Btn_ip.Location = btn_ipmin;
                panel2.Size = panel2min;
                pictureBox1.Size = pb1min;

                return;
            }
            this.WindowState = FormWindowState.Minimized;
        }
        //BOTTONE PER LA MASSIMIZZAZIONE DELLA FINESTRA
        private void Pb_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                Btn_stream.Location = btn_streamax;
                Btn_go.Location = btn_gomax;
                Txt_search.Location = txt_searchmax;
                Rb_normal.Location = rbnormalmax;
                Rb_tracking.Location = rbtrackramx;
                Rb_detection.Location = rbdetectmax;
                Picturebox_colore.Location = pbcoloremax;
                Btn_change.Location = btnchangemax;
                Btn_screenshot.Location = btnscreenmax;
                Pb_up.Location = pbupmax;
                Pb_left.Location = pbleftmax;
                Pb_right.Location = pbrightmax;
                Pb_down.Location = pbdownmax;
                Pb_center.Location = pbcentermax;
                label3.Location = label3max;
                Txt_ip.Location = txtipmax;
                Btn_ip.Location = btnipmax;
                panel2.Size = panel2max;
                pictureBox1.Size = pb1max;

                return;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Btn_stream.Location = btn_streammin;
                Btn_go.Location = btn_gomin;
                Txt_search.Location = txt_searchmin;
                Rb_normal.Location = rbnormalmin;
                Rb_tracking.Location = rbtrackmin;
                Rb_detection.Location = rbdetectmin;
                Picturebox_colore.Location = pbcolormin;
                Btn_change.Location = btnchangemin;
                Btn_screenshot.Location = btn_screenmin;
                Pb_up.Location = pbupmin;
                Pb_left.Location = pbleftmin;
                Pb_right.Location = pbrightmin;
                Pb_down.Location = pbdownmin;
                Pb_center.Location = pbcentermin;
                label3.Location = label3min;
                Txt_ip.Location = txtipmin;
                Btn_ip.Location = btn_ipmin;
                panel2.Size = panel2min;
                pictureBox1.Size = pb1min;
            }

            
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
                if (v >= 30)
                    min_v = v - 30;
                else
                    min_v = 0;
                if (h <= 169)
                    max_h = h + 10;
                else
                    max_h = 179;
                if (s <= 215)
                    max_s = s + 40;
                else
                    max_s = 255;
                if (v <= 205)
                    max_v = v + 50;
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

            if (File.ReadAllText("hostnameListbox.txt").Contains(Txt_search.Text) == false)
            {
                using (StreamWriter scrivere = new StreamWriter("hostnameListbox.txt", true))
                {
                    scrivere.WriteLine($"{Txt_search.Text}");
                }
            }

            using (StreamReader leggere = new StreamReader("hostnameListbox.txt"))
            {
                listBx_hostNames.Items.Clear();
                if (new FileInfo("hostnameListbox.txt").Length == 0)
                {
                    return;
                }
                while (leggere.EndOfStream == false)
                {
                    listBx_hostNames.Items.Add(leggere.ReadLine());
                }
            }

            try
            {
                foreach (IPAddress ip4 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    Label_search.Text = $"l' ip da nome è: {ip4.ToString()}";
                }
            }
            catch (NullReferenceException)
            {
                Label_search.Text = $"l'hostname non esiste";
                return;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) // listbox nomi host
        {
            txtBoxHostname.Text = listBoxHostnames.GetItemText(listBoxHostnames.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e) // pulsante elimina cronologia
        {
            File.WriteAllText("hostnameListbox.txt", String.Empty);
            listBoxHostnames.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e) // riempie la listbox
        {

            try
            {
                StreamReader miofile = new StreamReader("hostnameListbox.txt");
                miofile.Close();
            }
            catch (FileNotFoundException)
            {
                StreamWriter scrivere = new StreamWriter("hostnameListbox.txt", true);
                scrivere.Close();
            }




            using (StreamReader miofile = new StreamReader("hostnameListbox.txt"))
            {
                if (new FileInfo("hostnameListbox.txt").Length == 0)
                {
                    miofile.Close();
                    return;
                }

                while (miofile.EndOfStream == false)
                {
                    listBx_hostNames.Items.Add(miofile.ReadLine());
                }
            }

        }
        private void btn_visible_Click(object sender, EventArgs e)
        {
            Pb_up.Visible = false; Pb_left.Visible = false; Pb_right.Visible = false; Pb_down.Visible = false; Pb_center.Visible = false;
            Btn_stream.Visible = false; Btn_go.Visible = false; Rb_normal.Visible = false;
            Rb_tracking.Visible = false;
            Rb_detection.Visible = false;
            Picturebox_colore.Visible = false;
            Btn_change.Visible = false;
            Btn_screenshot.Visible = false;
            Btn_ip.Visible = true;
            Txt_ip.Visible = true;
            label3.Visible = true;
            Btn_go.Visible = true;
            Txt_search.Visible = true;
            Label_search.Visible = true;
            btn_visible.Visible = false;

            Stream.Stop();
            pictureBox1.Image = null;
            return;
        }
    }
}
