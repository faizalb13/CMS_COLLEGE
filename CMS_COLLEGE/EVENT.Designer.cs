namespace CMS_COLLEGE
{
    partial class EVENT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EVENT));
            this.eventname = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.TextBox();
            this.lblplace = new System.Windows.Forms.Label();
            this.stream = new System.Windows.Forms.ComboBox();
            this.lblstream = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.handler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.speaker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseimage = new System.Windows.Forms.Button();
            this.stuID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.daynm = new System.Windows.Forms.ComboBox();
            this.btn_stream = new System.Windows.Forms.Button();
            this.label_stream = new System.Windows.Forms.Label();
            this.btndaynm = new System.Windows.Forms.Button();
            this.lbldaynm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventname
            // 
            this.eventname.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventname.Location = new System.Drawing.Point(183, 139);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(467, 33);
            this.eventname.TabIndex = 101;
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.DimGray;
            this.dob.Location = new System.Drawing.Point(99, 191);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(53, 26);
            this.dob.TabIndex = 100;
            this.dob.Text = "Date";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.DimGray;
            this.name.Location = new System.Drawing.Point(35, 142);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(117, 26);
            this.name.TabIndex = 99;
            this.name.Text = "Event Name";
            // 
            // place
            // 
            this.place.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place.Location = new System.Drawing.Point(183, 292);
            this.place.Multiline = true;
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(467, 68);
            this.place.TabIndex = 117;
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.BackColor = System.Drawing.Color.Transparent;
            this.lblplace.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplace.ForeColor = System.Drawing.Color.DimGray;
            this.lblplace.Location = new System.Drawing.Point(94, 291);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(58, 26);
            this.lblplace.TabIndex = 116;
            this.lblplace.Text = "Place";
            // 
            // stream
            // 
            this.stream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stream.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stream.FormattingEnabled = true;
            this.stream.Location = new System.Drawing.Point(183, 366);
            this.stream.Name = "stream";
            this.stream.Size = new System.Drawing.Size(467, 34);
            this.stream.TabIndex = 119;
            this.stream.Text = "Select Stream";
            this.stream.Visible = false;
            // 
            // lblstream
            // 
            this.lblstream.AutoSize = true;
            this.lblstream.BackColor = System.Drawing.Color.Transparent;
            this.lblstream.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstream.ForeColor = System.Drawing.Color.DimGray;
            this.lblstream.Location = new System.Drawing.Point(78, 372);
            this.lblstream.Name = "lblstream";
            this.lblstream.Size = new System.Drawing.Size(74, 26);
            this.lblstream.TabIndex = 118;
            this.lblstream.Text = "Stream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(97, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 120;
            this.label1.Text = "Time";
            // 
            // handler
            // 
            this.handler.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handler.Location = new System.Drawing.Point(183, 410);
            this.handler.Name = "handler";
            this.handler.Size = new System.Drawing.Size(467, 33);
            this.handler.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(19, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 126;
            this.label4.Text = "Event Handler";
            // 
            // speaker
            // 
            this.speaker.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speaker.Location = new System.Drawing.Point(183, 450);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(467, 33);
            this.speaker.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(71, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 128;
            this.label5.Text = "Speaker";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Location = new System.Drawing.Point(35, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 29);
            this.label12.TabIndex = 133;
            this.label12.Text = "Event Information";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.White;
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert.FlatAppearance.BorderSize = 2;
            this.insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.Black;
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.Location = new System.Drawing.Point(678, 311);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(166, 73);
            this.insert.TabIndex = 416;
            this.insert.Text = " Insert";
            this.insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // btnviewall
            // 
            this.btnviewall.BackColor = System.Drawing.Color.White;
            this.btnviewall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnviewall.FlatAppearance.BorderSize = 2;
            this.btnviewall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnviewall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnviewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewall.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewall.ForeColor = System.Drawing.Color.Black;
            this.btnviewall.Image = ((System.Drawing.Image)(resources.GetObject("btnviewall.Image")));
            this.btnviewall.Location = new System.Drawing.Point(678, 385);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(166, 73);
            this.btnviewall.TabIndex = 415;
            this.btnviewall.Text = "View";
            this.btnviewall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnviewall.UseVisualStyleBackColor = false;
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.White;
            this.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrefresh.FlatAppearance.BorderSize = 2;
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(678, 458);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(166, 73);
            this.btnrefresh.TabIndex = 414;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(845, 311);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(166, 73);
            this.btndelete.TabIndex = 413;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.Location = new System.Drawing.Point(845, 385);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(166, 73);
            this.btnupdate.TabIndex = 412;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexit.FlatAppearance.BorderSize = 2;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(845, 459);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(166, 73);
            this.btnexit.TabIndex = 411;
            this.btnexit.Text = "Exit\r\n";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(678, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 417;
            this.pictureBox1.TabStop = false;
            // 
            // browseimage
            // 
            this.browseimage.BackColor = System.Drawing.Color.White;
            this.browseimage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseimage.ForeColor = System.Drawing.Color.Black;
            this.browseimage.Location = new System.Drawing.Point(678, 261);
            this.browseimage.Name = "browseimage";
            this.browseimage.Size = new System.Drawing.Size(155, 42);
            this.browseimage.TabIndex = 418;
            this.browseimage.Text = "Browse Image";
            this.browseimage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browseimage.UseVisualStyleBackColor = false;
            this.browseimage.Click += new System.EventHandler(this.browseimage_Click);
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuID.Location = new System.Drawing.Point(183, 102);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(467, 31);
            this.stuID.TabIndex = 419;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 420;
            this.label2.Text = "Event ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 562);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(935, 203);
            this.dataGridView1.TabIndex = 421;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // day
            // 
            this.day.CustomFormat = "dd-MM-yyyy";
            this.day.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.day.Location = new System.Drawing.Point(183, 187);
            this.day.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.day.MinDate = new System.DateTime(2020, 10, 18, 0, 0, 0, 0);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(198, 31);
            this.day.TabIndex = 450;
            this.day.Value = new System.DateTime(2020, 10, 18, 0, 0, 0, 0);
            // 
            // time
            // 
            this.time.CustomFormat = "HH:mm";
            this.time.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(183, 238);
            this.time.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.time.MinDate = new System.DateTime(2020, 10, 18, 0, 0, 0, 0);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(178, 31);
            this.time.TabIndex = 451;
            this.time.Value = new System.DateTime(2020, 10, 22, 12, 0, 0, 0);
            // 
            // daynm
            // 
            this.daynm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daynm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daynm.FormattingEnabled = true;
            this.daynm.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thusday",
            "Friday",
            "Saturday"});
            this.daynm.Location = new System.Drawing.Point(403, 187);
            this.daynm.Name = "daynm";
            this.daynm.Size = new System.Drawing.Size(247, 34);
            this.daynm.TabIndex = 452;
            this.daynm.Text = "Select Day";
            this.daynm.Visible = false;
            // 
            // btn_stream
            // 
            this.btn_stream.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_stream.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_stream.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_stream.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_stream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stream.ForeColor = System.Drawing.Color.Black;
            this.btn_stream.Location = new System.Drawing.Point(314, 370);
            this.btn_stream.Name = "btn_stream";
            this.btn_stream.Size = new System.Drawing.Size(184, 31);
            this.btn_stream.TabIndex = 456;
            this.btn_stream.Text = "select stream";
            this.btn_stream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stream.UseVisualStyleBackColor = false;
            this.btn_stream.Click += new System.EventHandler(this.btn_stream_Click);
            // 
            // label_stream
            // 
            this.label_stream.AutoSize = true;
            this.label_stream.BackColor = System.Drawing.Color.Transparent;
            this.label_stream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stream.ForeColor = System.Drawing.Color.DimGray;
            this.label_stream.Location = new System.Drawing.Point(183, 373);
            this.label_stream.Name = "label_stream";
            this.label_stream.Size = new System.Drawing.Size(67, 23);
            this.label_stream.TabIndex = 455;
            this.label_stream.Text = "Stream";
            // 
            // btndaynm
            // 
            this.btndaynm.BackColor = System.Drawing.Color.Gainsboro;
            this.btndaynm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btndaynm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btndaynm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndaynm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndaynm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndaynm.ForeColor = System.Drawing.Color.Black;
            this.btndaynm.Location = new System.Drawing.Point(499, 188);
            this.btndaynm.Name = "btndaynm";
            this.btndaynm.Size = new System.Drawing.Size(159, 31);
            this.btndaynm.TabIndex = 458;
            this.btndaynm.Text = "Select Day";
            this.btndaynm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndaynm.UseVisualStyleBackColor = false;
            this.btndaynm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldaynm
            // 
            this.lbldaynm.AutoSize = true;
            this.lbldaynm.BackColor = System.Drawing.Color.Transparent;
            this.lbldaynm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaynm.ForeColor = System.Drawing.Color.DimGray;
            this.lbldaynm.Location = new System.Drawing.Point(397, 192);
            this.lbldaynm.Name = "lbldaynm";
            this.lbldaynm.Size = new System.Drawing.Size(40, 23);
            this.lbldaynm.TabIndex = 457;
            this.lbldaynm.Text = "Day";
            // 
            // EVENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 777);
            this.Controls.Add(this.btndaynm);
            this.Controls.Add(this.lbldaynm);
            this.Controls.Add(this.btn_stream);
            this.Controls.Add(this.label_stream);
            this.Controls.Add(this.daynm);
            this.Controls.Add(this.time);
            this.Controls.Add(this.day);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.browseimage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.speaker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.handler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stream);
            this.Controls.Add(this.lblstream);
            this.Controls.Add(this.place);
            this.Controls.Add(this.lblplace);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EVENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVENT";
            this.Load += new System.EventHandler(this.EVENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventname;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.ComboBox stream;
        private System.Windows.Forms.Label lblstream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox handler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox speaker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseimage;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ComboBox daynm;
        private System.Windows.Forms.Button btn_stream;
        private System.Windows.Forms.Label label_stream;
        private System.Windows.Forms.Button btndaynm;
        private System.Windows.Forms.Label lbldaynm;
    }
}