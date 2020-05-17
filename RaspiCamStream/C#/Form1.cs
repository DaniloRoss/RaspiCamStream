using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
         MJPEGStream Stream;
        private delegate void SafeCallDelegate(string ip, string nome, ListView listview);
        private int numIp;
        string ip = default(string);
        int streamexist = default(int);

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(640, 480);
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
            Stream.NewFrame += Stream_NewFrame;
            streamexist = 1;
            Txt_ip.Clear();
        }

        //STREAMING LATO CLIENT E FACE DETECTION (opzionale)
        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (radioButton1.Checked == true)
            {
                CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                Image<Bgr, byte> grayimage = new Image<Bgr, byte>(bitmap);
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayimage, 1.2, 1);
                foreach (Rectangle rectangle in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 5))
                        {
                            graphics.DrawRectangle(pen, rectangle);
                        }
                    }
                }
                pictureBox1.Image = bitmap;
            }

            if (radioButton2.Checked == true)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                pictureBox1.Image = bitmap;

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
            string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
            label1.Text = returndata;
            clientSocket.Close();
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
        #endregion
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

        private void button2_Click(object sender, EventArgs e) //pulsante da host a ip textBoxHostIP
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

        private void Form1_Load_1(object sender, EventArgs e)
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
                    listBoxHostnames.Items.Add(miofile.ReadLine());
                }
            }
        }
    }
}





