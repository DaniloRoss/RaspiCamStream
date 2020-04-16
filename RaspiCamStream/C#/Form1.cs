using System;
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
    }
}
