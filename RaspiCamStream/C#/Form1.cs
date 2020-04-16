﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspiCamStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
            label1.Text= returndata;
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
    }
}
 #endregion