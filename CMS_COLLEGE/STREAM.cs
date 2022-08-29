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

namespace CMS_COLLEGE
{
    public partial class STREAM : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
        public STREAM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new MODIFY_COURSE()).Show();

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (streamnm.Text == null) MessageBox.Show("Enter value in stream name....");
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into stream_info (s_name) values('" + streamnm.Text + "')", con);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("Insert Data Sucessfuly ....");
                    
                    
                }
                else
                {
                    MessageBox.Show("Insert Failed...");
                   
                }
                con.Close();
            }
            selectstuData();
            refreshdata();
           
        }
        public void refreshdata()
        {
            streamID.Text = "";
            streamnm.Text = "";
        }
        public void selectstuData()
        {

            con.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from stream_info", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            selectstuData();
            SqlCommand cmd = new SqlCommand("select * from stream_info where s_id = '" + streamID.Text + "' or s_name = '" + streamnm.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                streamID.Text = dr.GetValue(0).ToString();
                streamnm.Text = dr.GetValue(1).ToString();

            }
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (streamID.Text == "" && streamnm.Text == null) MessageBox.Show("Enter value in stream ID or Name....");
            else {
                con.Open();
                SqlCommand cmd = new SqlCommand("update stream_info set s_name = '" + streamnm.Text + "' where s_id = '" + streamID.Text + "' or s_name = '" + streamnm.Text + "'", con);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("Update Data Sucessfuly ....");
                   
                   
                }
                else
                {
                    MessageBox.Show("Update Failed...");
                    
                }
                con.Close();
            }
          
            selectstuData();
            refreshdata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (streamID.Text == "" && streamnm.Text == null) MessageBox.Show("Enter value in stream ID or Name....");
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from stream_info where s_id = '" + streamID.Text + "' or s_name = '" + streamnm.Text + "'", con);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("Delete Data Sucessfuly ....");
                    
                    
                }
                else
                {
                    MessageBox.Show("Delete Failed...");
                  
                }
                con.Close();
            }
            selectstuData();
            refreshdata();
           
        }

        private void STREAM_Load(object sender, EventArgs e)
        {
            selectstuData();
            coursedata();

        }
        public void coursedata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from course", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
          
        }
    }
}
