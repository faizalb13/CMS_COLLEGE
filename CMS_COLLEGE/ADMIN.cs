using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic; 

namespace CMS_COLLEGE
{
    public partial class ADMIN : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        int no = 0;
        //MemoryStream ms;
        byte[] photo_aray; 

        public ADMIN()
        {
            Thread t = new Thread(slap);
            t.Start();
            Thread.Sleep(2000);// show strating window time

            con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            con.Open();
            InitializeComponent();

            t.Abort();

        }
        void loaddata()
        {
            da = new SqlDataAdapter("select * from admin", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet();
            da.Fill(ds, "admin");
        }
        void showdata()
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                pictureBox1.Image = null;
                if (ds.Tables[0].Rows[no][4] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[no][4];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        public void slap()
        {
            Application.Run(new Form1());
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            loaddata();
            showdata();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text))
                MessageBox.Show("Please,Enter Value in 'Admin' & 'Password' Box");

           cmd = new SqlCommand("select * from admin where admin = '" + textBox1.Text + "' and  pw = '" + textBox2.Text + "'");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MessageBox.Show("login sucess");
                    (new HOME()).Show();
                    //HOME f3 = new HOME(); //this is the change, code for redirect  
                    //f3.ShowDialog();
                    this.Close();
                }

            }
            else {
                MessageBox.Show("Invalid data...");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
                dr.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
