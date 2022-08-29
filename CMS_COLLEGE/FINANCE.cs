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

namespace CMS_COLLEGE
{
    public partial class FINANCE_STU : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
        // SqlDataReader dr;
        int pay_sal;
        int left_sal;
        string clgnm, date;


        public FINANCE_STU()
        {
            InitializeComponent();
            left.Text = "0";
        }



        public void viewdata()
        {
            int rno = 0;
            con.Open();
            if (String.IsNullOrEmpty(stuID.Text) && String.IsNullOrEmpty(name.Text)) MessageBox.Show("Must Enter 'Sutdent ID' or 'Name'");
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select id,name,DOB,course,fee,paidfee  from stu_info where id = '" + stuID.Text + "' or name = '" + name.Text + "'", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "stu_info");



                if (ds.Tables[0].Rows.Count > 0)
                {

                    stuID.Text = ds.Tables[0].Rows[rno][0].ToString();
                    name.Text = ds.Tables[0].Rows[rno][1].ToString();
                    DOB.Text = ds.Tables[0].Rows[rno][2].ToString();
                    course.Text = ds.Tables[0].Rows[rno][3].ToString();
                    totfee.Text = ds.Tables[0].Rows[rno][4].ToString();
                    pay.Text = ds.Tables[0].Rows[rno][5].ToString();
                    paid.Text = ds.Tables[0].Rows[rno][5].ToString();
                    left.Text = (int.Parse(totfee.Text) - int.Parse(pay.Text)).ToString();
                    left_sal = int.Parse(left.Text);


                }
                else
                    MessageBox.Show("No Records");

            }

            con.Close();
        }
        public void selectdata()
        {
            con.Open();
            //SqlCommand cmd = new SqlCommand("select id,surname,name,fathername,stream,course,fee,paidfee * from stu_info",con);
            SqlCommand cmdQuery = new SqlCommand("select id,surname,name,DOB,fathernm,stream,course,fee,paidfee  from stu_info", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        public void refreshdata()
        {
            course.SelectedItem = null;
            course.Text = "Course";
            stuID.Text = "";
            name.Text = "";
            totfee.Text = "";
            paid.Text = "";
            pay.Text = "";
            DOB.Text = "";
            left.Text = "";


            selectdata();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void viewall_Click(object sender, EventArgs e)
        {
            viewdata();


        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (stuID.Text != null || name.Text != null || pay.Text != null)
            {

                string message = "Do you want to pay fee = ' " + pay.Text + " ' in  ' " + stuID.Text + " " + name.Text + " '  ?";
                string title = "Fee Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //msg Yes
                if (result == DialogResult.Yes)
                {

                    pay_sal = int.Parse(pay.Text);

                    if (pay_sal > left_sal)
                    {

                        MessageBox.Show("you give more money.....RS." + (int.Parse(totfee.Text) - pay_sal).ToString());
                    }
                    else
                    {
                        updatedata((int.Parse(pay.Text) + int.Parse(paid.Text)));
                        saveFile();
                    }
                    refreshdata();

                    refreshdata();

                }
                //msg NO
                else
                {
                    MessageBox.Show("Fee not pay.....");

                }
            }
        }
        public void updatedata(int money)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update stu_info set paidfee = '" + money + "' where id = '" + stuID.Text + "' ", con);
            cmd.Connection = con;
            int m = cmd.ExecuteNonQuery();
            if (m > 0)
            {

                MessageBox.Show("transaction sucessfuly.....\n Pay fee : " + pay.Text);
            }
            else
                MessageBox.Show("transaction fail !!!...");


            con.Close();
        }
        public void saveFile()
        {
            string path = "D:\\PROJECTS\\MY PROJECT IMAGE\\CMS_COLLEGE\\CMS_COLLEGE\\student.txt";
            DialogResult result;
            result = MessageBox.Show("Do you want to save file?", "Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.No)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                // for clg name
                con.Open();
                SqlCommand cmd = new SqlCommand("select clgnm from admin where id = 1", con);
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                clgnm = dr.GetValue(0).ToString();
                con.Close();

                //for date
                date = DateTime.Now.ToString();
                if (File.Exists(path))
                {
                    try
                    {
                        if (clgnm == null) MessageBox.Show("clg");
                        else if (date == null) MessageBox.Show("date");
                        else if (stuID.Text == null) MessageBox.Show("stuid");
                        else if (name.Text == null) MessageBox.Show("name");
                        else if (pay.Text == null) MessageBox.Show("pay");
                        else
                        {
                            string Msg = clgnm + "\n" + date + ";\n" + label2.Text + ":\t" + stuID.Text + ";\n" + label3.Text + ":\t" + name.Text + ";\n" + label5.Text + ":\t" + DOB.Text + ";\n" + label4.Text + ":\t" + totfee.Text + ";\n" + label6.Text + ":\t" + pay.Text + ";\n";

                            // Save File to .txt  
                            //FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
                            //StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                            //m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                            //m_WriterParameter.Write(Msg);
                            //m_WriterParameter.Flush();
                            //m_WriterParameter.Close();
                            File.OpenText(path);
                            string[] lines = File.ReadAllLines(path);
                            if (lines == null)
                            {
                                TextWriter txt = new StreamWriter(path);
                                txt.Write(Msg);
                                txt.Close();
                            }
                            else
                            {
                                File.AppendAllText(path, "\n\n" + Msg + Environment.NewLine);
                            }

                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
                else { MessageBox.Show("File not Found \n File path : "+path); }
            }

        }

        private void FINANCE_STU_Load(object sender, EventArgs e)
        {
            selectdata();
            coursedata();

        }
        void coursedata()
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select c_name from course", con);
            SqlDataReader dr = cmmd.ExecuteReader();
            while (dr.Read())
            {
                //s_id = int.Parse(dr.GetValue(0).ToString());
                course.Items.Add(dr.GetValue(0).ToString());

            }
            con.Close();


        }


        private void pay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void paid_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
