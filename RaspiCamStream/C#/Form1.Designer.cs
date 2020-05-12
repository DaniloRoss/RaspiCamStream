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
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Rb_detection = new System.Windows.Forms.RadioButton();
            this.Rb_tracking = new System.Windows.Forms.RadioButton();
            this.Rb_normal = new System.Windows.Forms.RadioButton();
            this.Btn_screen = new System.Windows.Forms.Button();
            this.Label_ip = new System.Windows.Forms.Label();
            this.Btn_ip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ip = new System.Windows.Forms.TextBox();
            this.Pb_center = new System.Windows.Forms.PictureBox();
            this.Pb_left = new System.Windows.Forms.PictureBox();
            this.Pb_right = new System.Windows.Forms.PictureBox();
            this.Pb_up = new System.Windows.Forms.PictureBox();
            this.Pb_down = new System.Windows.Forms.PictureBox();
            this.Btn_stream = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ListView_ip = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Txt_Search_ip = new System.Windows.Forms.TextBox();
            this.Btn_go = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Timer_up = new System.Windows.Forms.Timer(this.components);
            this.Timer_down = new System.Windows.Forms.Timer(this.components);
            this.Timer_right = new System.Windows.Forms.Timer(this.components);
            this.Timer_left = new System.Windows.Forms.Timer(this.components);
            this.Label_Search_ip = new System.Windows.Forms.Label();
            this.Timer_tracking = new System.Windows.Forms.Timer(this.components);
            this.Timer_face = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 770);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Pb_maximize);
            this.panel1.Controls.Add(this.Pb_minimize);
            this.panel1.Controls.Add(this.Pb_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 44);
            this.panel1.TabIndex = 0;
            // 
            // Pb_maximize
            // 
            this.Pb_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_maximize.Image = ((System.Drawing.Image)(resources.GetObject("Pb_maximize.Image")));
            this.Pb_maximize.Location = new System.Drawing.Point(105, 5);
            this.Pb_maximize.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_maximize.Name = "Pb_maximize";
            this.Pb_maximize.Size = new System.Drawing.Size(36, 33);
            this.Pb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_maximize.TabIndex = 2;
            this.Pb_maximize.TabStop = false;
            this.Pb_maximize.Click += new System.EventHandler(this.Pb_maximize_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 770);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Mod);
            this.panel3.Controls.Add(this.Rb_detection);
            this.panel3.Controls.Add(this.Rb_tracking);
            this.panel3.Controls.Add(this.Rb_normal);
            this.panel3.Controls.Add(this.Btn_screen);
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
            this.panel3.Location = new System.Drawing.Point(0, 544);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 226);
            this.panel3.TabIndex = 10;
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.Location = new System.Drawing.Point(37, 119);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mod.TabIndex = 29;
            this.Btn_Mod.Text = "Comando";
            this.Btn_Mod.UseVisualStyleBackColor = true;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Rb_detection
            // 
            this.Rb_detection.AutoSize = true;
            this.Rb_detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_detection.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_detection.Location = new System.Drawing.Point(1034, 354);
            this.Rb_detection.Name = "Rb_detection";
            this.Rb_detection.Size = new System.Drawing.Size(98, 21);
            this.Rb_detection.TabIndex = 28;
            this.Rb_detection.TabStop = true;
            this.Rb_detection.Text = "Detection";
            this.Rb_detection.UseVisualStyleBackColor = true;
            this.Rb_detection.Click += new System.EventHandler(this.Rb_detection_Click);
            // 
            // Rb_tracking
            // 
            this.Rb_tracking.AutoSize = true;
            this.Rb_tracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_tracking.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_tracking.Location = new System.Drawing.Point(1034, 327);
            this.Rb_tracking.Name = "Rb_tracking";
            this.Rb_tracking.Size = new System.Drawing.Size(92, 21);
            this.Rb_tracking.TabIndex = 27;
            this.Rb_tracking.TabStop = true;
            this.Rb_tracking.Text = "Tracking";
            this.Rb_tracking.UseVisualStyleBackColor = true;
            this.Rb_tracking.Click += new System.EventHandler(this.Rb_tracking_Click);
            // 
            // Rb_normal
            // 
            this.Rb_normal.AutoSize = true;
            this.Rb_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_normal.ForeColor = System.Drawing.Color.Transparent;
            this.Rb_normal.Location = new System.Drawing.Point(1034, 300);
            this.Rb_normal.Name = "Rb_normal";
            this.Rb_normal.Size = new System.Drawing.Size(80, 21);
            this.Rb_normal.TabIndex = 26;
            this.Rb_normal.TabStop = true;
            this.Rb_normal.Text = "Normal";
            this.Rb_normal.UseVisualStyleBackColor = true;
            this.Rb_normal.Click += new System.EventHandler(this.Rb_normal_Click);
            // 
            // Btn_screen
            // 
            this.Btn_screen.Location = new System.Drawing.Point(17, 166);
            this.Btn_screen.Name = "Btn_screen";
            this.Btn_screen.Size = new System.Drawing.Size(75, 23);
            this.Btn_screen.TabIndex = 25;
            this.Btn_screen.Text = "Screen";
            this.Btn_screen.UseVisualStyleBackColor = true;
            this.Btn_screen.Click += new System.EventHandler(this.Btn_screen_1);
            // 
            // Label_ip
            // 
            this.Label_ip.AutoSize = true;
            this.Label_ip.ForeColor = System.Drawing.Color.Red;
            this.Label_ip.Location = new System.Drawing.Point(413, 62);
            this.Label_ip.Name = "Label_ip";
            this.Label_ip.Size = new System.Drawing.Size(0, 17);
            this.Label_ip.TabIndex = 22;
            // 
            // Btn_ip
            // 
            this.Btn_ip.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ip.ForeColor = System.Drawing.Color.White;
            this.Btn_ip.Location = new System.Drawing.Point(551, 99);
            this.Btn_ip.Name = "Btn_ip";
            this.Btn_ip.Size = new System.Drawing.Size(276, 43);
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
            this.label3.Location = new System.Drawing.Point(604, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inserire Ip della Cam";
            // 
            // Txt_ip
            // 
            this.Txt_ip.Location = new System.Drawing.Point(551, 59);
            this.Txt_ip.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ip.Name = "Txt_ip";
            this.Txt_ip.Size = new System.Drawing.Size(276, 22);
            this.Txt_ip.TabIndex = 15;
            // 
            // Pb_center
            // 
            this.Pb_center.Image = ((System.Drawing.Image)(resources.GetObject("Pb_center.Image")));
            this.Pb_center.Location = new System.Drawing.Point(244, 74);
            this.Pb_center.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_center.Name = "Pb_center";
            this.Pb_center.Size = new System.Drawing.Size(77, 63);
            this.Pb_center.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_center.TabIndex = 14;
            this.Pb_center.TabStop = false;
            this.Pb_center.Click += new System.EventHandler(this.Pb_center_Click);
            // 
            // Pb_left
            // 
            this.Pb_left.Image = ((System.Drawing.Image)(resources.GetObject("Pb_left.Image")));
            this.Pb_left.Location = new System.Drawing.Point(159, 74);
            this.Pb_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_left.Name = "Pb_left";
            this.Pb_left.Size = new System.Drawing.Size(77, 63);
            this.Pb_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_left.TabIndex = 13;
            this.Pb_left.TabStop = false;
            this.Pb_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_left_MouseDown);
            this.Pb_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_left_MouseUp);
            // 
            // Pb_right
            // 
            this.Pb_right.Image = ((System.Drawing.Image)(resources.GetObject("Pb_right.Image")));
            this.Pb_right.Location = new System.Drawing.Point(329, 74);
            this.Pb_right.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_right.Name = "Pb_right";
            this.Pb_right.Size = new System.Drawing.Size(77, 63);
            this.Pb_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_right.TabIndex = 12;
            this.Pb_right.TabStop = false;
            this.Pb_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_right_MouseDown);
            this.Pb_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_right_MouseUp);
            // 
            // Pb_up
            // 
            this.Pb_up.Image = ((System.Drawing.Image)(resources.GetObject("Pb_up.Image")));
            this.Pb_up.Location = new System.Drawing.Point(244, 0);
            this.Pb_up.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_up.Name = "Pb_up";
            this.Pb_up.Size = new System.Drawing.Size(77, 63);
            this.Pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_up.TabIndex = 11;
            this.Pb_up.TabStop = false;
            this.Pb_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_up_MouseDown);
            this.Pb_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_up_MouseUp);
            // 
            // Pb_down
            // 
            this.Pb_down.Image = ((System.Drawing.Image)(resources.GetObject("Pb_down.Image")));
            this.Pb_down.Location = new System.Drawing.Point(244, 145);
            this.Pb_down.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_down.Name = "Pb_down";
            this.Pb_down.Size = new System.Drawing.Size(77, 63);
            this.Pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_down.TabIndex = 10;
            this.Pb_down.TabStop = false;
            this.Pb_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_down_MouseDown);
            this.Pb_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_down_MouseUp);
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
            this.Btn_stream.Click += new System.EventHandler(this.Btn_stream_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(940, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inserire Indirizzo rete (primi 3 membri)";
            this.label2.Visible = false;
            // 
            // Btn_search
            // 
            this.Btn_search.ActiveBorderThickness = 1;
            this.Btn_search.ActiveCornerRadius = 20;
            this.Btn_search.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_search.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_search.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_search.BackColor = System.Drawing.Color.Black;
            this.Btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_search.BackgroundImage")));
            this.Btn_search.ButtonText = "Cerca Dipositivi";
            this.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_search.ForeColor = System.Drawing.Color.Green;
            this.Btn_search.IdleBorderThickness = 1;
            this.Btn_search.IdleCornerRadius = 20;
            this.Btn_search.IdleFillColor = System.Drawing.Color.Black;
            this.Btn_search.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_search.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_search.Location = new System.Drawing.Point(995, 226);
            this.Btn_search.Margin = new System.Windows.Forms.Padding(7);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(241, 54);
            this.Btn_search.TabIndex = 13;
            this.Btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // ListView_ip
            // 
            this.ListView_ip.BackColor = System.Drawing.Color.Black;
            this.ListView_ip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_ip.ForeColor = System.Drawing.Color.White;
            this.ListView_ip.HideSelection = false;
            this.ListView_ip.Location = new System.Drawing.Point(889, 404);
            this.ListView_ip.Margin = new System.Windows.Forms.Padding(4);
            this.ListView_ip.MultiSelect = false;
            this.ListView_ip.Name = "ListView_ip";
            this.ListView_ip.Size = new System.Drawing.Size(447, 394);
            this.ListView_ip.TabIndex = 14;
            this.ListView_ip.UseCompatibleStateImageBehavior = false;
            this.ListView_ip.View = System.Windows.Forms.View.Details;
            this.ListView_ip.Visible = false;
            this.ListView_ip.Click += new System.EventHandler(this.ListView_ip_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 122;
            // 
            // Txt_Search_ip
            // 
            this.Txt_Search_ip.Location = new System.Drawing.Point(946, 352);
            this.Txt_Search_ip.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Search_ip.Name = "Txt_Search_ip";
            this.Txt_Search_ip.Size = new System.Drawing.Size(240, 22);
            this.Txt_Search_ip.TabIndex = 15;
            this.Txt_Search_ip.Visible = false;
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
            this.Btn_go.Location = new System.Drawing.Point(1198, 337);
            this.Btn_go.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_go.Name = "Btn_go";
            this.Btn_go.Size = new System.Drawing.Size(123, 57);
            this.Btn_go.TabIndex = 18;
            this.Btn_go.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_go.Visible = false;
            this.Btn_go.Click += new System.EventHandler(this.Btn_go_Click);
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
            this.Label_Search_ip.Location = new System.Drawing.Point(1031, 337);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1353, 814);
            this.ControlBox = false;
            this.Controls.Add(this.Label_Search_ip);
            this.Controls.Add(this.Btn_go);
            this.Controls.Add(this.Txt_Search_ip);
            this.Controls.Add(this.ListView_ip);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_stream);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_search;
        private System.Windows.Forms.ListView ListView_ip;
        private System.Windows.Forms.TextBox Txt_Search_ip;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_go;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ip;
        private System.Windows.Forms.Timer Timer_up;
        private System.Windows.Forms.Timer Timer_down;
        private System.Windows.Forms.Timer Timer_right;
        private System.Windows.Forms.Timer Timer_left;
        private System.Windows.Forms.Button Btn_ip;
        private System.Windows.Forms.Label Label_Search_ip;
        private System.Windows.Forms.Label Label_ip;
        private System.Windows.Forms.Button Btn_screen;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.RadioButton Rb_detection;
        private System.Windows.Forms.RadioButton Rb_tracking;
        private System.Windows.Forms.RadioButton Rb_normal;
        private System.Windows.Forms.Timer Timer_tracking;
        private System.Windows.Forms.Timer Timer_face;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}


