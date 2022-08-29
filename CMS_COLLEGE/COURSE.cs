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
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.IO;


namespace CMS_COLLEGE
{
    public partial class COURSE : Form
    {
        //MemoryStream ms;
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataAdapter da;
        List<string> termsList = new List<string>();
        List<string> items = new List<string>();
        //int s_id;
        string radio;
     

       

        public COURSE()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            con.Open();

            InitializeComponent();
        }
        //
        //----------Extra Method-------------
        //
        void listmsg(string msg)
        {
            if (termsList.Count == termsList.Distinct().Count())
            {
                termsList.Add(msg);

            }
        }
      
        //
        //----------End Extra Method---------
        //
       
       

        private void COURSE_Load(object sender, EventArgs e)
        {
            streamdata();
        }
        void streamdata()
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select * from stream_info", con);
            SqlDataReader dr = cmmd.ExecuteReader();
            while (dr.Read())
            {
                //s_id = int.Parse(dr.GetValue(0).ToString());
                stream.Items.Add(dr.GetValue(1).ToString());

            }
            con.Close();


        }
       

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void fee_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = fee.Text.ToCharArray();//stroe the every caharter u enter in the textbox


            for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
            {
                //Isletter property of char is using to chek the special charcters

                if (!char.IsDigit(testarr[i]))
                {
                    errorProvider1.SetError(fee, "Symbols are not allowed");
                    MessageBox.Show("symbol are not allowed");
                    fee.Clear();
                }
                else
                {
                    //fee.Clear();
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshdata();
        }
        void refreshdata()
        {

            newcourse.Text = "";
            subjects.Text = "";
            stream.Text = "";
            stream.SelectedItem = null;
            year.SelectedItem = null;
            male.Checked = false;
            female.Checked = false;
            fee.Text = "";



        }
        private void button2_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(newcourse.Text)) listmsg("new course , ");
            //if (items.Count == null) listmsg("new course");

           
            if (String.IsNullOrEmpty(subjects.Text)) listmsg("subjects , ");
            if (String.IsNullOrEmpty(fee.Text)) listmsg("fee .");
            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value" + string.Join(" , ", termsList));
                //termsList.RemoveRange(0, 9);
                termsList.Clear();
            }

            if (male.Checked == true)
                radio = "moring";
            else if (female.Checked == true)
                radio = "afternoon";
            else
                MessageBox.Show("select any one option[male/female]");

            if (year.SelectedItem == null) MessageBox.Show("Select total subject");

            /* for (i=0; i < courseitem.Items.Count - 1; i++)
             {
                ary[i] = courseitem.Items[i].ToString();
               
             }*/

            if(stream.SelectedItem == null) MessageBox.Show("Select 'Stream' value...");
            else if(termsList.Count !=0) {}
            else if(radio == null) MessageBox.Show("Select 'Time' value...");
            else if(year.SelectedItem == null) MessageBox.Show("Select 'Total Year' value...");

            //--------INSERT QUREY----------
            else 
            {
               
                    cmd = new SqlCommand("insert into course (course,year,subject,time,fee,s_name) values(@c_name,@year,@subject,@time,@fee,@s_name)",con);
                  
                    cmd.Parameters.AddWithValue("@c_name", newcourse.Text);
                    cmd.Parameters.AddWithValue("@s_name", stream.SelectedValue);
                    cmd.Parameters.AddWithValue("@year", year.SelectedValue);
                    cmd.Parameters.AddWithValue("@subject", subjects.Text);
                    cmd.Parameters.AddWithValue("@time", radio.ToString());
                    cmd.Parameters.AddWithValue("@fee", fee.Text);

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    int m = cmd.ExecuteNonQuery();
                    if (m > 0)
                    {
                        MessageBox.Show("insert data");
                        con.Close();
                        refreshdata();
                    }

                    else
                    {
                        MessageBox.Show("not insert");
                        refreshdata();
                        con.Close();
                    }
                
            }

        }

        private void stream_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new STREAM()).Show();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
