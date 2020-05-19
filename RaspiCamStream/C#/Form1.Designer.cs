namespace RaspiCamStream
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form


        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_ip = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_ip = new System.Windows.Forms.Label();
            this.listBoxHostnames = new System.Windows.Forms.ListBox();
            this.Btn_eliminacronologia = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_divieto = new System.Windows.Forms.Label();
            this.pb_centerdivieto = new System.Windows.Forms.PictureBox();
            this.pb_leftdivieto = new System.Windows.Forms.PictureBox();
            this.pb_downdivieto = new System.Windows.Forms.PictureBox();
            this.pb_rightdivieto = new System.Windows.Forms.PictureBox();
            this.pb_updivieto = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btZoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Pb_center = new System.Windows.Forms.PictureBox();
            this.Pb_left = new System.Windows.Forms.PictureBox();
            this.Pb_right = new System.Windows.Forms.PictureBox();
            this.Pb_up = new System.Windows.Forms.PictureBox();
            this.Pb_down = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ip = new System.Windows.Forms.TextBox();
            this.Label_search = new System.Windows.Forms.Label();
            this.Txt_search = new System.Windows.Forms.TextBox();
            this.Btn_go = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Rb_detection = new System.Windows.Forms.RadioButton();
            this.Rb_tracking = new System.Windows.Forms.RadioButton();
            this.Rb_normal = new System.Windows.Forms.RadioButton();
            this.Btn_stream = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Timer_up = new System.Windows.Forms.Timer(this.components);
            this.Timer_down = new System.Windows.Forms.Timer(this.components);
            this.Timer_right = new System.Windows.Forms.Timer(this.components);
            this.Timer_left = new System.Windows.Forms.Timer(this.components);
            this.Label_Search_ip = new System.Windows.Forms.Label();
            this.Timer_tracking = new System.Windows.Forms.Timer(this.components);
            this.Timer_face = new System.Windows.Forms.Timer(this.components);
            this.Picturebox_colore = new System.Windows.Forms.PictureBox();
            this.Btn_change = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_screenshot = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btVideo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TimerVideo = new System.Windows.Forms.Timer(this.components);
            this.btAnteprima = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_tracking = new System.Windows.Forms.Label();
            this.btn_visible = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Pb_exit = new System.Windows.Forms.PictureBox();
            this.Pb_minimize = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_centerdivieto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftdivieto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_downdivieto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightdivieto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_updivieto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_colore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_minimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 770);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_ip);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Label_ip);
            this.panel2.Controls.Add(this.listBoxHostnames);
            this.panel2.Controls.Add(this.Btn_eliminacronologia);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Txt_ip);
            this.panel2.Controls.Add(this.Label_search);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Txt_search);
            this.panel2.Controls.Add(this.Btn_go);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 770);
            this.panel2.TabIndex = 10;
            // 
            // Btn_ip
            // 
            this.Btn_ip.ActiveBorderThickness = 1;
            this.Btn_ip.ActiveCornerRadius = 20;
            this.Btn_ip.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_ip.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_ip.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_ip.BackColor = System.Drawing.Color.Black;
            this.Btn_ip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ip.BackgroundImage")));
            this.Btn_ip.ButtonText = "Conferma IP";
            this.Btn_ip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ip.ForeColor = System.Drawing.Color.Green;
            this.Btn_ip.IdleBorderThickness = 1;
            this.Btn_ip.IdleCornerRadius = 20;
            this.Btn_ip.IdleFillColor = System.Drawing.Color.Black;
            this.Btn_ip.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_ip.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_ip.Location = new System.Drawing.Point(416, 398);
            this.Btn_ip.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_ip.Name = "Btn_ip";
            this.Btn_ip.Size = new System.Drawing.Size(276, 59);
            this.Btn_ip.TabIndex = 37;
            this.Btn_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_ip.Click += new System.EventHandler(this.Btn_ip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(400, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(538, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Inserire l\'hostname, l\'hostname di default di Raspberry Pi è \"raspberrypi\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(540, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 35;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_ip
            // 
            this.Label_ip.AutoSize = true;
            this.Label_ip.ForeColor = System.Drawing.Color.Red;
            this.Label_ip.Location = new System.Drawing.Point(459, 450);
            this.Label_ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_ip.Name = "Label_ip";
            this.Label_ip.Size = new System.Drawing.Size(0, 17);
            this.Label_ip.TabIndex = 22;
            // 
            // listBoxHostnames
            // 
            this.listBoxHostnames.BackColor = System.Drawing.Color.Black;
            this.listBoxHostnames.ForeColor = System.Drawing.Color.White;
            this.listBoxHostnames.FormattingEnabled = true;
            this.listBoxHostnames.ItemHeight = 16;
            this.listBoxHostnames.Location = new System.Drawing.Point(734, 268);
            this.listBoxHostnames.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxHostnames.Name = "listBoxHostnames";
            this.listBoxHostnames.Size = new System.Drawing.Size(195, 180);
            this.listBoxHostnames.TabIndex = 33;
            this.listBoxHostnames.Click += new System.EventHandler(this.listBoxHostnames_Click);
            // 
            // Btn_eliminacronologia
            // 
            this.Btn_eliminacronologia.ActiveBorderThickness = 1;
            this.Btn_eliminacronologia.ActiveCornerRadius = 20;
            this.Btn_eliminacronologia.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminacronologia.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_eliminacronologia.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminacronologia.BackColor = System.Drawing.Color.Black;
            this.Btn_eliminacronologia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_eliminacronologia.BackgroundImage")));
            this.Btn_eliminacronologia.ButtonText = "Elimina cronologia";
            this.Btn_eliminacronologia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminacronologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminacronologia.ForeColor = System.Drawing.Color.Green;
            this.Btn_eliminacronologia.IdleBorderThickness = 1;
            this.Btn_eliminacronologia.IdleCornerRadius = 20;
            this.Btn_eliminacronologia.IdleFillColor = System.Drawing.Color.Black;
            this.Btn_eliminacronologia.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminacronologia.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminacronologia.Location = new System.Drawing.Point(734, 210);
            this.Btn_eliminacronologia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_eliminacronologia.Name = "Btn_eliminacronologia";
            this.Btn_eliminacronologia.Size = new System.Drawing.Size(195, 49);
            this.Btn_eliminacronologia.TabIndex = 34;
            this.Btn_eliminacronologia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_eliminacronologia.Click += new System.EventHandler(this.Btn_eliminacronologia_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_divieto);
            this.panel3.Controls.Add(this.pb_centerdivieto);
            this.panel3.Controls.Add(this.pb_leftdivieto);
            this.panel3.Controls.Add(this.pb_downdivieto);
            this.panel3.Controls.Add(this.pb_rightdivieto);
            this.panel3.Controls.Add(this.pb_updivieto);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.btZoom);
            this.panel3.Controls.Add(this.Pb_center);
            this.panel3.Controls.Add(this.Pb_left);
            this.panel3.Controls.Add(this.Pb_right);
            this.panel3.Controls.Add(this.Pb_up);
            this.panel3.Controls.Add(this.Pb_down);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 544);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 226);
            this.panel3.TabIndex = 10;
            // 
            // label_divieto
            // 
            this.label_divieto.AutoSize = true;
            this.label_divieto.ForeColor = System.Drawing.Color.Red;
            this.label_divieto.Location = new System.Drawing.Point(383, 19);
            this.label_divieto.Name = "label_divieto";
            this.label_divieto.Size = new System.Drawing.Size(125, 17);
            this.label_divieto.TabIndex = 42;
            this.label_divieto.Text = "Controlli disabilitati";
            this.label_divieto.Visible = false;
            // 
            // pb_centerdivieto
            // 
            this.pb_centerdivieto.Image = ((System.Drawing.Image)(resources.GetObject("pb_centerdivieto.Image")));
            this.pb_centerdivieto.Location = new System.Drawing.Point(243, 74);
            this.pb_centerdivieto.Name = "pb_centerdivieto";
            this.pb_centerdivieto.Size = new System.Drawing.Size(78, 63);
            this.pb_centerdivieto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_centerdivieto.TabIndex = 41;
            this.pb_centerdivieto.TabStop = false;
            this.pb_centerdivieto.Visible = false;
            // 
            // pb_leftdivieto
            // 
            this.pb_leftdivieto.Image = ((System.Drawing.Image)(resources.GetObject("pb_leftdivieto.Image")));
            this.pb_leftdivieto.Location = new System.Drawing.Point(159, 74);
            this.pb_leftdivieto.Name = "pb_leftdivieto";
            this.pb_leftdivieto.Size = new System.Drawing.Size(77, 63);
            this.pb_leftdivieto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_leftdivieto.TabIndex = 40;
            this.pb_leftdivieto.TabStop = false;
            this.pb_leftdivieto.Visible = false;
            // 
            // pb_downdivieto
            // 
            this.pb_downdivieto.Image = ((System.Drawing.Image)(resources.GetObject("pb_downdivieto.Image")));
            this.pb_downdivieto.Location = new System.Drawing.Point(244, 145);
            this.pb_downdivieto.Name = "pb_downdivieto";
            this.pb_downdivieto.Size = new System.Drawing.Size(77, 63);
            this.pb_downdivieto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_downdivieto.TabIndex = 39;
            this.pb_downdivieto.TabStop = false;
            this.pb_downdivieto.Visible = false;
            // 
            // pb_rightdivieto
            // 
            this.pb_rightdivieto.Image = ((System.Drawing.Image)(resources.GetObject("pb_rightdivieto.Image")));
            this.pb_rightdivieto.Location = new System.Drawing.Point(329, 74);
            this.pb_rightdivieto.Name = "pb_rightdivieto";
            this.pb_rightdivieto.Size = new System.Drawing.Size(78, 63);
            this.pb_rightdivieto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rightdivieto.TabIndex = 38;
            this.pb_rightdivieto.TabStop = false;
            this.pb_rightdivieto.Visible = false;
            // 
            // pb_updivieto
            // 
            this.pb_updivieto.Image = ((System.Drawing.Image)(resources.GetObject("pb_updivieto.Image")));
            this.pb_updivieto.Location = new System.Drawing.Point(244, 0);
            this.pb_updivieto.Name = "pb_updivieto";
            this.pb_updivieto.Size = new System.Drawing.Size(77, 63);
            this.pb_updivieto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_updivieto.TabIndex = 36;
            this.pb_updivieto.TabStop = false;
            this.pb_updivieto.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(646, 46);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 56);
            this.trackBar1.TabIndex = 37;
            // 
            // btZoom
            // 
            this.btZoom.ActiveBorderThickness = 1;
            this.btZoom.ActiveCornerRadius = 20;
            this.btZoom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btZoom.ActiveForecolor = System.Drawing.Color.White;
            this.btZoom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btZoom.BackColor = System.Drawing.Color.Black;
            this.btZoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btZoom.BackgroundImage")));
            this.btZoom.ButtonText = "Zoom";
            this.btZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZoom.ForeColor = System.Drawing.Color.Green;
            this.btZoom.IdleBorderThickness = 1;
            this.btZoom.IdleCornerRadius = 20;
            this.btZoom.IdleFillColor = System.Drawing.Color.Black;
            this.btZoom.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btZoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btZoom.Location = new System.Drawing.Point(646, 116);
            this.btZoom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btZoom.Name = "btZoom";
            this.btZoom.Size = new System.Drawing.Size(196, 64);
            this.btZoom.TabIndex = 36;
            this.btZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btZoom.Visible = false;
            this.btZoom.Click += new System.EventHandler(this.btZoom_Click);
            // 
            // Pb_center
            // 
            this.Pb_center.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_center.Image = ((System.Drawing.Image)(resources.GetObject("Pb_center.Image")));
            this.Pb_center.Location = new System.Drawing.Point(244, 74);
            this.Pb_center.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_center.Name = "Pb_center";
            this.Pb_center.Size = new System.Drawing.Size(77, 63);
            this.Pb_center.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_center.TabIndex = 14;
            this.Pb_center.TabStop = false;
            this.Pb_center.Visible = false;
            this.Pb_center.Click += new System.EventHandler(this.Pb_center_Click);
            // 
            // Pb_left
            // 
            this.Pb_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_left.Image = ((System.Drawing.Image)(resources.GetObject("Pb_left.Image")));
            this.Pb_left.Location = new System.Drawing.Point(159, 74);
            this.Pb_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_left.Name = "Pb_left";
            this.Pb_left.Size = new System.Drawing.Size(77, 63);
            this.Pb_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_left.TabIndex = 13;
            this.Pb_left.TabStop = false;
            this.Pb_left.Visible = false;
            this.Pb_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_left_MouseDown);
            this.Pb_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_left_MouseUp);
            // 
            // Pb_right
            // 
            this.Pb_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_right.Image = ((System.Drawing.Image)(resources.GetObject("Pb_right.Image")));
            this.Pb_right.Location = new System.Drawing.Point(329, 74);
            this.Pb_right.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_right.Name = "Pb_right";
            this.Pb_right.Size = new System.Drawing.Size(77, 63);
            this.Pb_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_right.TabIndex = 12;
            this.Pb_right.TabStop = false;
            this.Pb_right.Visible = false;
            this.Pb_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_right_MouseDown);
            this.Pb_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_right_MouseUp);
            // 
            // Pb_up
            // 
            this.Pb_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_up.Image = ((System.Drawing.Image)(resources.GetObject("Pb_up.Image")));
            this.Pb_up.Location = new System.Drawing.Point(244, 0);
            this.Pb_up.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_up.Name = "Pb_up";
            this.Pb_up.Size = new System.Drawing.Size(77, 63);
            this.Pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_up.TabIndex = 11;
            this.Pb_up.TabStop = false;
            this.Pb_up.Visible = false;
            this.Pb_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_up_MouseDown);
            this.Pb_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_up_MouseUp);
            // 
            // Pb_down
            // 
            this.Pb_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_down.Image = ((System.Drawing.Image)(resources.GetObject("Pb_down.Image")));
            this.Pb_down.Location = new System.Drawing.Point(244, 145);
            this.Pb_down.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_down.Name = "Pb_down";
            this.Pb_down.Size = new System.Drawing.Size(77, 63);
            this.Pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_down.TabIndex = 10;
            this.Pb_down.TabStop = false;
            this.Pb_down.Visible = false;
            this.Pb_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_down_MouseDown);
            this.Pb_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_down_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inserire Ip della Cam";
            // 
            // Txt_ip
            // 
            this.Txt_ip.Location = new System.Drawing.Point(416, 366);
            this.Txt_ip.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ip.Name = "Txt_ip";
            this.Txt_ip.Size = new System.Drawing.Size(276, 22);
            this.Txt_ip.TabIndex = 15;
            // 
            // Label_search
            // 
            this.Label_search.AutoSize = true;
            this.Label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_search.ForeColor = System.Drawing.Color.White;
            this.Label_search.Location = new System.Drawing.Point(417, 268);
            this.Label_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_search.Name = "Label_search";
            this.Label_search.Size = new System.Drawing.Size(0, 17);
            this.Label_search.TabIndex = 24;
            // 
            // Txt_search
            // 
            this.Txt_search.Location = new System.Drawing.Point(515, 223);
            this.Txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_search.Name = "Txt_search";
            this.Txt_search.Size = new System.Drawing.Size(177, 22);
            this.Txt_search.TabIndex = 23;
            // 
            // Btn_go
            // 
            this.Btn_go.ActiveBorderThickness = 1;
            this.Btn_go.ActiveCornerRadius = 20;
            this.Btn_go.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_go.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_go.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_go.BackColor = System.Drawing.Color.Black;
            this.Btn_go.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_go.BackgroundImage")));
            this.Btn_go.ButtonText = "Go";
            this.Btn_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_go.ForeColor = System.Drawing.Color.Green;
            this.Btn_go.IdleBorderThickness = 1;
            this.Btn_go.IdleCornerRadius = 20;
            this.Btn_go.IdleFillColor = System.Drawing.Color.Black;
            this.Btn_go.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_go.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_go.Location = new System.Drawing.Point(416, 210);
            this.Btn_go.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_go.Name = "Btn_go";
            this.Btn_go.Size = new System.Drawing.Size(89, 49);
            this.Btn_go.TabIndex = 29;
            this.Btn_go.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_go.Click += new System.EventHandler(this.Btn_go_Click);
            // 
            // Rb_detection
            // 
            this.Rb_detection.AutoSize = true;
            this.Rb_detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_detection.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_detection.Location = new System.Drawing.Point(1009, 350);
            this.Rb_detection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_detection.Name = "Rb_detection";
            this.Rb_detection.Size = new System.Drawing.Size(98, 21);
            this.Rb_detection.TabIndex = 28;
            this.Rb_detection.TabStop = true;
            this.Rb_detection.Text = "Detection";
            this.Rb_detection.UseVisualStyleBackColor = true;
            this.Rb_detection.Visible = false;
            this.Rb_detection.CheckedChanged += new System.EventHandler(this.Rb_detection_CheckedChanged);
            this.Rb_detection.Click += new System.EventHandler(this.Rb_detection_Click);
            // 
            // Rb_tracking
            // 
            this.Rb_tracking.AutoSize = true;
            this.Rb_tracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_tracking.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_tracking.Location = new System.Drawing.Point(1009, 322);
            this.Rb_tracking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_tracking.Name = "Rb_tracking";
            this.Rb_tracking.Size = new System.Drawing.Size(92, 21);
            this.Rb_tracking.TabIndex = 27;
            this.Rb_tracking.TabStop = true;
            this.Rb_tracking.Text = "Tracking";
            this.Rb_tracking.UseVisualStyleBackColor = true;
            this.Rb_tracking.Visible = false;
            this.Rb_tracking.CheckedChanged += new System.EventHandler(this.Rb_tracking_CheckedChanged);
            this.Rb_tracking.Click += new System.EventHandler(this.Rb_tracking_Click);
            // 
            // Rb_normal
            // 
            this.Rb_normal.AutoSize = true;
            this.Rb_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_normal.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_normal.Location = new System.Drawing.Point(1009, 295);
            this.Rb_normal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_normal.Name = "Rb_normal";
            this.Rb_normal.Size = new System.Drawing.Size(80, 21);
            this.Rb_normal.TabIndex = 26;
            this.Rb_normal.TabStop = true;
            this.Rb_normal.Text = "Normal";
            this.Rb_normal.UseVisualStyleBackColor = true;
            this.Rb_normal.Visible = false;
            this.Rb_normal.Click += new System.EventHandler(this.Rb_normal_Click);
            // 
            // Btn_stream
            // 
            this.Btn_stream.Active = false;
            this.Btn_stream.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_stream.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_stream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_stream.BorderRadius = 0;
            this.Btn_stream.ButtonText = "Avvia Stream";
            this.Btn_stream.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_stream.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_stream.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stream.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_stream.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_stream.Iconimage")));
            this.Btn_stream.Iconimage_right = null;
            this.Btn_stream.Iconimage_right_Selected = null;
            this.Btn_stream.Iconimage_Selected = null;
            this.Btn_stream.IconMarginLeft = 0;
            this.Btn_stream.IconMarginRight = 0;
            this.Btn_stream.IconRightVisible = true;
            this.Btn_stream.IconRightZoom = 0D;
            this.Btn_stream.IconVisible = true;
            this.Btn_stream.IconZoom = 90D;
            this.Btn_stream.IsTab = false;
            this.Btn_stream.Location = new System.Drawing.Point(995, 106);
            this.Btn_stream.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_stream.Name = "Btn_stream";
            this.Btn_stream.Normalcolor = System.Drawing.Color.DarkGreen;
            this.Btn_stream.OnHovercolor = System.Drawing.Color.Lime;
            this.Btn_stream.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_stream.selected = false;
            this.Btn_stream.Size = new System.Drawing.Size(264, 59);
            this.Btn_stream.TabIndex = 11;
            this.Btn_stream.Text = "Avvia Stream";
            this.Btn_stream.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_stream.Textcolor = System.Drawing.Color.White;
            this.Btn_stream.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stream.Visible = false;
            this.Btn_stream.Click += new System.EventHandler(this.Btn_stream_Click);
            // 
            // Timer_up
            // 
            this.Timer_up.Interval = 1;
            this.Timer_up.Tick += new System.EventHandler(this.Timer_up_Tick);
            // 
            // Timer_down
            // 
            this.Timer_down.Interval = 1;
            this.Timer_down.Tick += new System.EventHandler(this.Timer_down_Tick);
            // 
            // Timer_right
            // 
            this.Timer_right.Interval = 1;
            this.Timer_right.Tick += new System.EventHandler(this.Timer_right_Tick);
            // 
            // Timer_left
            // 
            this.Timer_left.Interval = 1;
            this.Timer_left.Tick += new System.EventHandler(this.Timer_left_Tick);
            // 
            // Label_Search_ip
            // 
            this.Label_Search_ip.AutoSize = true;
            this.Label_Search_ip.ForeColor = System.Drawing.Color.Red;
            this.Label_Search_ip.Location = new System.Drawing.Point(1005, 334);
            this.Label_Search_ip.Name = "Label_Search_ip";
            this.Label_Search_ip.Size = new System.Drawing.Size(0, 17);
            this.Label_Search_ip.TabIndex = 21;
            // 
            // Timer_tracking
            // 
            this.Timer_tracking.Interval = 10;
            this.Timer_tracking.Tick += new System.EventHandler(this.Timer_tracking_Tick);
            // 
            // Timer_face
            // 
            this.Timer_face.Interval = 10;
            this.Timer_face.Tick += new System.EventHandler(this.Timer_face_Tick);
            // 
            // Picturebox_colore
            // 
            this.Picturebox_colore.Location = new System.Drawing.Point(1124, 295);
            this.Picturebox_colore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Picturebox_colore.Name = "Picturebox_colore";
            this.Picturebox_colore.Size = new System.Drawing.Size(79, 75);
            this.Picturebox_colore.TabIndex = 30;
            this.Picturebox_colore.TabStop = false;
            this.Picturebox_colore.Visible = false;
            // 
            // Btn_change
            // 
            this.Btn_change.ActiveBorderThickness = 1;
            this.Btn_change.ActiveCornerRadius = 20;
            this.Btn_change.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_change.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_change.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_change.BackColor = System.Drawing.Color.Black;
            this.Btn_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_change.BackgroundImage")));
            this.Btn_change.ButtonText = "Cambia Colore";
            this.Btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_change.ForeColor = System.Drawing.Color.Green;
            this.Btn_change.IdleBorderThickness = 1;
            this.Btn_change.IdleCornerRadius = 20;
            this.Btn_change.IdleFillColor = System.Drawing.Color.Black;
            this.Btn_change.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_change.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_change.Location = new System.Drawing.Point(1203, 289);
            this.Btn_change.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_change.Name = "Btn_change";
            this.Btn_change.Size = new System.Drawing.Size(89, 89);
            this.Btn_change.TabIndex = 31;
            this.Btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_change.Visible = false;
            this.Btn_change.Click += new System.EventHandler(this.Btn_change_Click);
            // 
            // Btn_screenshot
            // 
            this.Btn_screenshot.ActiveBorderThickness = 1;
            this.Btn_screenshot.ActiveCornerRadius = 20;
            this.Btn_screenshot.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_screenshot.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_screenshot.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_screenshot.BackColor = System.Drawing.Color.Black;
            this.Btn_screenshot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_screenshot.BackgroundImage")));
            this.Btn_screenshot.ButtonText = "Screenshot";
            this.Btn_screenshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_screenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_screenshot.ForeColor = System.Drawing.Color.Green;
            this.Btn_screenshot.IdleBorderThickness = 1;
            this.Btn_screenshot.IdleCornerRadius = 20;
            this.Btn_screenshot.IdleFillColor = System.Drawing.Color.Black;
            this.Btn_screenshot.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_screenshot.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_screenshot.Location = new System.Drawing.Point(1009, 437);
            this.Btn_screenshot.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_screenshot.Name = "Btn_screenshot";
            this.Btn_screenshot.Size = new System.Drawing.Size(283, 64);
            this.Btn_screenshot.TabIndex = 32;
            this.Btn_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_screenshot.Visible = false;
            this.Btn_screenshot.Click += new System.EventHandler(this.Btn_screenshot_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1008, 598);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 152);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // btVideo
            // 
            this.btVideo.ActiveBorderThickness = 1;
            this.btVideo.ActiveCornerRadius = 20;
            this.btVideo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btVideo.ActiveForecolor = System.Drawing.Color.White;
            this.btVideo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btVideo.BackColor = System.Drawing.Color.Black;
            this.btVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVideo.BackgroundImage")));
            this.btVideo.ButtonText = "Inizia cattura video";
            this.btVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVideo.ForeColor = System.Drawing.Color.Green;
            this.btVideo.IdleBorderThickness = 1;
            this.btVideo.IdleCornerRadius = 20;
            this.btVideo.IdleFillColor = System.Drawing.Color.Black;
            this.btVideo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btVideo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btVideo.Location = new System.Drawing.Point(1008, 500);
            this.btVideo.Margin = new System.Windows.Forms.Padding(5);
            this.btVideo.Name = "btVideo";
            this.btVideo.Size = new System.Drawing.Size(284, 62);
            this.btVideo.TabIndex = 35;
            this.btVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btVideo.Click += new System.EventHandler(this.btVideo_Click);
            // 
            // TimerVideo
            // 
            this.TimerVideo.Interval = 25;
            this.TimerVideo.Tick += new System.EventHandler(this.TimerVideo_Tick);
            // 
            // btAnteprima
            // 
            this.btAnteprima.ActiveBorderThickness = 1;
            this.btAnteprima.ActiveCornerRadius = 20;
            this.btAnteprima.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btAnteprima.ActiveForecolor = System.Drawing.Color.White;
            this.btAnteprima.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btAnteprima.BackColor = System.Drawing.Color.Black;
            this.btAnteprima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAnteprima.BackgroundImage")));
            this.btAnteprima.ButtonText = "Ok";
            this.btAnteprima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnteprima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnteprima.ForeColor = System.Drawing.Color.Green;
            this.btAnteprima.IdleBorderThickness = 1;
            this.btAnteprima.IdleCornerRadius = 20;
            this.btAnteprima.IdleFillColor = System.Drawing.Color.Black;
            this.btAnteprima.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btAnteprima.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btAnteprima.Location = new System.Drawing.Point(1009, 750);
            this.btAnteprima.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btAnteprima.Name = "btAnteprima";
            this.btAnteprima.Size = new System.Drawing.Size(283, 64);
            this.btAnteprima.TabIndex = 36;
            this.btAnteprima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAnteprima.Visible = false;
            this.btAnteprima.Click += new System.EventHandler(this.btAnteprima_Click);
            // 
            // label_tracking
            // 
            this.label_tracking.AutoSize = true;
            this.label_tracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tracking.ForeColor = System.Drawing.Color.White;
            this.label_tracking.Location = new System.Drawing.Point(1040, 384);
            this.label_tracking.Name = "label_tracking";
            this.label_tracking.Size = new System.Drawing.Size(229, 17);
            this.label_tracking.TabIndex = 37;
            this.label_tracking.Text = "Seleziona l\'oggetto da seguire";
            // 
            // btn_visible
            // 
            this.btn_visible.ActiveBorderThickness = 1;
            this.btn_visible.ActiveCornerRadius = 20;
            this.btn_visible.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_visible.ActiveForecolor = System.Drawing.Color.White;
            this.btn_visible.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_visible.BackColor = System.Drawing.Color.Black;
            this.btn_visible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_visible.BackgroundImage")));
            this.btn_visible.ButtonText = "IP";
            this.btn_visible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_visible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visible.ForeColor = System.Drawing.Color.Green;
            this.btn_visible.IdleBorderThickness = 1;
            this.btn_visible.IdleCornerRadius = 20;
            this.btn_visible.IdleFillColor = System.Drawing.Color.Black;
            this.btn_visible.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_visible.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_visible.Location = new System.Drawing.Point(1262, 98);
            this.btn_visible.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_visible.Name = "btn_visible";
            this.btn_visible.Size = new System.Drawing.Size(66, 75);
            this.btn_visible.TabIndex = 38;
            this.btn_visible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_visible.Visible = false;
            this.btn_visible.Click += new System.EventHandler(this.btn_visible_Click);
            // 
            // Pb_exit
            // 
            this.Pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("Pb_exit.Image")));
            this.Pb_exit.Location = new System.Drawing.Point(17, 5);
            this.Pb_exit.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_exit.Name = "Pb_exit";
            this.Pb_exit.Size = new System.Drawing.Size(36, 33);
            this.Pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_exit.TabIndex = 0;
            this.Pb_exit.TabStop = false;
            this.Pb_exit.Click += new System.EventHandler(this.Pb_exit_Click);
            // 
            // Pb_minimize
            // 
            this.Pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("Pb_minimize.Image")));
            this.Pb_minimize.Location = new System.Drawing.Point(61, 5);
            this.Pb_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_minimize.Name = "Pb_minimize";
            this.Pb_minimize.Size = new System.Drawing.Size(36, 33);
            this.Pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_minimize.TabIndex = 1;
            this.Pb_minimize.TabStop = false;
            this.Pb_minimize.Click += new System.EventHandler(this.Pb_minimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Pb_minimize);
            this.panel1.Controls.Add(this.Pb_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1353, 814);
            this.ControlBox = false;
            this.Controls.Add(this.btn_visible);
            this.Controls.Add(this.label_tracking);
            this.Controls.Add(this.btAnteprima);
            this.Controls.Add(this.Btn_screenshot);
            this.Controls.Add(this.Btn_change);
            this.Controls.Add(this.Picturebox_colore);
            this.Controls.Add(this.Rb_detection);
            this.Controls.Add(this.Rb_tracking);
            this.Controls.Add(this.btVideo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rb_normal);
            this.Controls.Add(this.Label_Search_ip);
            this.Controls.Add(this.Btn_stream);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaspiCamStream";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_centerdivieto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftdivieto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_downdivieto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightdivieto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_updivieto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_colore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_minimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_stream;
        private System.Windows.Forms.PictureBox Pb_down;
        private System.Windows.Forms.PictureBox Pb_up;
        private System.Windows.Forms.PictureBox Pb_right;
        private System.Windows.Forms.PictureBox Pb_left;
        private System.Windows.Forms.PictureBox Pb_center;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ip;
        private System.Windows.Forms.Timer Timer_up;
        private System.Windows.Forms.Timer Timer_down;
        private System.Windows.Forms.Timer Timer_right;
        private System.Windows.Forms.Timer Timer_left;
        private System.Windows.Forms.Label Label_Search_ip;
        private System.Windows.Forms.Label Label_ip;
        private System.Windows.Forms.Timer Timer_tracking;
        private System.Windows.Forms.Timer Timer_face;
        private System.Windows.Forms.RadioButton Rb_detection;
        private System.Windows.Forms.RadioButton Rb_tracking;
        private System.Windows.Forms.RadioButton Rb_normal;
        private System.Windows.Forms.TextBox Txt_search;
        private System.Windows.Forms.Label Label_search;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_go;
        private System.Windows.Forms.PictureBox Picturebox_colore;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_change;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_screenshot;
        private System.Windows.Forms.ListBox listBoxHostnames;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_eliminacronologia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btVideo;
        private System.Windows.Forms.Timer TimerVideo;
        private Bunifu.Framework.UI.BunifuThinButton2 btZoom;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btAnteprima;
        private System.Windows.Forms.PictureBox pb_updivieto;
        private System.Windows.Forms.Label label_divieto;
        private System.Windows.Forms.PictureBox pb_centerdivieto;
        private System.Windows.Forms.PictureBox pb_leftdivieto;
        private System.Windows.Forms.PictureBox pb_downdivieto;
        private System.Windows.Forms.PictureBox pb_rightdivieto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_tracking;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_ip;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_visible;
        private System.Windows.Forms.PictureBox Pb_exit;
        private System.Windows.Forms.PictureBox Pb_minimize;
        private System.Windows.Forms.Panel panel1;
    }

}