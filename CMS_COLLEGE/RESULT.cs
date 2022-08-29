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
    public partial class RESULT : Form
    {
        SqlConnection con;
        MemoryStream ms;
        byte[] photo_aray;
        SqlCommand cmd;
        Boolean check;

        public RESULT()
        {
           con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");

            InitializeComponent();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            viewload();
        }
        public void viewload()
        {
            con.Open();
            cmd = new SqlCommand("select s_id,name,result from Result where s_id = '"+stuID.Text+"' or name = '"+name.Text+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    stuID.Text = dr.GetValue(0).ToString().Replace(" ", string.Empty);
                    name.Text = dr.GetValue(1).ToString().Replace(" ", string.Empty);
                    pictureBox1.Image = null;

                    if (dr.GetValue(2) != System.DBNull.Value)
                    {
                        photo_aray = (byte[])dr.GetValue(2);
                        MemoryStream ms = new MemoryStream(photo_aray);
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                }
            }
            else
            {
                MessageBox.Show("Data not Exist....");
                refreshdata();
            }
            con.Close();
        }
        void conv_photo()
        {
            //converting photo to binary data  
            if (pictureBox1.Image != null)
            {
                //using FileStream:(will not work while updating, if image is not changed)  
                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);  
                //byte[] photo_aray = new byte[fs.Length];  
                //fs.Read(photo_aray, 0, photo_aray.Length);    

                //using MemoryStream:  
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }

        private void browseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = op.ShowDialog();


            if (res == DialogResult.OK)
            {
                // pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Image i = Image.FromFile(op.FileName);
                pictureBox1.Image = i;
            }   
        }

       

        private void insert_Click(object sender, EventArgs e)
        { 
            if (stuID.Text == null && name.Text == "" && pictureBox1.Image == null ) MessageBox.Show("you  miss infomation....");

            checkdata();
            if (check == false) { }
                
            else
            {

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                con.Open();
                cmd = new SqlCommand("insert into Result values('" + stuID.Text + "' , '" + name.Text + "',@photo) ", con);
                cmd.Parameters.AddWithValue("@photo", img);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                con.Close();
                if (m > 0)
                {
                    MessageBox.Show("insert data");
                   
                    

                }
                else
                {
                    MessageBox.Show("not insert");
                    con.Close();
                }

            }
            con.Close();
            refreshdata();
            selectstuData();
        }
        public void checkdata()
        {
            if (String.IsNullOrEmpty(stuID.Text) && String.IsNullOrEmpty(name.Text))
                MessageBox.Show("Please,Enter Value in 'Admin' & 'Password' Box");
            con.Open();
            cmd = new SqlCommand("select id,name from stu_info where id = '" + stuID.Text + "' and  name = '" + name.Text + "'");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                check = true;
            }
            else
            {
                MessageBox.Show("Student ID or Name not Match...");
                check = false;
                stuID.Focus();
                dr.Close();
            }
            con.Close();

        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
        public void refreshdata()
        {
            stuID.Text = "";
            name.Text = "";
            pictureBox1.Image = null;
            selectstuData();
            studata();
        }
        public void selectstuData()
        {

            //con.Open();
            SqlCommand cmdQuery = new SqlCommand("select s_id,name,result from Result", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        public void studata()
        {

            //con.Open();
            SqlCommand cmdQuery = new SqlCommand("select id,name,dob,phone from stu_info", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;


        }
        private void RESULT_Load(object sender, EventArgs e)
        {
            selectstuData();
            studata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //con.Open();
            SqlCommand cmdQuery = new SqlCommand("select id,name,dob,phone from stu_info where id='"+stuID.Text+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
           
            sda.Fill(dt);
            dataGridView2.DataSource = dt;


        
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (stuID.Text != null || name.Text != null)
            {

                string message = "Do you want to update in " + name.Text.ToString() + stuID.Text.ToString();
                string title = "Update Message";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //      msg Yes
                if (result == DialogResult.Yes)
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    con.Open();
                    cmd = new SqlCommand("update Result set  result = @photo where s_id = '"+stuID.Text+"' ", con);
                    cmd.Parameters.AddWithValue("@photo", img);
                    cmd.Connection = con;
                    int m = cmd.ExecuteNonQuery();
                    con.Close();
                    if (m > 0) MessageBox.Show("Update Done...");
                    else MessageBox.Show("Update Fail ..!!!!");

                    selectstuData();
                    refreshdata();
                    // updatestuData();


                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Result where s_id = '" + stuID.Text + "' ", con);
            int m = cmd.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("delete data sucessfuly...");

                selectstuData();
                refreshdata();
            }
            else
            {
                MessageBox.Show("data not delete....");

            }
            con.Close();
        }

       
    }
}
