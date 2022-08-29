namespace CMS_COLLEGE
{
    partial class NEW_STU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEW_STU));
            this.label1 = new System.Windows.Forms.Label();
            this.browseimage = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.ComboBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.fathername = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.aadhar = new System.Windows.Forms.TextBox();
            this.labelaadhar = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelcourse = new System.Windows.Forms.Label();
            this.labelstream = new System.Windows.Forms.Label();
            this.leavingdate = new System.Windows.Forms.Label();
            this.labellaststream = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.stream = new System.Windows.Forms.ComboBox();
            this.laststream = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnview = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.jday = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totfee = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(140, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Form Information";
            // 
            // browseimage
            // 
            this.browseimage.BackColor = System.Drawing.Color.White;
            this.browseimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseimage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.browseimage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.browseimage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.browseimage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseimage.ForeColor = System.Drawing.Color.Black;
            this.browseimage.Location = new System.Drawing.Point(841, 267);
            this.browseimage.Name = "browseimage";
            this.browseimage.Size = new System.Drawing.Size(171, 36);
            this.browseimage.TabIndex = 1;
            this.browseimage.Text = "Browse Image";
            this.browseimage.UseVisualStyleBackColor = false;
            this.browseimage.Click += new System.EventHandler(this.browseimage_Click);
            // 
            // course
            // 
            this.course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.Gray;
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(283, 511);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(482, 34);
            this.course.TabIndex = 2;
            this.course.Text = "Select Course";
            this.course.SelectedIndexChanged += new System.EventHandler(this.course_SelectedIndexChanged);
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(283, 91);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(238, 29);
            this.surname.TabIndex = 3;
            this.surname.Text = "surname";
            this.surname.Enter += new System.EventHandler(this.surname_Enter);
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textsurname_KeyPress);
            this.surname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.surname_KeyUp);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.DimGray;
            this.labelname.Location = new System.Drawing.Point(148, 94);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(64, 26);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "Name";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.DimGray;
            this.dob.Location = new System.Drawing.Point(148, 137);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(51, 26);
            this.dob.TabIndex = 7;
            this.dob.Text = "DOB";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.DimGray;
            this.lblgender.Location = new System.Drawing.Point(148, 183);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(76, 26);
            this.lblgender.TabIndex = 8;
            this.lblgender.Text = "Gender";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Transparent;
            this.labeladdress.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.ForeColor = System.Drawing.Color.DimGray;
            this.labeladdress.Location = new System.Drawing.Point(148, 222);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(81, 26);
            this.labeladdress.TabIndex = 9;
            this.labeladdress.Text = "Address";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(527, 91);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 29);
            this.name.TabIndex = 10;
            this.name.Text = "name";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textname_KeyPress);
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_KeyUp);
            // 
            // fathername
            // 
            this.fathername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathername.Location = new System.Drawing.Point(771, 91);
            this.fathername.Multiline = true;
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(238, 30);
            this.fathername.TabIndex = 11;
            this.fathername.Text = "father name";
            this.fathername.Enter += new System.EventHandler(this.fathername_Enter);
            this.fathername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textfather_KeyPress);
            this.fathername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fathername_KeyUp);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(283, 220);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.address.Size = new System.Drawing.Size(482, 83);
            this.address.TabIndex = 12;
            // 
            // aadhar
            // 
            this.aadhar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadhar.Location = new System.Drawing.Point(283, 317);
            this.aadhar.MaxLength = 12;
            this.aadhar.Multiline = true;
            this.aadhar.Name = "aadhar";
            this.aadhar.Size = new System.Drawing.Size(482, 37);
            this.aadhar.TabIndex = 13;
            this.aadhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textaadhar_KeyPress);
            this.aadhar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.aadhar_KeyUp);
            // 
            // labelaadhar
            // 
            this.labelaadhar.AutoSize = true;
            this.labelaadhar.BackColor = System.Drawing.Color.Transparent;
            this.labelaadhar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaadhar.ForeColor = System.Drawing.Color.DimGray;
            this.labelaadhar.Location = new System.Drawing.Point(148, 320);
            this.labelaadhar.Name = "labelaadhar";
            this.labelaadhar.Size = new System.Drawing.Size(101, 26);
            this.labelaadhar.TabIndex = 14;
            this.labelaadhar.Text = "Aadhar no";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.BackColor = System.Drawing.Color.Transparent;
            this.labelphone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.ForeColor = System.Drawing.Color.DimGray;
            this.labelphone.Location = new System.Drawing.Point(151, 374);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(67, 26);
            this.labelphone.TabIndex = 15;
            this.labelphone.Text = "Phone";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.DimGray;
            this.labelemail.Location = new System.Drawing.Point(151, 424);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(59, 26);
            this.labelemail.TabIndex = 16;
            this.labelemail.Text = "Email";
            // 
            // labelcourse
            // 
            this.labelcourse.AutoSize = true;
            this.labelcourse.BackColor = System.Drawing.Color.Transparent;
            this.labelcourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcourse.ForeColor = System.Drawing.Color.DimGray;
            this.labelcourse.Location = new System.Drawing.Point(151, 514);
            this.labelcourse.Name = "labelcourse";
            this.labelcourse.Size = new System.Drawing.Size(71, 26);
            this.labelcourse.TabIndex = 17;
            this.labelcourse.Text = "Course";
            // 
            // labelstream
            // 
            this.labelstream.AutoSize = true;
            this.labelstream.BackColor = System.Drawing.Color.Transparent;
            this.labelstream.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstream.ForeColor = System.Drawing.Color.DimGray;
            this.labelstream.Location = new System.Drawing.Point(148, 467);
            this.labelstream.Name = "labelstream";
            this.labelstream.Size = new System.Drawing.Size(74, 26);
            this.labelstream.TabIndex = 18;
            this.labelstream.Text = "Stream";
            // 
            // leavingdate
            // 
            this.leavingdate.AutoSize = true;
            this.leavingdate.BackColor = System.Drawing.Color.Transparent;
            this.leavingdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavingdate.ForeColor = System.Drawing.Color.DimGray;
            this.leavingdate.Location = new System.Drawing.Point(148, 564);
            this.leavingdate.Name = "leavingdate";
            this.leavingdate.Size = new System.Drawing.Size(90, 26);
            this.leavingdate.TabIndex = 19;
            this.leavingdate.Text = "Join date";
            // 
            // labellaststream
            // 
            this.labellaststream.AutoSize = true;
            this.labellaststream.BackColor = System.Drawing.Color.Transparent;
            this.labellaststream.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellaststream.ForeColor = System.Drawing.Color.DimGray;
            this.labellaststream.Location = new System.Drawing.Point(148, 615);
            this.labellaststream.Name = "labellaststream";
            this.labellaststream.Size = new System.Drawing.Size(113, 26);
            this.labellaststream.TabIndex = 20;
            this.labellaststream.Text = "Last Stream";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(283, 365);
            this.phone.MaxLength = 10;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(482, 35);
            this.phone.TabIndex = 23;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textphone_KeyPress);
            this.phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phone_KeyUp);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(283, 413);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(482, 37);
            this.email.TabIndex = 24;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // stream
            // 
            this.stream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stream.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stream.ForeColor = System.Drawing.Color.Gray;
            this.stream.FormattingEnabled = true;
            this.stream.Location = new System.Drawing.Point(283, 464);
            this.stream.Name = "stream";
            this.stream.Size = new System.Drawing.Size(482, 34);
            this.stream.TabIndex = 25;
            this.stream.Text = "Select Stream";
            this.stream.SelectedIndexChanged += new System.EventHandler(this.stream_SelectedIndexChanged);
            // 
            // laststream
            // 
            this.laststream.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laststream.Location = new System.Drawing.Point(283, 612);
            this.laststream.Name = "laststream";
            this.laststream.Size = new System.Drawing.Size(482, 33);
            this.laststream.TabIndex = 26;
            this.laststream.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textlaststream_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(841, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.White;
            this.btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnview.FlatAppearance.BorderSize = 0;
            this.btnview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Black;
            this.btnview.Image = ((System.Drawing.Image)(resources.GetObject("btnview.Image")));
            this.btnview.Location = new System.Drawing.Point(865, 523);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(144, 64);
            this.btnview.TabIndex = 44;
            this.btnview.Text = "View";
            this.btnview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Image = ((System.Drawing.Image)(resources.GetObject("submit.Image")));
            this.submit.Location = new System.Drawing.Point(865, 453);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(144, 64);
            this.submit.TabIndex = 45;
            this.submit.Text = "submit";
            this.submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(865, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 64);
            this.button3.TabIndex = 46;
            this.button3.Text = "Exit";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // day
            // 
            this.day.CustomFormat = "dd-MM-yyyy";
            this.day.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.day.Location = new System.Drawing.Point(283, 137);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(363, 33);
            this.day.TabIndex = 48;
            // 
            // jday
            // 
            this.jday.CustomFormat = "dd-MM-yyyy";
            this.jday.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.jday.Location = new System.Drawing.Point(283, 559);
            this.jday.Name = "jday";
            this.jday.Size = new System.Drawing.Size(363, 33);
            this.jday.TabIndex = 49;
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
            this.gender.Location = new System.Drawing.Point(283, 181);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(271, 31);
            this.gender.TabIndex = 449;
            this.gender.Text = "male/female";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(151, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 452;
            this.label2.Text = "Total Fee";
            // 
            // totfee
            // 
            this.totfee.AutoSize = true;
            this.totfee.BackColor = System.Drawing.Color.Transparent;
            this.totfee.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totfee.ForeColor = System.Drawing.Color.DimGray;
            this.totfee.Location = new System.Drawing.Point(315, 666);
            this.totfee.Name = "totfee";
            this.totfee.Size = new System.Drawing.Size(23, 26);
            this.totfee.TabIndex = 453;
            this.totfee.Text = "0";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Turquoise;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(118, 45);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(928, 665);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1233, 788);
            this.shapeContainer1.TabIndex = 454;
            this.shapeContainer1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(278, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 455;
            this.label3.Text = "Rs.";
            // 
            // NEW_STU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totfee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.jday);
            this.Controls.Add(this.day);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.btnview);
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
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.course);
            this.Controls.Add(this.browseimage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NEW_STU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW_STU";
            this.Load += new System.EventHandler(this.NEW_STU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseimage;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox fathername;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox aadhar;
        private System.Windows.Forms.Label labelaadhar;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelcourse;
        private System.Windows.Forms.Label labelstream;
        private System.Windows.Forms.Label leavingdate;
        private System.Windows.Forms.Label labellaststream;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox stream;
        private System.Windows.Forms.TextBox laststream;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.DateTimePicker jday;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label totfee;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label3;
    }
}