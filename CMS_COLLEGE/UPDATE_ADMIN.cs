using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging; 

namespace CMS_COLLEGE
{
    public partial class UPDATE_ADMIN : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataAdapter da;
        SqlDataReader dr;
        MemoryStream ms;
        byte[] photo_aray;
     
        public UPDATE_ADMIN()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
           

            InitializeComponent();
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void UPDATE_ADMIN_Load(object sender, EventArgs e)
        {
           
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackground = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;
            }  
        }
       

        //update btn
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(adminname.Text))
            {
                MessageBox.Show("Please,Enter Value in 'Name' Filed");
                adminname.Focus();
            }
            if (String.IsNullOrEmpty(adminpassword.Text))
            {
                MessageBox.Show("Please,Enter Value in 'Password' Filed");
                adminpassword.Focus();
            }
            if (String.IsNullOrEmpty(txtrepw.Text))
            {
                MessageBox.Show("Please,Enter Value in 'Retype Password' Filed");
                txtrepw.Focus();
            }
           if (adminpassword.Text == txtrepw.Text && adminname.Text != null && clgnm.Text != null && logo.Image != null)
           {
               con.Open();
               cmd = new SqlCommand("update admin set admin = '"+adminname.Text+"' , pw = '"+adminpassword.Text+"' , clgnm = '"+clgnm.Text+"' , logo = @photo where id=1",con);
               conv_photo();
               cmd.Connection = con;
               int m = cmd.ExecuteNonQuery();
               con.Close();
               if (m > 0) MessageBox.Show("Update Done...");
               else MessageBox.Show("Not Update..!!!!");
                  

           }
           else
            {

                msg.ForeColor = Color.Red;
                msg.Text = " not match";
            }
           adminname.Text = "";
           adminpassword.Text = "";
           txtrepw.Text = "";
           clgnm.Text = "";
           logo.Image = null;
        }


        //photo send to db
        void conv_photo()
        {
            //converting photo to binary data  
            if (logo.Image != null)
            {
                //using FileStream:(will not work while updating, if image is not changed)  
                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);  
                //byte[] photo_aray = new byte[fs.Length];  
                //fs.Read(photo_aray, 0, photo_aray.Length);    

                //using MemoryStream:  
                ms = new MemoryStream();
                logo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }
         
        //photo browse
        private void broim_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                logo.Image = Image.FromFile(openFileDialog1.FileName);
            }   
        }


        //------------Login data----------------------

        private void login_Click_1(object sender, EventArgs e)
        {
            con.Open();
          cmd = new SqlCommand("select * from admin where admin = '" + txtcunmn.Text + "' and  pw = '" + txtcupw.Text + "'",con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                
                    MessageBox.Show("login sucess");
                    //hide data
                    lblcurrname.Visible = false;
                    lbldotcurrnm.Visible = false;
                    txtcunmn.Visible = false;
                    lblcurrpass.Visible = false;
                    lbldotcurpw.Visible = false;
                    txtcupw.Visible = false;
                    login.Visible = false;
                    cancel.Visible = false;



                    //show data

                    lblname.Visible = true;
                    lbldotnm.Visible = true;
                    adminname.Visible = true;
                    lblpass.Visible = true;
                    lbldotpw.Visible = true;
                    adminpassword.Visible = true;
                    lblrepass.Visible = true;
                    lbldotrepw.Visible = true;
                    txtrepw.Visible = true;
                    clgnm.Visible = true;
                    lblclgnm.Visible = true;
                    lblclgdot.Visible = true;
                    lblimage.Visible = true;
                    lbldotim.Visible = true;
                    logo.Visible = true;
                    broim.Visible = true;
                    btnupdate.Visible = true;
                    exit.Visible = true; 
                    msg.Visible = true;


                 dr.Close();

                

            }
            else
            {
                MessageBox.Show("Invalid");
                txtcunmn.Text = "";
                txtcupw.Text = "";
                txtcunmn.Focus();
                dr.Close();
            }
            con.Close();
            viewload();
        }
        public void viewload()
        {
            con.Open();
            cmd = new SqlCommand("select admin,pw,clgnm,logo from admin where id = 1", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                adminname.Text = dr.GetValue(0).ToString().Replace("",string.Empty);
                adminpassword.Text = dr.GetValue(1).ToString().Replace("", string.Empty);
                clgnm.Text = dr.GetValue(2).ToString().Replace("", string.Empty);

                logo.Image = null;
                if (dr.GetValue(3) != System.DBNull.Value)
                {
                    photo_aray = (byte[])dr.GetValue(3);
                    MemoryStream ms = new MemoryStream(photo_aray);
                    logo.Image = Image.FromStream(ms);
                }

            }
            con.Close();
        }

        private void txtrepw_KeyUp(object sender, KeyEventArgs e)
        {
            if (adminpassword.Text == txtrepw.Text)
            {
                msg.ForeColor = Color.Green;
                msg.Text = "match";

            }
            else
            {

                msg.ForeColor = Color.Red;
                msg.Text = " not match";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            (new HOME()).Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            (new HOME()).Show();
        }
    }
}
