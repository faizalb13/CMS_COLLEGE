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
    public partial class MODIFY_COURSE : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
        SqlCommand cmd;
       
        string radio;
        List<string> termsList = new List<string>();

        public MODIFY_COURSE()
        {
            //con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");

            InitializeComponent();
        }


        //************** Update Method *************
        public DataSet updatestuData()
        {
            string radio1;
            if (newstream.Visible == false) radio = label_stream.Text;
            else radio = newstream.SelectedItem.ToString();

            if (time.Visible == false) radio1 = label_time.Text;
            else radio1 = time.SelectedItem.ToString();
           // con.Open();
            SqlCommand cmdQuery = new SqlCommand("update course set stream =@stream, course ='"+newcourse.Text+"', total_subject ='"+totalyear.SelectedItem.ToString()+"', subject ='"+subjects.Text+"', time =@time, fee ='"+fee.Text+"' where id = '"+courseID.Text+"' or stream = '"+newstream.Text+"'", con);
            cmdQuery.Parameters.AddWithValue("@stream", radio);
            cmdQuery.Parameters.AddWithValue("@time", radio1);

            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            con.Close();
            sda.Fill(cmsclgdatabase);
            
            return cmsclgdatabase;

        }

        //**************End Update Method **********

        //************** Delete Method *************
        public DataSet deletestuData()
        {
            //con.Open();
            SqlCommand cmdQuery = new SqlCommand("delete from course where id = '" + courseID.Text + "' or stream = '" + newstream.Text + "' or course = '" + newcourse.Text.ToString() + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            con.Close();
            sda.Fill(cmsclgDataSet2);
           

            return cmsclgDataSet2;

        }

        //**************End Delete Method **********

        //************** Select Method *************
        /*public DataSet selectstuData()
        {
            SqlConnection conString = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            conString.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from course", conString);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            sda.Fill(cmsclgdatabase);
            return cmsclgdatabase;

        }*/
        public void selectstuData()
        {

            //con.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from course", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }
        //**************End SELECT Method **********

        //**************REFRESH Method **********
        void refreshdata()
        {
            courseID.Text = "";
            newcourse.Text = "";
            newstream.Text = "";
            newstream.SelectedItem = null;
            totalyear.SelectedItem = null;
            subjects.Text = "";
            time.Visible = false;
            label_time.Visible = true;
            btn_time.Visible = true;
            fee.Text = "";
            newstream.Visible = false;
            label_stream.Visible = true;
            btn_stream.Visible = true;
        }
        //**************End REFRESH Method **********

        //
        //
        //-----------END EXTRA METHOD-------
        //
        //


        //----------------DELETE QUREY -------------

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (courseID.Text == null && newcourse.Text == null) MessageBox.Show("Enter Value in course ID or Name");
            else {

                string message = "Do you want to Delete in " +courseID.Text.ToString()+" " + newcourse.Text.ToString();
                string title = "Delete Message";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //msg Yes
                if (result == DialogResult.Yes)
                {

                    //deletestuData();
                    
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete from course where c_id = '" + courseID.Text + "' or c_name = '" + newcourse.Text + "'", con);
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
                //msg NO
                else
                {
                    MessageBox.Show("Not Delete.....");

                }
            }
            refreshdata();
            selectstuData();
        }

        //---------END DELETE QUREY------------------

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshdata();
            selectstuData();
        }

        private void MODIFY_COURSE_Load(object sender, EventArgs e)
        {
           
            streamdata();
            selectstuData();
        }
        void streamdata()
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select * from stream_info", con);
            SqlDataReader dr = cmmd.ExecuteReader();
            while (dr.Read())
            {
                //s_id = int.Parse(dr.GetValue(0).ToString());
                newstream.Items.Add(dr.GetValue(1).ToString());

            }
            con.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.course_infoTableAdapter1.Fill(this.cmsclgDataSet2.course_info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            selectstuData();

            cmd = new SqlCommand("select * from course where c_id= '"+courseID.Text+"'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                refreshdata();
                courseID.Text = dr.GetValue(0).ToString().Replace(" ", string.Empty); ;
                newcourse.Text = dr.GetValue(1).ToString().Replace(" ", string.Empty); ;
                totalyear.SelectedItem = dr.GetValue(2).ToString().Replace(" ", string.Empty); ;
                subjects.Text = dr.GetValue(3).ToString().Replace(" ", string.Empty); ;

                if (btn_time.Visible == false || label_time.Visible == false)
                {
                    btn_time.Visible = true;
                    label_time.Visible = true;
                    time.Visible = false;
                    label_time.Text = dr.GetValue(4).ToString().Replace(" ", string.Empty); ;
                }
                else
                {
                    label_time.Text = dr.GetValue(4).ToString().Replace(" ",string.Empty);
                    time.Visible = false;
                }
                fee.Text = dr.GetValue(5).ToString().Replace(" ", string.Empty); ;
                if (btn_stream.Visible == false || label_stream.Visible == false)
                {
                    btn_stream.Visible = true;
                    label_stream.Visible = true;
                    newstream.Visible = false;
                    label_stream.Text = dr.GetValue(6).ToString().Replace(" ", string.Empty); ;
                }
                else
                {
                    label_stream.Text = dr.GetValue(6).ToString().Replace(" ", string.Empty); ;
                    newstream.Visible = false;
                }
              

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           

            if (courseID.Text == null && newcourse.Text == null) MessageBox.Show("Enter Value in course ID or Name");
            else{

                string message = "Do you want to update in "+ courseID.Text.ToString()+" , "+ newcourse.Text.ToString();
                string title = "Update Message";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //msg Yes
                if (result == DialogResult.Yes)
                {

                    //updatestuData();
                    if (courseID.Text == "" && newcourse.Text == null) MessageBox.Show("Enter value in stream ID or Name....");
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update course set c_name ='" + newcourse.Text + "', year ='" + totalyear.SelectedValue + "', subject ='" + subjects.Text + "', time ='" + radio + "', fee ='" + fee.Text + "',s_name ='" + newstream.SelectedValue + "' where id = '" + courseID.Text + "' or c_name = '" + newcourse.Text + "'", con);
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
                }
                //msg NO
                else
                {
                    MessageBox.Show("Not Update.....");

                }
            }
            
            selectstuData();
            refreshdata();
        }
        void listmsg(string msg)
        {
            if (termsList.Count == termsList.Distinct().Count())
            {
                termsList.Add(msg);

            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(newcourse.Text)) listmsg("new course , ");
            //if (items.Count == null) listmsg("new course");

            if (String.IsNullOrEmpty(newstream.Text)) listmsg("new stream  ");
            if (String.IsNullOrEmpty(subjects.Text)) listmsg("subjects  ");
            if (String.IsNullOrEmpty(fee.Text)) listmsg("fee ");

            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value" + string.Join(" , ", termsList));
                termsList.Clear();
            }


            //string[] list = courseitem.Items.OfType<string>().ToArray();


            if (time.SelectedItem == null) MessageBox.Show("Select total subject");
            if (newstream.SelectedItem == null) MessageBox.Show("Select total subject");
            if (totalyear.SelectedItem == null) MessageBox.Show("Select total subject");

            //--------INSERT QUREY----------
            if (termsList.Count == 0 && radio != null && totalyear.SelectedItem != null)
            {
                con.Open();
                cmd = new SqlCommand("insert into course (c_name,year,subject,time,fee,s_name) values('" + newcourse.Text + "','" + totalyear.SelectedItem.ToString() + "','" + subjects.Text + "','" + radio.ToString() + "','" + int.Parse(fee.Text) + "','" + newstream.SelectedItem.ToString()+ "')",con);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("Insert Data Sucessfuly ....");
                    con.Close();
                    selectstuData();
                    refreshdata();
                }
                else
                {
                    MessageBox.Show("Insert Failed....");
                    con.Close();
                }
            }
        }

        private void btn_stream_Click(object sender, EventArgs e)
        {
            newstream.Visible = true;
            label_stream.Visible = false;
            btn_stream.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time.Visible = true;
            label_time.Visible = false;
            btn_time.Visible = false;
        }
    }
}
