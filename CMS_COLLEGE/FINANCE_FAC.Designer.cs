namespace CMS_COLLEGE
{
    partial class FINANCE_FAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FINANCE_FAC));
            this.left = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.viewall = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.refresh = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.TextBox();
            this.totfee = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.stuID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_tot_sal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.ForeColor = System.Drawing.Color.Black;
            this.left.Location = new System.Drawing.Point(209, 359);
            this.left.Name = "left";
            this.left.ReadOnly = true;
            this.left.Size = new System.Drawing.Size(226, 33);
            this.left.TabIndex = 477;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(66, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 26);
            this.label9.TabIndex = 476;
            this.label9.Text = "Left Salary";
            // 
            // paid
            // 
            this.paid.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.ForeColor = System.Drawing.Color.Black;
            this.paid.Location = new System.Drawing.Point(209, 308);
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.Size = new System.Drawing.Size(226, 33);
            this.paid.TabIndex = 475;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(66, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 474;
            this.label8.Text = "Paid Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(63, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 29);
            this.label7.TabIndex = 473;
            this.label7.Text = "FINANCE FACULTY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(805, 284);
            this.dataGridView1.TabIndex = 472;
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
            this.insert.Location = new System.Drawing.Point(481, 246);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(166, 74);
            this.insert.TabIndex = 470;
            this.insert.Text = " Pay";
            this.insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // viewall
            // 
            this.viewall.BackColor = System.Drawing.Color.White;
            this.viewall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewall.FlatAppearance.BorderSize = 2;
            this.viewall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.viewall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewall.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewall.ForeColor = System.Drawing.Color.Black;
            this.viewall.Image = ((System.Drawing.Image)(resources.GetObject("viewall.Image")));
            this.viewall.Location = new System.Drawing.Point(481, 321);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(166, 73);
            this.viewall.TabIndex = 469;
            this.viewall.Text = "View Data";
            this.viewall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewall.UseVisualStyleBackColor = false;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refresh.FlatAppearance.BorderSize = 2;
            this.refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(648, 247);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(166, 73);
            this.refresh.TabIndex = 468;
            this.refresh.Text = "Refresh";
            this.refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(648, 321);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(166, 72);
            this.exit.TabIndex = 466;
            this.exit.Text = "Exit\r\n";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.Black;
            this.pay.Location = new System.Drawing.Point(209, 246);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(226, 33);
            this.pay.TabIndex = 464;
            this.pay.TextChanged += new System.EventHandler(this.pay_TextChanged);
            // 
            // totfee
            // 
            this.totfee.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totfee.ForeColor = System.Drawing.Color.Black;
            this.totfee.Location = new System.Drawing.Point(209, 193);
            this.totfee.Name = "totfee";
            this.totfee.Size = new System.Drawing.Size(226, 33);
            this.totfee.TabIndex = 463;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(209, 138);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(226, 33);
            this.name.TabIndex = 462;
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuID.ForeColor = System.Drawing.Color.Black;
            this.stuID.Location = new System.Drawing.Point(209, 81);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(226, 33);
            this.stuID.TabIndex = 461;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(66, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 459;
            this.label6.Text = "Pay Salary";
            // 
            // lbl_tot_sal
            // 
            this.lbl_tot_sal.AutoSize = true;
            this.lbl_tot_sal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot_sal.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_tot_sal.Location = new System.Drawing.Point(66, 196);
            this.lbl_tot_sal.Name = "lbl_tot_sal";
            this.lbl_tot_sal.Size = new System.Drawing.Size(110, 26);
            this.lbl_tot_sal.TabIndex = 457;
            this.lbl_tot_sal.Text = "Total Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(66, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 456;
            this.label3.Text = "Faculty Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 455;
            this.label2.Text = "Faculty ID";
            // 
            // FINANCE_FAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 749);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.totfee);
            this.Controls.Add(this.name);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_tot_sal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FINANCE_FAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINANCE_FAC";
            this.Load += new System.EventHandler(this.FINANCE_FAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox pay;
        private System.Windows.Forms.TextBox totfee;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tot_sal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}