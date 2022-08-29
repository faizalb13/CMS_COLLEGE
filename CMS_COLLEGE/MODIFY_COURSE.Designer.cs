namespace CMS_COLLEGE
{
    partial class MODIFY_COURSE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MODIFY_COURSE));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.courseinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmsclgDataSet2 = new CMS_COLLEGE.cmsclgDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalyear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subjects = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newcourse = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.courseID = new System.Windows.Forms.TextBox();
            this.CourseCode = new System.Windows.Forms.Label();
            this.course_infoTableAdapter1 = new CMS_COLLEGE.cmsclgDataSet2TableAdapters.course_infoTableAdapter();
            this.cmsclgdatabase = new CMS_COLLEGE.cmsclgdatabase();
            this.cmsclgdatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.newstream = new System.Windows.Forms.ComboBox();
            this.btn_stream = new System.Windows.Forms.Button();
            this.label_stream = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.ComboBox();
            this.btn_time = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // courseinfoBindingSource1
            // 
            this.courseinfoBindingSource1.DataMember = "course_info";
            this.courseinfoBindingSource1.DataSource = this.cmsclgDataSet2;
            // 
            // cmsclgDataSet2
            // 
            this.cmsclgDataSet2.DataSetName = "cmsclgDataSet2";
            this.cmsclgDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 361;
            this.label1.Text = "Course Modify Form";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(471, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 406;
            this.label7.Text = "/ year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(193, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 405;
            this.label6.Text = "RS.";
            // 
            // fee
            // 
            this.fee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fee.Location = new System.Drawing.Point(243, 367);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(222, 30);
            this.fee.TabIndex = 404;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(33, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 403;
            this.label5.Text = "Course Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(33, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 400;
            this.label4.Text = "Lecture Time";
            // 
            // totalyear
            // 
            this.totalyear.DropDownHeight = 100;
            this.totalyear.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalyear.FormattingEnabled = true;
            this.totalyear.IntegralHeight = false;
            this.totalyear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.totalyear.Location = new System.Drawing.Point(198, 209);
            this.totalyear.Name = "totalyear";
            this.totalyear.Size = new System.Drawing.Size(241, 31);
            this.totalyear.TabIndex = 399;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(33, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 398;
            this.label3.Text = "Subject Name";
            // 
            // subjects
            // 
            this.subjects.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjects.Location = new System.Drawing.Point(197, 248);
            this.subjects.Multiline = true;
            this.subjects.Name = "subjects";
            this.subjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subjects.Size = new System.Drawing.Size(545, 74);
            this.subjects.TabIndex = 397;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(33, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 396;
            this.label2.Text = "Total Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(33, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 394;
            this.label8.Text = "Stream Name";
            // 
            // newcourse
            // 
            this.newcourse.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcourse.Location = new System.Drawing.Point(198, 162);
            this.newcourse.Multiline = true;
            this.newcourse.Name = "newcourse";
            this.newcourse.Size = new System.Drawing.Size(544, 30);
            this.newcourse.TabIndex = 393;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.DimGray;
            this.name.Location = new System.Drawing.Point(33, 159);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 23);
            this.name.TabIndex = 392;
            this.name.Text = "New Course Name";
            // 
            // courseID
            // 
            this.courseID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseID.Location = new System.Drawing.Point(197, 78);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(545, 30);
            this.courseID.TabIndex = 408;
            // 
            // CourseCode
            // 
            this.CourseCode.AutoSize = true;
            this.CourseCode.BackColor = System.Drawing.Color.Transparent;
            this.CourseCode.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseCode.ForeColor = System.Drawing.Color.DimGray;
            this.CourseCode.Location = new System.Drawing.Point(32, 81);
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Size = new System.Drawing.Size(86, 23);
            this.CourseCode.TabIndex = 407;
            this.CourseCode.Text = "Course ID";
            // 
            // course_infoTableAdapter1
            // 
            this.course_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // cmsclgdatabase
            // 
            this.cmsclgdatabase.DataSetName = "cmsclgdatabase";
            this.cmsclgdatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmsclgdatabaseBindingSource
            // 
            this.cmsclgdatabaseBindingSource.DataSource = this.cmsclgdatabase;
            this.cmsclgdatabaseBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 148);
            this.dataGridView1.TabIndex = 409;
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
            this.insert.Location = new System.Drawing.Point(773, 88);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(166, 73);
            this.insert.TabIndex = 410;
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
            this.btnviewall.Location = new System.Drawing.Point(773, 162);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(166, 73);
            this.btnviewall.TabIndex = 390;
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
            this.btnrefresh.Location = new System.Drawing.Point(773, 235);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(166, 73);
            this.btnrefresh.TabIndex = 389;
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
            this.btndelete.Location = new System.Drawing.Point(940, 88);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(166, 73);
            this.btndelete.TabIndex = 388;
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
            this.btnupdate.Location = new System.Drawing.Point(940, 162);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(166, 73);
            this.btnupdate.TabIndex = 386;
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
            this.btnexit.Location = new System.Drawing.Point(940, 236);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(166, 73);
            this.btnexit.TabIndex = 385;
            this.btnexit.Text = "Exit\r\n";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // newstream
            // 
            this.newstream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newstream.ForeColor = System.Drawing.Color.Gray;
            this.newstream.FormattingEnabled = true;
            this.newstream.Location = new System.Drawing.Point(198, 118);
            this.newstream.Name = "newstream";
            this.newstream.Size = new System.Drawing.Size(493, 31);
            this.newstream.TabIndex = 411;
            this.newstream.Text = "--Select--";
            this.newstream.Visible = false;
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
            this.btn_stream.Location = new System.Drawing.Point(330, 118);
            this.btn_stream.Name = "btn_stream";
            this.btn_stream.Size = new System.Drawing.Size(270, 31);
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
            this.label_stream.Location = new System.Drawing.Point(199, 121);
            this.label_stream.Name = "label_stream";
            this.label_stream.Size = new System.Drawing.Size(67, 23);
            this.label_stream.TabIndex = 455;
            this.label_stream.Text = "Stream";
            // 
            // time
            // 
            this.time.DropDownHeight = 100;
            this.time.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.FormattingEnabled = true;
            this.time.IntegralHeight = false;
            this.time.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.time.Location = new System.Drawing.Point(197, 328);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(241, 31);
            this.time.TabIndex = 457;
            this.time.Visible = false;
            // 
            // btn_time
            // 
            this.btn_time.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_time.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_time.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_time.ForeColor = System.Drawing.Color.Black;
            this.btn_time.Location = new System.Drawing.Point(330, 329);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(226, 31);
            this.btn_time.TabIndex = 459;
            this.btn_time.Text = "select time";
            this.btn_time.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_time.UseVisualStyleBackColor = false;
            this.btn_time.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.DimGray;
            this.label_time.Location = new System.Drawing.Point(199, 332);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(49, 23);
            this.label_time.TabIndex = 458;
            this.label_time.Text = "Time";
            // 
            // MODIFY_COURSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 614);
            this.Controls.Add(this.btn_time);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btn_stream);
            this.Controls.Add(this.label_stream);
            this.Controls.Add(this.newstream);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.CourseCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newcourse);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MODIFY_COURSE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFY_COURSE";
            this.Load += new System.EventHandler(this.MODIFY_COURSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox totalyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newcourse;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox courseID;
        private System.Windows.Forms.Label CourseCode;
        private cmsclgDataSet2 cmsclgDataSet2;
        private System.Windows.Forms.BindingSource courseinfoBindingSource1;
        private cmsclgDataSet2TableAdapters.course_infoTableAdapter course_infoTableAdapter1;
        private System.Windows.Forms.BindingSource cmsclgdatabaseBindingSource;
        private cmsclgdatabase cmsclgdatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox newstream;
        private System.Windows.Forms.Button btn_stream;
        private System.Windows.Forms.Label label_stream;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ComboBox time;

    }
}