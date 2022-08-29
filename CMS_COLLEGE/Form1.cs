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
//using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;  

namespace CMS_COLLEGE
{
    public partial class Form1 : Form
    {
        SqlConnection con;
 
        SqlDataAdapter da;
        //SqlDataReader dr;
        DataSet ds;
        int no=0;
       // MemoryStream ms;  
        byte[] photo_aray; 
        public Form1()
        {
           con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            
            InitializeComponent();
        }
       void loaddata()  
       {  
           da = new SqlDataAdapter("select * from admin", con);  
           da.MissingSchemaAction = MissingSchemaAction.AddWithKey;  
           ds = new DataSet();
           da.Fill(ds,"admin");  
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
                  pictureBox1.Image = new Bitmap(ms);
               }
           }
      }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                (new ADMIN()).Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            loaddata();
            showdata();
        }
    }
}
