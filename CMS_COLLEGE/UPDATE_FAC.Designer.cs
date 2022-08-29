namespace CMS_COLLEGE
{
    partial class UPDATE_FAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPDATE_FAC));
            this.stuID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsclgdatabase = new CMS_COLLEGE.cmsclgdatabase();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.work2 = new System.Windows.Forms.TextBox();
            this.work1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.skill = new System.Windows.Forms.TextBox();
            this.lastplace = new System.Windows.Forms.TextBox();
            this.lastwork = new System.Windows.Forms.TextBox();
            this.lbllastcompany = new System.Windows.Forms.Label();
            this.lbllastwork = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.fac_infoTableAdapter = new CMS_COLLEGE.cmsclgdatabaseTableAdapters.fac_infoTableAdapter();
            this.gender = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseimage = new System.Windows.Forms.Button();
            this.btn_gender = new System.Windows.Forms.Button();
            this.label_gender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuID.Location = new System.Drawing.Point(190, 42);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(271, 31);
            this.stuID.TabIndex = 341;
            this.stuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stuID_KeyPress);
            this.stuID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stuID_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(513, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(849, 372);
            this.dataGridView1.TabIndex = 340;
            // 
            // facinfoBindingSource
            // 
            this.facinfoBindingSource.DataMember = "fac_info";
            this.facinfoBindingSource.DataSource = this.cmsclgdatabase;
            // 
            // cmsclgdatabase
            // 
            this.cmsclgdatabase.DataSetName = "cmsclgdatabase";
            this.cmsclgdatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 342;
            this.label2.Text = "Faculty ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(190, 476);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(271, 31);
            this.email.TabIndex = 322;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(190, 431);
            this.phone.MaxLength = 10;
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phone.Size = new System.Drawing.Size(271, 31);
            this.phone.TabIndex = 321;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            this.phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phone_KeyUp);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.DimGray;
            this.labelemail.Location = new System.Drawing.Point(43, 484);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(53, 23);
            this.labelemail.TabIndex = 316;
            this.labelemail.Text = "Email";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.BackColor = System.Drawing.Color.Transparent;
            this.labelphone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.ForeColor = System.Drawing.Color.DimGray;
            this.labelphone.Location = new System.Drawing.Point(44, 439);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(60, 23);
            this.labelphone.TabIndex = 315;
            this.labelphone.Text = "Phone";
            // 
            // labelaadhar
            // 
            this.labelaadhar.AutoSize = true;
            this.labelaadhar.BackColor = System.Drawing.Color.Transparent;
            this.labelaadhar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaadhar.ForeColor = System.Drawing.Color.DimGray;
            this.labelaadhar.Location = new System.Drawing.Point(43, 391);
            this.labelaadhar.Name = "labelaadhar";
            this.labelaadhar.Size = new System.Drawing.Size(91, 23);
            this.labelaadhar.TabIndex = 314;
            this.labelaadhar.Text = "Aadhar no";
            // 
            // aadhar
            // 
            this.aadhar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadhar.Location = new System.Drawing.Point(190, 388);
            this.aadhar.MaxLength = 12;
            this.aadhar.Name = "aadhar";
            this.aadhar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aadhar.Size = new System.Drawing.Size(271, 31);
            this.aadhar.TabIndex = 313;
            this.aadhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aadhar_KeyPress);
            this.aadhar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.aadhar_KeyUp);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(190, 285);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.address.Size = new System.Drawing.Size(271, 88);
            this.address.TabIndex = 312;
            // 
            // fathername
            // 
            this.fathername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathername.Location = new System.Drawing.Point(190, 163);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(271, 31);
            this.fathername.TabIndex = 311;
            this.fathername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fathername_KeyPress);
            this.fathername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fathername_KeyUp);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(190, 123);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(271, 31);
            this.name.TabIndex = 310;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_KeyUp);
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Transparent;
            this.labeladdress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.ForeColor = System.Drawing.Color.DimGray;
            this.labeladdress.Location = new System.Drawing.Point(43, 288);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(75, 23);
            this.labeladdress.TabIndex = 309;
            this.labeladdress.Text = "Address";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.DimGray;
            this.lblgender.Location = new System.Drawing.Point(43, 248);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 23);
            this.lblgender.TabIndex = 308;
            this.lblgender.Text = "Gender";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.DimGray;
            this.dob.Location = new System.Drawing.Point(43, 207);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(46, 23);
            this.dob.TabIndex = 307;
            this.dob.Text = "DOB";
            // 
            // labelfathername
            // 
            this.labelfathername.AutoSize = true;
            this.labelfathername.BackColor = System.Drawing.Color.Transparent;
            this.labelfathername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfathername.ForeColor = System.Drawing.Color.DimGray;
            this.labelfathername.Location = new System.Drawing.Point(43, 166);
            this.labelfathername.Name = "labelfathername";
            this.labelfathername.Size = new System.Drawing.Size(109, 23);
            this.labelfathername.TabIndex = 306;
            this.labelfathername.Text = "Father name";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.DimGray;
            this.labelname.Location = new System.Drawing.Point(43, 131);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(57, 23);
            this.labelname.TabIndex = 305;
            this.labelname.Text = "Name";
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.BackColor = System.Drawing.Color.Transparent;
            this.labelsurname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsurname.ForeColor = System.Drawing.Color.DimGray;
            this.labelsurname.Location = new System.Drawing.Point(43, 91);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(80, 23);
            this.labelsurname.TabIndex = 304;
            this.labelsurname.Text = "Surname";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(190, 83);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(271, 31);
            this.surname.TabIndex = 303;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            this.surname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.surname_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(42, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 300;
            this.label1.Text = "Faculty Update Form";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(157, 681);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 23);
            this.label10.TabIndex = 359;
            this.label10.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(157, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 23);
            this.label5.TabIndex = 358;
            this.label5.Text = "1.";
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(191, 719);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(270, 31);
            this.salary.TabIndex = 357;
            this.salary.Tag = "";
            // 
            // work2
            // 
            this.work2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work2.Location = new System.Drawing.Point(191, 675);
            this.work2.Name = "work2";
            this.work2.Size = new System.Drawing.Size(270, 31);
            this.work2.TabIndex = 356;
            this.work2.Tag = "Exprience :  Work";
            // 
            // work1
            // 
            this.work1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work1.Location = new System.Drawing.Point(191, 641);
            this.work1.Name = "work1";
            this.work1.Size = new System.Drawing.Size(270, 31);
            this.work1.TabIndex = 355;
            this.work1.Tag = "Exprience :  Work";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(46, 644);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 349;
            this.label6.Text = "Last Work";
            // 
            // skill
            // 
            this.skill.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill.Location = new System.Drawing.Point(190, 520);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(271, 31);
            this.skill.TabIndex = 348;
            // 
            // lastplace
            // 
            this.lastplace.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastplace.Location = new System.Drawing.Point(191, 602);
            this.lastplace.Name = "lastplace";
            this.lastplace.Size = new System.Drawing.Size(271, 31);
            this.lastplace.TabIndex = 347;
            // 
            // lastwork
            // 
            this.lastwork.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastwork.Location = new System.Drawing.Point(191, 563);
            this.lastwork.Name = "lastwork";
            this.lastwork.Size = new System.Drawing.Size(271, 31);
            this.lastwork.TabIndex = 346;
            // 
            // lbllastcompany
            // 
            this.lbllastcompany.AutoSize = true;
            this.lbllastcompany.BackColor = System.Drawing.Color.Transparent;
            this.lbllastcompany.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastcompany.ForeColor = System.Drawing.Color.DimGray;
            this.lbllastcompany.Location = new System.Drawing.Point(44, 602);
            this.lbllastcompany.Name = "lbllastcompany";
            this.lbllastcompany.Size = new System.Drawing.Size(88, 23);
            this.lbllastcompany.TabIndex = 345;
            this.lbllastcompany.Text = "Last Place";
            // 
            // lbllastwork
            // 
            this.lbllastwork.AutoSize = true;
            this.lbllastwork.BackColor = System.Drawing.Color.Transparent;
            this.lbllastwork.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastwork.ForeColor = System.Drawing.Color.DimGray;
            this.lbllastwork.Location = new System.Drawing.Point(44, 566);
            this.lbllastwork.Name = "lbllastwork";
            this.lbllastwork.Size = new System.Drawing.Size(88, 23);
            this.lbllastwork.TabIndex = 344;
            this.lbllastwork.Text = "Last Work";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.BackColor = System.Drawing.Color.Transparent;
            this.lblSkill.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkill.ForeColor = System.Drawing.Color.DimGray;
            this.lblSkill.Location = new System.Drawing.Point(43, 523);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(43, 23);
            this.lblSkill.TabIndex = 343;
            this.lblSkill.Text = "Skill";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Turquoise;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(22, 23);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(479, 750);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1386, 788);
            this.shapeContainer1.TabIndex = 363;
            this.shapeContainer1.TabStop = false;
            // 
            // fac_infoTableAdapter
            // 
            this.fac_infoTableAdapter.ClearBeforeFill = true;
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
            this.gender.Location = new System.Drawing.Point(191, 246);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(271, 31);
            this.gender.TabIndex = 449;
            this.gender.Text = "male/female";
            this.gender.Visible = false;
            // 
            // day
            // 
            this.day.CustomFormat = "dd-MM-yyyy";
            this.day.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.day.Location = new System.Drawing.Point(190, 203);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(272, 31);
            this.day.TabIndex = 450;
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
            this.button1.Location = new System.Drawing.Point(786, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 35);
            this.button1.TabIndex = 452;
            this.button1.Text = "Pay Salary Here";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.insert.Location = new System.Drawing.Point(786, 159);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(166, 73);
            this.insert.TabIndex = 448;
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
            this.btnviewall.Location = new System.Drawing.Point(786, 85);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(166, 73);
            this.btnviewall.TabIndex = 339;
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
            this.btnrefresh.Location = new System.Drawing.Point(953, 85);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(166, 73);
            this.btnrefresh.TabIndex = 338;
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
            this.btndelete.Location = new System.Drawing.Point(1120, 85);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(166, 73);
            this.btndelete.TabIndex = 337;
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
            this.btnupdate.Location = new System.Drawing.Point(953, 159);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(166, 73);
            this.btnupdate.TabIndex = 335;
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
            this.btnexit.Location = new System.Drawing.Point(1120, 159);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(166, 73);
            this.btnexit.TabIndex = 334;
            this.btnexit.Text = "Exit\r\n";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 333;
            this.pictureBox1.TabStop = false;
            // 
            // browseimage
            // 
            this.browseimage.BackColor = System.Drawing.Color.White;
            this.browseimage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseimage.ForeColor = System.Drawing.Color.Black;
            this.browseimage.Image = ((System.Drawing.Image)(resources.GetObject("browseimage.Image")));
            this.browseimage.Location = new System.Drawing.Point(552, 223);
            this.browseimage.Name = "browseimage";
            this.browseimage.Size = new System.Drawing.Size(183, 47);
            this.browseimage.TabIndex = 301;
            this.browseimage.Text = "Browse Image";
            this.browseimage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browseimage.UseVisualStyleBackColor = false;
            this.browseimage.Click += new System.EventHandler(this.browseimage_Click);
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
            this.btn_gender.Location = new System.Drawing.Point(318, 244);
            this.btn_gender.Name = "btn_gender";
            this.btn_gender.Size = new System.Drawing.Size(144, 31);
            this.btn_gender.TabIndex = 459;
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
            this.label_gender.Location = new System.Drawing.Point(187, 248);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(112, 23);
            this.label_gender.TabIndex = 458;
            this.label_gender.Text = "male/female";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(46, 722);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 460;
            this.label3.Text = "Total Salary";
            // 
            // UPDATE_FAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.day);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.work2);
            this.Controls.Add(this.work1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.lastplace);
            this.Controls.Add(this.lastwork);
            this.Controls.Add(this.lbllastcompany);
            this.Controls.Add(this.lbllastwork);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
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
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPDATE_FAC";
            this.Text = "UPDATE_FAC";
            this.Load += new System.EventHandler(this.UPDATE_FAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsclgdatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox work2;
        private System.Windows.Forms.TextBox work1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox skill;
        private System.Windows.Forms.TextBox lastplace;
        private System.Windows.Forms.TextBox lastwork;
        private System.Windows.Forms.Label lbllastcompany;
        private System.Windows.Forms.Label lbllastwork;
        private System.Windows.Forms.Label lblSkill;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private cmsclgdatabase cmsclgdatabase;
        private System.Windows.Forms.BindingSource facinfoBindingSource;
        private cmsclgdatabaseTableAdapters.fac_infoTableAdapter fac_infoTableAdapter;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_gender;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label3;

    }
}