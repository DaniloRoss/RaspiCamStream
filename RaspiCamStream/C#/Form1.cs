using System;
using System.Drawing;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using AForge.Video;
using System.Linq;
using System.IO;
using Accord.Video.FFMPEG;

namespace RaspiCamStream
{
    public partial class Form1 : Form
    {
        VideoFileWriter writer = default(VideoFileWriter);
        int x = default(int);
        Bitmap bitmap = new Bitmap(640, 480);
        Bitmap bmp = default(Bitmap);
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
            pictureBox2.Visible = false;
            btZoom.Visible = false;
            trackBar1.Visible = false;
            Txt_search.BringToFront();
            Label_search.BringToFront();
            Btn_go.BringToFront();
            btVideo.Enabled = false;
            btAnteprima.Visible = false;

            using (Graphics gfx = Graphics.FromImage(bitmap))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(1, 1, 1)))
            {
                gfx.FillRectangle(brush, 0, 0, 1, 1);
            }
        }

        private void Btn_ip_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(Txt_ip.Text, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b"))
            {
                Label_ip.Text = "indirizzo non valido";
                Txt_ip.Clear();
                return;
            }

            if (Label_ip.Text != "")
            {
                Label_ip.Text = "";
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
            Btn_screenshot.Visible = true;
            Btn_ip.Visible = false;
            Txt_ip.Visible = false;
            label3.Visible = false;
            Btn_go.Visible = false;
            Txt_search.Visible = false;
            Label_search.Visible = false;
            btn_visible.Visible = true;
            pictureBox1.Visible = true;
            listBoxHostnames.Visible = false;
            Btn_eliminacronologia.Visible = false;
            btVideo.Visible = true;
            btZoom.Visible = true;
            trackBar1.Visible = true;
            pictureBox2.Visible = true;
            label2.Visible = false;
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
            btVideo.Enabled = true;
            Btn_stream.Text = "Interrompi Stream";
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
                        graphics.DrawRectangle(pen, x, y, w, h);
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
            }
            sendmessage("Q");
            Btn_change.Visible = false;
            Picturebox_colore.BackColor = Color.Transparent;
        }

        private void Rb_tracking_Click(object sender, EventArgs e)
        {
            if (Timer_face.Enabled == true)
            {
                Timer_face.Stop();
                sendmessage("Q");
            }
            pictureBox1.Enabled = true;
            Picturebox_colore.Visible = true;
        }

        private void Rb_detection_Click(object sender, EventArgs e)
        {
            if (Timer_tracking.Enabled == true)
            {
                Timer_tracking.Stop();
                sendmessage("Q");
            }
            Timer_face.Start();
            Btn_change.Visible = false;
            Picturebox_colore.BackColor = Color.Transparent;
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

        //BOTTONE PER LA RIDUZIONE DELLA FINESTRA
        private void Pb_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                int h = (int)(target.GetHue() / 2);
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
                Btn_change.Visible = true;
            }
        }

        private void Btn_go_Click(object sender, EventArgs e)
        {
            listBoxHostnames.Items.Clear();
            label2.Text = "";
            Label_search.Text = "";
            
            if (string.IsNullOrEmpty(Txt_search.Text) == true)
            {
                MessageBox.Show("inserire un valore come hostname");
                return;
            }
            string HostName = Txt_search.Text;
            Txt_search.Clear();
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
                    Label_search.Text = "l' ip da nome è: ";
                    label2.Text = ip4.ToString();
                }
            }
            catch (NullReferenceException)
            {
                Label_search.Text = $"l'hostname non esiste";
                return;
            }

            if (File.ReadAllText("hostnameListbox.txt").Contains(Txt_search.Text))
            {

            }
            else
            {
                StreamWriter scrivere = new StreamWriter("hostnameListbox.txt", true);
                scrivere.WriteLine($"{Txt_search.Text}");
                scrivere.Close();
            }

            StreamReader leggere;
            leggere = new StreamReader("hostnameListbox.txt");

            if (new FileInfo("hostnameListbox.txt").Length == 0)
            {
                leggere.Close();
                return;
            }

            while (leggere.EndOfStream == false)
            {
                listBoxHostnames.Items.Add(leggere.ReadLine());
            }

            leggere.Close();
            Txt_search.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) // listbox nomi host
        {
            Txt_search.Text = listBoxHostnames.GetItemText(listBoxHostnames.SelectedItem);
        }


        private void Form1_Load(object sender, EventArgs e) // riempie la listbox
        {
            StreamReader miofile = default(StreamReader);
            try
            {
                miofile = new StreamReader("hostnameListbox.txt");
            }
            catch (FileNotFoundException)
            {
                StreamWriter scrivere = new StreamWriter("hostnameListbox.txt", true);
                scrivere.Close();               
            }
            finally
            {
                miofile.Close();
            }

            miofile = new StreamReader("hostnameListbox.txt");

            if (new FileInfo("hostnameListbox.txt").Length == 0)
            {
                miofile.Close();
                return;
            }

            while (miofile.EndOfStream == false)
            {
                listBoxHostnames.Items.Add(miofile.ReadLine());
            }

            miofile.Close();

        }

        private void listBoxHostnames_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_search.Text = listBoxHostnames.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void Btn_eliminacronologia_Click(object sender, EventArgs e)
        {
            File.WriteAllText("hostnameListbox.txt", String.Empty);
            listBoxHostnames.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Txt_ip.Text = label2.Text;
        }

        private void btn_visible_Click(object sender, EventArgs e)
        {
            if (Stream.IsRunning == true)
            {
                Stream.Stop();
            }
            pictureBox1.Visible = false;
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
            listBoxHostnames.Visible = true;
            Btn_eliminacronologia.Visible = true;
            btVideo.Visible = false;
            btZoom.Visible = false;
            trackBar1.Visible = false;
            label2.Visible = true;
        }

        private void Btn_screenshot_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            bmp.Save("Screenshot" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".bmp");

            Bitmap newImage = ResizeBitmap(bmp, pictureBox2.Size.Width, pictureBox2.Size.Height, 0);            
            pictureBox2.Image = newImage;
            btAnteprima.Visible = true;
        }

        private void btAnteprima_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            btAnteprima.Visible = false;
        }

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height, int caso)
        {
            Bitmap result = new Bitmap(width, height);
            if (caso == 0)
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(bmp, 0, 0, width, height);
                }
            }

            if (caso == 1)
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(bmp, -(width / 4 * 10 / 15), -(height / 4 * 10 / 15), width, height);
                }
            }
            if (caso == 2)
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(bmp, -(width / 4), -(height / 4), width, height);
                }
            }
            if (caso == 3)
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(bmp, -(width * 15 / 10 / 4), -(height * 15 / 10 / 4), width, height);

                }
            }

            return result;
        }
        //cattura schermo(img)----------------------------------------------

        //cattura schermo(video)----------------------------------------------

        private void btVideo_Click(object sender, EventArgs e)
        {
            if (btVideo.ButtonText == "Inizia cattura video")
            {
                btVideo.ActiveFillColor = Color.Red;
                btVideo.ActiveLineColor = Color.Red;
                btVideo.IdleForecolor = Color.Red;
                btVideo.IdleLineColor = Color.Red;
                btVideo.ButtonText = "Termina cattura video";

                writer = new VideoFileWriter();
                writer.Open("Video" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".avi", 640, 480, 25, VideoCodec.MPEG4);
                TimerVideo.Start();
            }
            else
            {
                btVideo.ActiveFillColor = Color.SeaGreen;
                btVideo.ActiveLineColor = Color.SeaGreen;
                btVideo.IdleForecolor = Color.SeaGreen;
                btVideo.IdleLineColor = Color.SeaGreen;
                btVideo.ButtonText = "Inizia cattura video";
                TimerVideo.Stop();
                writer.Close();

            }
        }

        private void TimerVideo_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            writer.WriteVideoFrame(bmp);
        }

        //cattura schermo(video)----------------------------------------------

        //zoom----------------------------------------------------------------
        private void btZoom_Click(object sender, EventArgs e)
        {

            if (trackBar1.Value == 0)
            {
                Stream.NewFrame -= Stream_NewFrame;
                Stream.NewFrame -= Stream_NewFrame2;
                Stream.NewFrame -= Stream_NewFrame3;
                Stream.NewFrame -= Stream_NewFrame4;


                Stream.NewFrame += Stream_NewFrame;

            }
            if (trackBar1.Value == 1)
            {
                Stream.NewFrame -= Stream_NewFrame;
                Stream.NewFrame -= Stream_NewFrame2;
                Stream.NewFrame -= Stream_NewFrame3;
                Stream.NewFrame -= Stream_NewFrame4;


                Stream.NewFrame += Stream_NewFrame2;

            }
            if (trackBar1.Value == 2)
            {
                Stream.NewFrame -= Stream_NewFrame;
                Stream.NewFrame -= Stream_NewFrame2;
                Stream.NewFrame -= Stream_NewFrame3;
                Stream.NewFrame -= Stream_NewFrame4;



                Stream.NewFrame += Stream_NewFrame3;

            }
            if (trackBar1.Value == 3)
            {
                Stream.NewFrame -= Stream_NewFrame;
                Stream.NewFrame -= Stream_NewFrame2;
                Stream.NewFrame -= Stream_NewFrame3;
                Stream.NewFrame -= Stream_NewFrame4;



                Stream.NewFrame += Stream_NewFrame4;

            }
        }

        private void Stream_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();

            bitmap = ResizeBitmap(bitmap, bitmap.Width * 15 / 10, bitmap.Height * 15 / 10, 1);

            try
            {
                pictureBox1.Image = bitmap;
            }
            catch
            {

            }

        }

        private void Stream_NewFrame3(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();



            bitmap = ResizeBitmap(bitmap, bitmap.Width * 2, bitmap.Height * 2, 2);

            try
            {
                pictureBox1.Image = bitmap;
            }
            catch
            {

            }
        }

        private void Stream_NewFrame4(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();



            bitmap = ResizeBitmap(bitmap, bitmap.Width * 4, bitmap.Height * 4, 3);

            try
            {
                pictureBox1.Image = bitmap;
            }
            catch
            {

            }
        }       
    }
}