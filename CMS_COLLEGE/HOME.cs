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
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic; 

namespace CMS_COLLEGE
{
    public partial class HOME : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        //SqlDataReader dr;
        DataSet ds;
        int no = 0;
        //MemoryStream ms;
        byte[] photo_aray; 
        public HOME()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");

            InitializeComponent();
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
                lblclgnm.Text = ds.Tables[0].Rows[no][3].ToString();
                pictureBox1.Image = null;
                if (ds.Tables[0].Rows[no][4] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[no][4];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
        private void HOME_Load(object sender, EventArgs e)
        {
            loaddata();
            showdata();
        }
   

        private void button10_Click(object sender, EventArgs e)
        {
           
            (new NEW_FAC()).Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            (new COURSE()).Show();
        }


        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            (new FINANCE_STU()).Show();

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            (new EVENT()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            (new UPDATE_EVENT()).Show();

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
            (new NEW_FAC()).Show();

        }

        private void newstu_Click(object sender, EventArgs e)
        {
            
            (new NEW_STU()).Show();

        }

        private void modifystu_Click(object sender, EventArgs e)
        {
            (new UPDATE_PRO()).Show();

        }

        private void modifyfac_Click(object sender, EventArgs e)
        {
            
            (new UPDATE_FAC()).Show();

        }

        private void newcourse_Click(object sender, EventArgs e)
        {
            (new STREAM()).Show();

        }

        private void modifycourse_Click(object sender, EventArgs e)
        {
            
            (new MODIFY_COURSE()).Show();

        }

        private void finance_stu_Click(object sender, EventArgs e)
        {
           
            (new FINANCE_STU()).Show();

        }

        private void finance_fac_Click(object sender, EventArgs e)
        {
           
            (new FINANCE_FAC()).Show();

        }

        private void setting_Click(object sender, EventArgs e)
        {
            (new UPDATE_ADMIN()).Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void modifyevent_Click(object sender, EventArgs e)
        {
            (new MODIFY_COURSE()).Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new VIEW_STUDY()).Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            (new ABOUT_SOFT()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new RESULT()).Show();
        }
    }
}
