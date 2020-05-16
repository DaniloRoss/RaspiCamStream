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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pb_maximize = new System.Windows.Forms.PictureBox();
            this.Pb_minimize = new System.Windows.Forms.PictureBox();
            this.Pb_exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_ip = new System.Windows.Forms.Label();
            this.Btn_ip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ip = new System.Windows.Forms.TextBox();
            this.Pb_center = new System.Windows.Forms.PictureBox();
            this.Pb_left = new System.Windows.Forms.PictureBox();
            this.Pb_right = new System.Windows.Forms.PictureBox();
            this.Pb_up = new System.Windows.Forms.PictureBox();
            this.Pb_down = new System.Windows.Forms.PictureBox();
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Txt_search = new System.Windows.Forms.TextBox();
            this.Label_search = new System.Windows.Forms.Label();
            this.Btn_go = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Picturebox_colore = new System.Windows.Forms.PictureBox();
            this.Btn_change = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_screenshot = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_visible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_colore)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 625);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Pb_maximize);
            this.panel1.Controls.Add(this.Pb_minimize);
            this.panel1.Controls.Add(this.Pb_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 36);
            this.panel1.TabIndex = 0;
            // 
            // Pb_maximize
            // 
            this.Pb_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_maximize.Image = ((System.Drawing.Image)(resources.GetObject("Pb_maximize.Image")));
            this.Pb_maximize.Location = new System.Drawing.Point(79, 4);
            this.Pb_maximize.Name = "Pb_maximize";
            this.Pb_maximize.Size = new System.Drawing.Size(27, 27);
            this.Pb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_maximize.TabIndex = 2;
            this.Pb_maximize.TabStop = false;
            this.Pb_maximize.Click += new System.EventHandler(this.Pb_maximize_Click);
            // 
            // Pb_minimize
            // 
            this.Pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("Pb_minimize.Image")));
            this.Pb_minimize.Location = new System.Drawing.Point(46, 4);
            this.Pb_minimize.Name = "Pb_minimize";
            this.Pb_minimize.Size = new System.Drawing.Size(27, 27);
            this.Pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_minimize.TabIndex = 1;
            this.Pb_minimize.TabStop = false;
            this.Pb_minimize.Click += new System.EventHandler(this.Pb_minimize_Click);
            // 
            // Pb_exit
            // 
            this.Pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("Pb_exit.Image")));
            this.Pb_exit.Location = new System.Drawing.Point(13, 4);
            this.Pb_exit.Name = "Pb_exit";
            this.Pb_exit.Size = new System.Drawing.Size(27, 27);
            this.Pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_exit.TabIndex = 0;
            this.Pb_exit.TabStop = false;
            this.Pb_exit.Click += new System.EventHandler(this.Pb_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 625);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_visible);
            this.panel3.Controls.Add(this.Label_ip);
            this.panel3.Controls.Add(this.Btn_ip);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Txt_ip);
            this.panel3.Controls.Add(this.Pb_center);
            this.panel3.Controls.Add(this.Pb_left);
            this.panel3.Controls.Add(this.Pb_right);
            this.panel3.Controls.Add(this.Pb_up);
            this.panel3.Controls.Add(this.Pb_down);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 184);
            this.panel3.TabIndex = 10;
            // 
            // Label_ip
            // 
            this.Label_ip.AutoSize = true;
            this.Label_ip.ForeColor = System.Drawing.Color.Red;
            this.Label_ip.Location = new System.Drawing.Point(310, 50);
            this.Label_ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_ip.Name = "Label_ip";
            this.Label_ip.Size = new System.Drawing.Size(0, 13);
            this.Label_ip.TabIndex = 22;
            // 
            // Btn_ip
            // 
            this.Btn_ip.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ip.ForeColor = System.Drawing.Color.White;
            this.Btn_ip.Location = new System.Drawing.Point(413, 80);
            this.Btn_ip.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ip.Name = "Btn_ip";
            this.Btn_ip.Size = new System.Drawing.Size(207, 35);
            this.Btn_ip.TabIndex = 17;
            this.Btn_ip.Text = "Conferma IP";
            this.Btn_ip.UseVisualStyleBackColor = false;
            this.Btn_ip.Click += new System.EventHandler(this.Btn_ip_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inserire Ip della Cam";
            // 
            // Txt_ip
            // 
            this.Txt_ip.Location = new System.Drawing.Point(413, 48);
            this.Txt_ip.Name = "Txt_ip";
            this.Txt_ip.Size = new System.Drawing.Size(208, 20);
            this.Txt_ip.TabIndex = 15;
            // 
            // Pb_center
            // 
            this.Pb_center.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_center.Image = ((System.Drawing.Image)(resources.GetObject("Pb_center.Image")));
            this.Pb_center.Location = new System.Drawing.Point(183, 60);
            this.Pb_center.Name = "Pb_center";
            this.Pb_center.Size = new System.Drawing.Size(58, 51);
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
            this.Pb_left.Location = new System.Drawing.Point(119, 60);
            this.Pb_left.Name = "Pb_left";
            this.Pb_left.Size = new System.Drawing.Size(58, 51);
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
            this.Pb_right.Location = new System.Drawing.Point(247, 60);
            this.Pb_right.Name = "Pb_right";
            this.Pb_right.Size = new System.Drawing.Size(58, 51);
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
            this.Pb_up.Location = new System.Drawing.Point(183, 0);
            this.Pb_up.Name = "Pb_up";
            this.Pb_up.Size = new System.Drawing.Size(58, 51);
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
            this.Pb_down.Location = new System.Drawing.Point(183, 118);
            this.Pb_down.Name = "Pb_down";
            this.Pb_down.Size = new System.Drawing.Size(58, 51);
            this.Pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_down.TabIndex = 10;
            this.Pb_down.TabStop = false;
            this.Pb_down.Visible = false;
            this.Pb_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_down_MouseDown);
            this.Pb_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_down_MouseUp);
            // 
            // Rb_detection
            // 
            this.Rb_detection.AutoSize = true;
            this.Rb_detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_detection.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_detection.Location = new System.Drawing.Point(757, 284);
            this.Rb_detection.Margin = new System.Windows.Forms.Padding(2);
            this.Rb_detection.Name = "Rb_detection";
            this.Rb_detection.Size = new System.Drawing.Size(80, 17);
            this.Rb_detection.TabIndex = 28;
            this.Rb_detection.TabStop = true;
            this.Rb_detection.Text = "Detection";
            this.Rb_detection.UseVisualStyleBackColor = true;
            this.Rb_detection.Visible = false;
            this.Rb_detection.Click += new System.EventHandler(this.Rb_detection_Click);
            // 
            // Rb_tracking
            // 
            this.Rb_tracking.AutoSize = true;
            this.Rb_tracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_tracking.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_tracking.Location = new System.Drawing.Point(757, 262);
            this.Rb_tracking.Margin = new System.Windows.Forms.Padding(2);
            this.Rb_tracking.Name = "Rb_tracking";
            this.Rb_tracking.Size = new System.Drawing.Size(75, 17);
            this.Rb_tracking.TabIndex = 27;
            this.Rb_tracking.TabStop = true;
            this.Rb_tracking.Text = "Tracking";
            this.Rb_tracking.UseVisualStyleBackColor = true;
            this.Rb_tracking.Visible = false;
            this.Rb_tracking.Click += new System.EventHandler(this.Rb_tracking_Click);
            // 
            // Rb_normal
            // 
            this.Rb_normal.AutoSize = true;
            this.Rb_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_normal.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_normal.Location = new System.Drawing.Point(757, 240);
            this.Rb_normal.Margin = new System.Windows.Forms.Padding(2);
            this.Rb_normal.Name = "Rb_normal";
            this.Rb_normal.Size = new System.Drawing.Size(64, 17);
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
            this.Btn_stream.Location = new System.Drawing.Point(746, 86);
            this.Btn_stream.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_stream.Name = "Btn_stream";
            this.Btn_stream.Normalcolor = System.Drawing.Color.DarkGreen;
            this.Btn_stream.OnHovercolor = System.Drawing.Color.Lime;
            this.Btn_stream.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_stream.selected = false;
            this.Btn_stream.Size = new System.Drawing.Size(198, 48);
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
            this.Label_Search_ip.Location = new System.Drawing.Point(754, 271);
            this.Label_Search_ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Search_ip.Name = "Label_Search_ip";
            this.Label_Search_ip.Size = new System.Drawing.Size(0, 13);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Txt_search
            // 
            this.Txt_search.Location = new System.Drawing.Point(829, 170);
            this.Txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_search.Name = "Txt_search";
            this.Txt_search.Size = new System.Drawing.Size(116, 20);
            this.Txt_search.TabIndex = 23;
            // 
            // Label_search
            // 
            this.Label_search.AutoSize = true;
            this.Label_search.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_search.Location = new System.Drawing.Point(814, 206);
            this.Label_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_search.Name = "Label_search";
            this.Label_search.Size = new System.Drawing.Size(0, 13);
            this.Label_search.TabIndex = 24;
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
            this.Btn_go.Location = new System.Drawing.Point(748, 158);
            this.Btn_go.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_go.Name = "Btn_go";
            this.Btn_go.Size = new System.Drawing.Size(67, 40);
            this.Btn_go.TabIndex = 29;
            this.Btn_go.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_go.Click += new System.EventHandler(this.Btn_go_Click);
            // 
            // Picturebox_colore
            // 
            this.Picturebox_colore.Location = new System.Drawing.Point(843, 240);
            this.Picturebox_colore.Margin = new System.Windows.Forms.Padding(2);
            this.Picturebox_colore.Name = "Picturebox_colore";
            this.Picturebox_colore.Size = new System.Drawing.Size(59, 61);
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
            this.Btn_change.Location = new System.Drawing.Point(902, 235);
            this.Btn_change.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_change.Name = "Btn_change";
            this.Btn_change.Size = new System.Drawing.Size(67, 72);
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
            this.Btn_screenshot.Location = new System.Drawing.Point(757, 355);
            this.Btn_screenshot.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_screenshot.Name = "Btn_screenshot";
            this.Btn_screenshot.Size = new System.Drawing.Size(212, 52);
            this.Btn_screenshot.TabIndex = 32;
            this.Btn_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_screenshot.Visible = false;
            this.Btn_screenshot.Click += new System.EventHandler(this.Btn_screenshot_Click);
            // 
            // btn_visible
            // 
            this.btn_visible.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_visible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visible.ForeColor = System.Drawing.Color.White;
            this.btn_visible.Location = new System.Drawing.Point(642, 60);
            this.btn_visible.Margin = new System.Windows.Forms.Padding(2);
            this.btn_visible.Name = "btn_visible";
            this.btn_visible.Size = new System.Drawing.Size(46, 35);
            this.btn_visible.TabIndex = 23;
            this.btn_visible.Text = "IP";
            this.btn_visible.UseVisualStyleBackColor = false;
            this.btn_visible.Visible = false;
            this.btn_visible.Click += new System.EventHandler(this.btn_visible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1015, 661);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_screenshot);
            this.Controls.Add(this.Btn_change);
            this.Controls.Add(this.Picturebox_colore);
            this.Controls.Add(this.Btn_go);
            this.Controls.Add(this.Rb_detection);
            this.Controls.Add(this.Label_search);
            this.Controls.Add(this.Rb_tracking);
            this.Controls.Add(this.Txt_search);
            this.Controls.Add(this.Rb_normal);
            this.Controls.Add(this.Label_Search_ip);
            this.Controls.Add(this.Btn_stream);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_colore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_stream;
        private System.Windows.Forms.PictureBox Pb_down;
        private System.Windows.Forms.PictureBox Pb_up;
        private System.Windows.Forms.PictureBox Pb_right;
        private System.Windows.Forms.PictureBox Pb_left;
        private System.Windows.Forms.PictureBox Pb_center;
        private System.Windows.Forms.PictureBox Pb_maximize;
        private System.Windows.Forms.PictureBox Pb_minimize;
        private System.Windows.Forms.PictureBox Pb_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ip;
        private System.Windows.Forms.Timer Timer_up;
        private System.Windows.Forms.Timer Timer_down;
        private System.Windows.Forms.Timer Timer_right;
        private System.Windows.Forms.Timer Timer_left;
        private System.Windows.Forms.Button Btn_ip;
        private System.Windows.Forms.Label Label_Search_ip;
        private System.Windows.Forms.Label Label_ip;
        private System.Windows.Forms.Timer Timer_tracking;
        private System.Windows.Forms.Timer Timer_face;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.RadioButton Rb_detection;
        private System.Windows.Forms.RadioButton Rb_tracking;
        private System.Windows.Forms.RadioButton Rb_normal;
        private System.Windows.Forms.TextBox Txt_search;
        private System.Windows.Forms.Label Label_search;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_go;
        private System.Windows.Forms.PictureBox Picturebox_colore;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_change;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_screenshot;
        private System.Windows.Forms.Button btn_visible;
    }
}

