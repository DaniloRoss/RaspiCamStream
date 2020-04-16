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
		private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Stream.Stop();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
