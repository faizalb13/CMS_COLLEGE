namespace CMS_COLLEGE
{
    partial class UPDATE_PRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPDATE_PRO));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laststream = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stream = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.labellaststream = new System.Windows.Forms.Label();
            this.leavingdate = new System.Windows.Forms.Label();
            this.labelstream = new System.Windows.Forms.Label();
            this.labelcourse = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelaadhar = new System.Windows.Forms.Label();
            this.aadhar = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.fathername = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.labeladdress = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.labelfathername = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelsurname = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.browseimage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.course = new System.Windows.Forms.ComboBox();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stuID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myfirstdata1 = new CMS_COLLEGE.myfirstdata1();
            this.stu_infoTableAdapter = new CMS_COLLEGE.myfirstdata1TableAdapters.stu_infoTableAdapter();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.insert = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.cmsclgdatabase = new CMS_COLLEGE.cmsclgdatabase();
            this.courseinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_infoTableAdapter = new CMS_COLLEGE.cmsclgdatabaseTableAdapters.course_infoTableAdapter();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.jday = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label_stream = new System.Windows.Forms.Label();
            this.label_course = new System.Windows.Forms.Label();
            this.btn_stream = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_gender = new System.Windows.Forms.Button();
            this.label_gender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfirstdata1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(571, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // laststream
            // 
            this.laststream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laststream.Location = new System.Drawing.Point(206, 663);
            this.laststream.Name = "laststream";
            this.laststream.Size = new System.Drawing.Size(271, 31);
            this.laststream.TabIndex = 72;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // stream
            // 
            this.stream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stream.ForeColor = System.Drawing.Color.Gray;
            this.stream.FormattingEnabled = true;
            this.stream.Location = new System.Drawing.Point(206, 534);
            this.stream.Name = "stream";
            this.stream.Size = new System.Drawing.Size(271, 31);
            this.stream.TabIndex = 71;
            this.stream.Text = "--Select--";
            this.stream.Visible = false;
            this.stream.SelectedIndexChanged += new System.EventHandler(this.stream_SelectedIndexChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(206, 493);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(271, 31);
            this.email.TabIndex = 70;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(206, 449);
            this.phone.MaxLength = 10;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(271, 31);
            this.phone.TabIndex = 69;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // labellaststream
            // 
            this.labellaststream.AutoSize = true;
            this.labellaststream.BackColor = System.Drawing.Color.Transparent;
            this.labellaststream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellaststream.ForeColor = System.Drawing.Color.DimGray;
            this.labellaststream.Location = new System.Drawing.Point(61, 666);
            this.labellaststream.Name = "labellaststream";
            this.labellaststream.Size = new System.Drawing.Size(103, 23);
            this.labellaststream.TabIndex = 68;
            this.labellaststream.Text = "Last Stream";
            // 
            // leavingdate
            // 
            this.leavingdate.AutoSize = true;
            this.leavingdate.BackColor = System.Drawing.Color.Transparent;
            this.leavingdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavingdate.ForeColor = System.Drawing.Color.DimGray;
            this.leavingdate.Location = new System.Drawing.Point(61, 625);
            this.leavingdate.Name = "leavingdate";
            this.leavingdate.Size = new System.Drawing.Size(81, 23);
            this.leavingdate.TabIndex = 67;
            this.leavingdate.Text = "Join date";
            // 
            // labelstream
            // 
            this.labelstream.AutoSize = true;
            this.labelstream.BackColor = System.Drawing.Color.Transparent;
            this.labelstream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstream.ForeColor = System.Drawing.Color.DimGray;
            this.labelstream.Location = new System.Drawing.Point(61, 537);
            this.labelstream.Name = "labelstream";
            this.labelstream.Size = new System.Drawing.Size(67, 23);
            this.labelstream.TabIndex = 66;
            this.labelstream.Text = "Stream";
            // 
            // labelcourse
            // 
            this.labelcourse.AutoSize = true;
            this.labelcourse.BackColor = System.Drawing.Color.Transparent;
            this.labelcourse.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcourse.ForeColor = System.Drawing.Color.DimGray;
            this.labelcourse.Location = new System.Drawing.Point(60, 579);
            this.labelcourse.Name = "labelcourse";
            this.labelcourse.Size = new System.Drawing.Size(65, 23);
            this.labelcourse.TabIndex = 65;
            this.labelcourse.Text = "Course";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.DimGray;
            this.labelemail.Location = new System.Drawing.Point(61, 496);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(53, 23);
            this.labelemail.TabIndex = 64;
            this.labelemail.Text = "Email";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.BackColor = System.Drawing.Color.Transparent;
            this.labelphone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.ForeColor = System.Drawing.Color.DimGray;
            this.labelphone.Location = new System.Drawing.Point(60, 457);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(60, 23);
            this.labelphone.TabIndex = 63;
            this.labelphone.Text = "Phone";
            // 
            // labelaadhar
            // 
            this.labelaadhar.AutoSize = true;
            this.labelaadhar.BackColor = System.Drawing.Color.Transparent;
            this.labelaadhar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaadhar.ForeColor = System.Drawing.Color.DimGray;
            this.labelaadhar.Location = new System.Drawing.Point(59, 409);
            this.labelaadhar.Name = "labelaadhar";
            this.labelaadhar.Size = new System.Drawing.Size(91, 23);
            this.labelaadhar.TabIndex = 62;
            this.labelaadhar.Text = "Aadhar no";
            // 
            // aadhar
            // 
            this.aadhar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadhar.Location = new System.Drawing.Point(206, 406);
            this.aadhar.MaxLength = 12;
            this.aadhar.Name = "aadhar";
            this.aadhar.Size = new System.Drawing.Size(271, 31);
            this.aadhar.TabIndex = 61;
            this.aadhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aadhar_KeyPress);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(206, 303);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(271, 88);
            this.address.TabIndex = 60;
            // 
            // fathername
            // 
            this.fathername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathername.Location = new System.Drawing.Point(206, 181);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(271, 31);
            this.fathername.TabIndex = 59;
            this.fathername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fathername_KeyPress);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(206, 141);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(271, 31);
            this.name.TabIndex = 58;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Transparent;
            this.labeladdress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.ForeColor = System.Drawing.Color.DimGray;
            this.labeladdress.Location = new System.Drawing.Point(59, 306);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(75, 23);
            this.labeladdress.TabIndex = 57;
            this.labeladdress.Text = "Address";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.DimGray;
            this.lblgender.Location = new System.Drawing.Point(59, 266);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 23);
            this.lblgender.TabIndex = 56;
            this.lblgender.Text = "Gender";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.DimGray;
            this.dob.Location = new System.Drawing.Point(59, 225);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(46, 23);
            this.dob.TabIndex = 55;
            this.dob.Text = "DOB";
            // 
            // labelfathername
            // 
            this.labelfathername.AutoSize = true;
            this.labelfathername.BackColor = System.Drawing.Color.Transparent;
            this.labelfathername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfathername.ForeColor = System.Drawing.Color.DimGray;
            this.labelfathername.Location = new System.Drawing.Point(59, 184);
            this.labelfathername.Name = "labelfathername";
            this.labelfathername.Size = new System.Drawing.Size(109, 23);
            this.labelfathername.TabIndex = 54;
            this.labelfathername.Text = "Father name";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.DimGray;
            this.labelname.Location = new System.Drawing.Point(59, 149);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(57, 23);
            this.labelname.TabIndex = 53;
            this.labelname.Text = "Name";
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.BackColor = System.Drawing.Color.Transparent;
            this.labelsurname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsurname.ForeColor = System.Drawing.Color.DimGray;
            this.labelsurname.Location = new System.Drawing.Point(59, 109);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(80, 23);
            this.labelsurname.TabIndex = 52;
            this.labelsurname.Text = "Surname";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(206, 101);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(271, 31);
            this.surname.TabIndex = 51;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            // 
            // browseimage
            // 
            this.browseimage.BackColor = System.Drawing.Color.White;
            this.browseimage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseimage.ForeColor = System.Drawing.Color.Black;
            this.browseimage.Location = new System.Drawing.Point(568, 206);
            this.browseimage.Name = "browseimage";
            this.browseimage.Size = new System.Drawing.Size(183, 42);
            this.browseimage.TabIndex = 49;
            this.browseimage.Text = "Browse Image";
            this.browseimage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browseimage.UseVisualStyleBackColor = false;
            this.browseimage.Click += new System.EventHandler(this.browseimage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Student Update Form";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // course
            // 
            this.course.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.Gray;
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(206, 576);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(271, 31);
            this.course.TabIndex = 50;
            this.course.Text = "--Select--";
            this.course.Visible = false;
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
            this.btnviewall.Location = new System.Drawing.Point(802, 68);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(166, 73);
            this.btnviewall.TabIndex = 296;
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
            this.btnrefresh.Location = new System.Drawing.Point(969, 68);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(166, 73);
            this.btnrefresh.TabIndex = 295;
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
            this.btndelete.Location = new System.Drawing.Point(1136, 68);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(166, 73);
            this.btndelete.TabIndex = 294;
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
            this.btnupdate.Location = new System.Drawing.Point(969, 142);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(166, 73);
            this.btnupdate.TabIndex = 292;
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
            this.btnexit.Location = new System.Drawing.Point(1136, 142);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(166, 73);
            this.btnexit.TabIndex = 291;
            this.btnexit.Text = "Exit\r\n";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 299;
            this.label2.Text = "Student ID";
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuID.Location = new System.Drawing.Point(206, 60);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(271, 31);
            this.stuID.TabIndex = 298;
            this.stuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stuID_KeyPress_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(571, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 304);
            this.dataGridView1.TabIndex = 301;
            // 
            // stuinfoBindingSource
            // 
            this.stuinfoBindingSource.DataMember = "stu_info";
            this.stuinfoBindingSource.DataSource = this.myfirstdata1;
            // 
            // myfirstdata1
            // 
            this.myfirstdata1.DataSetName = "myfirstdata1";
            this.myfirstdata1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stu_infoTableAdapter
            // 
            this.stu_infoTableAdapter.ClearBeforeFill = true;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Turquoise;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(46, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(479, 686);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1370, 749);
            this.shapeContainer1.TabIndex = 302;
            this.shapeContainer1.TabStop = false;
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
            this.insert.Location = new System.Drawing.Point(802, 142);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(166, 73);
            this.insert.TabIndex = 447;
            this.insert.Text = " Insert";
            this.insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Gray;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender.Location = new System.Drawing.Point(206, 263);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(271, 31);
            this.gender.TabIndex = 448;
            this.gender.Text = "male/female";
            this.gender.Visible = false;
            // 
            // cmsclgdatabase
            // 
            this.cmsclgdatabase.DataSetName = "cmsclgdatabase";
            this.cmsclgdatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseinfoBindingSource
            // 
            this.courseinfoBindingSource.DataMember = "course_info";
            this.courseinfoBindingSource.DataSource = this.cmsclgdatabase;
            // 
            // course_infoTableAdapter
            // 
            this.course_infoTableAdapter.ClearBeforeFill = true;
            // 
            // day
            // 
            this.day.CustomFormat = "dd-MM-yyyy";
            this.day.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.day.Location = new System.Drawing.Point(206, 220);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(271, 31);
            this.day.TabIndex = 449;
            // 
            // jday
            // 
            this.jday.CustomFormat = "dd-MM-yyyy";
            this.jday.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.jday.Location = new System.Drawing.Point(206, 619);
            this.jday.Name = "jday";
            this.jday.Size = new System.Drawing.Size(271, 31);
            this.jday.TabIndex = 450;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(802, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 35);
            this.button1.TabIndex = 451;
            this.button1.Text = "Pay Fee Here";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_stream
            // 
            this.label_stream.AutoSize = true;
            this.label_stream.BackColor = System.Drawing.Color.Transparent;
            this.label_stream.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stream.ForeColor = System.Drawing.Color.DimGray;
            this.label_stream.Location = new System.Drawing.Point(202, 537);
            this.label_stream.Name = "label_stream";
            this.label_stream.Size = new System.Drawing.Size(67, 23);
            this.label_stream.TabIndex = 452;
            this.label_stream.Text = "Stream";
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.BackColor = System.Drawing.Color.Transparent;
            this.label_course.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course.ForeColor = System.Drawing.Color.DimGray;
            this.label_course.Location = new System.Drawing.Point(202, 579);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(65, 23);
            this.label_course.TabIndex = 453;
            this.label_course.Text = "Course";
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
            this.btn_stream.Location = new System.Drawing.Point(333, 534);
            this.btn_stream.Name = "btn_stream";
            this.btn_stream.Size = new System.Drawing.Size(144, 31);
            this.btn_stream.TabIndex = 454;
            this.btn_stream.Text = "select stream";
            this.btn_stream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stream.UseVisualStyleBackColor = false;
            this.btn_stream.Click += new System.EventHandler(this.btn_stream_Click);
            // 
            // btn_course
            // 
            this.btn_course.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_course.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_course.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_course.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_course.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course.ForeColor = System.Drawing.Color.Black;
            this.btn_course.Location = new System.Drawing.Point(333, 576);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(144, 31);
            this.btn_course.TabIndex = 455;
            this.btn_course.Text = "select course";
            this.btn_course.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_course.UseVisualStyleBackColor = false;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_gender
            // 
            this.btn_gender.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_gender.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_gender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btn_gender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gender.ForeColor = System.Drawing.Color.Black;
            this.btn_gender.Location = new System.Drawing.Point(333, 262);
            this.btn_gender.Name = "btn_gender";
            this.btn_gender.Size = new System.Drawing.Size(144, 31);
            this.btn_gender.TabIndex = 457;
            this.btn_gender.Text = "select gender";
            this.btn_gender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gender.UseVisualStyleBackColor = false;
            this.btn_gender.Click += new System.EventHandler(this.btn_gender_Click);
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.Transparent;
            this.label_gender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.DimGray;
            this.label_gender.Location = new System.Drawing.Point(202, 266);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(112, 23);
            this.label_gender.TabIndex = 456;
            this.label_gender.Text = "male/female";
            // 
            // UPDATE_PRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_stream);
            this.Controls.Add(this.label_course);
            this.Controls.Add(this.label_stream);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jday);
            this.Controls.Add(this.day);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.laststream);
            this.Controls.Add(this.stream);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.labellaststream);
            this.Controls.Add(this.leavingdate);
            this.Controls.Add(this.labelstream);
            this.Controls.Add(this.labelcourse);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelaadhar);
            this.Controls.Add(this.aadhar);
            this.Controls.Add(this.address);
            this.Controls.Add(this.fathername);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.labelfathername);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelsurname);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.browseimage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPDATE_PRO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UPDATE_PRO";
            this.Load += new System.EventHandler(this.UPDATE_PRO_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfirstdata1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox laststream;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox stream;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label labellaststream;
        private System.Windows.Forms.Label leavingdate;
        private System.Windows.Forms.Label labelstream;
        private System.Windows.Forms.Label labelcourse;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelaadhar;
        private System.Windows.Forms.TextBox aadhar;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox fathername;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label labelfathername;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button browseimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuID;
        private myfirstdata1 myfirstdata1;
        private System.Windows.Forms.BindingSource stuinfoBindingSource;
        private myfirstdata1TableAdapters.stu_infoTableAdapter stu_infoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox gender;
        private cmsclgdatabase cmsclgdatabase;
        private System.Windows.Forms.BindingSource courseinfoBindingSource;
        private cmsclgdatabaseTableAdapters.course_infoTableAdapter course_infoTableAdapter;
        private System.Windows.Forms.DateTimePicker jday;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_stream;
        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Label label_stream;
        private System.Windows.Forms.Button btn_gender;
        private System.Windows.Forms.Label label_gender;
    }
}