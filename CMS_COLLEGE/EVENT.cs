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
using Microsoft.VisualBasic;
using System.IO;
using System.Drawing.Imaging; 

namespace CMS_COLLEGE
{
    public partial class EVENT : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
        SqlCommand cmd;
        MemoryStream ms;
        byte[] photo_aray;
        List<string> termsList = new List<string>();
        List<string> comboList = new List<string>();
       
        public EVENT()
        {
            InitializeComponent();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //***************INSERT QUERY******************
        void insertdata()
        {
            con.Open();
            cmd = new SqlCommand("insert into event(event,date,day,time,place,stream,handler,speaker,photo) values('" + eventname.Text + "','" + day.Value + "','"+daynm.SelectedItem.ToString()+"','" + time.Text + "','" + place.Text + "','" + stream.SelectedItem.ToString() + "','" + handler.Text + "','" + speaker.Text + "',@photo)", con);
            //cmd.Connection = con;
            conv_photo();
            int m = cmd.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("insert data");
                con.Close();
                selectstuData();
                refreshdata();
            }
            else
            {
                MessageBox.Show("not insert");
                con.Close();
            }
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

        //***************UPDATE QUERY******************
        public void updatestuData()
        {
            string dayname,streamnm;
             MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                if (lbldaynm.Visible == true) dayname = lbldaynm.Text;
                else dayname = daynm.SelectedItem.ToString();

                if (label_stream.Visible == true) streamnm = label_stream.Text;
                else streamnm = stream.SelectedItem.ToString();
            con.Open();
            cmd = new SqlCommand("update event set event  ='" + eventname.Text + "' , date ='" + day.Text + "',day=@daynm, time ='" + time.Text + "', place ='" + place.Text + "', stream =@stream, handler  ='" + handler.Text + "', speaker  ='" + speaker.Text + "',photo = @photo  where id = '" + stuID.Text + "' or event = '" + eventname.Text + "'", con);
            conv_photo();
            cmd.Parameters.AddWithValue("@daynm", dayname);
            cmd.Parameters.AddWithValue("@stream", streamnm);
            int m = cmd.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("update data sucessfuly...");
                con.Close();
                selectstuData();
                refreshdata();
            }
            else
            {
                MessageBox.Show("data not update....");
                con.Close();
            }

        }
        //***************VIEW QUERY******************
        public void viewdata() 
        {
            selectstuData();

            con.Open();
            cmd = new SqlCommand("select * from event where id = '" + stuID.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                refreshdata();
                stuID.Text = dr.GetValue(0).ToString();
                eventname.Text = dr.GetValue(1).ToString();
                day.Value = Convert.ToDateTime(dr.GetValue(2));
                lbldaynm.Text = dr.GetValue(3).ToString();
                time.Text = dr.GetValue(4).ToString();
                place.Text = dr.GetValue(5).ToString();
                label_stream.Text = dr.GetValue(6).ToString();
                handler.Text = dr.GetValue(7).ToString();
                speaker.Text = dr.GetValue(8).ToString();
                pictureBox1.Image = null;
                if(dr.GetValue(9) != System.DBNull.Value)
                {
                    photo_aray = (byte[])dr.GetValue(9);
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }

            }
            con.Close();
        }
        //***************DELETE QUERY******************
        public void deletestuData()
        {
            con.Open();
            SqlCommand cmd= new SqlCommand("delete from event where id = '" + stuID.Text + "'", con);
            int m = cmd.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("delete data sucessfuly...");
                con.Close();
                selectstuData();
                refreshdata();
            }
            else
            {
                MessageBox.Show("data not delete....");
                con.Close();
            }

        }
        //***************SELECT QUERY******************
        public void selectstuData()
        {

            con.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from event", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        //***************REFRESH QUERY******************
        void refreshdata()
        {
            stuID.Text = "";
            eventname.Text = "";
            day.Value = DateTime.Now.Date;

            time.Value = DateTime.Now.Date;
            place.Text = "";
            stream.Text = "Select Stream";
            handler.Text = "";
            speaker.Text = "";
            pictureBox1.Image = null;
        }
        void listmsg(string msg)
        {
            if (termsList.Count == termsList.Distinct().Count())
            {
                termsList.Add(msg);

            }
        }
        void listcombo(string msg)
        {
            if (comboList.Count == comboList.Distinct().Count())
            {
                comboList.Add(msg);

            }
        }

        //public void idfound()
        //{
        //    con.Open();
        //    cmd = new SqlCommand("select * from event where id = '"+stuID.Text+"' or event = '"+eventname.Text+"'", con);
        //    int m = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (m > 0) { }
        //    else MessageBox.Show("data not found");


        //}
        private void insert_Click(object sender, EventArgs e)
        {
            
            if (eventname.Text == "")listmsg("Event name , ");
            if (place.Text == "") listmsg("Place , ");
            if (handler.Text == "")listmsg("Event handler name , ");
            if (speaker.Text == "")listmsg("Speaker name .");
            if (stream.Text== "stream" && stream.SelectedItem == null) listcombo("stream");
            if (pictureBox1.Image == null) MessageBox.Show("Add image");




            if (comboList.Count != 0)
            {
                MessageBox.Show("select option in " + string.Join(" , ", comboList));
                comboList.Clear();
            }
            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value" + string.Join(" , ", termsList));
                termsList.RemoveRange(0, 9);
            }
            if (comboList.Count == 0 && termsList.Count == 0 && pictureBox1.Image != null)
            {
            insertdata();
            selectstuData();
            refreshdata();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (eventname.Text == "") listmsg("Event name , ");
            if (place.Text == "") listmsg("Place , ");
            if (handler.Text == "") listmsg("Event handler name , ");
            if (speaker.Text == "") listmsg("Speaker name .");
            if (stream.Text == "stream" && stream.SelectedItem == null) listcombo("stream");
            if (pictureBox1.Image == null) MessageBox.Show("Add image");



            if (comboList.Count != 0)
            {
                MessageBox.Show("select option in " + string.Join(" , ", comboList));
                comboList.Clear();
            }
            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value" + string.Join(" , ", termsList));
                termsList.Clear();
            }
            if(comboList.Count == 0 && termsList.Count == 0 && pictureBox1.Image != null)
            {
               // idfound();
                updatestuData();
                selectstuData();
                refreshdata();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            termsList.Clear();
            if (stuID.Text == "" || eventname.Text == "") listmsg("Event ID or name. ");
            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value in " + string.Join(" , ", termsList));
                termsList.Clear();
            }
            if (termsList.Count == 0)
            {
                //idfound();
                deletestuData();
                selectstuData();
                refreshdata();
             }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshdata();
            selectstuData();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            termsList.Clear();
            if (stuID.Text == "") listmsg("Event ID ");
            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value in " + string.Join(" , ", termsList));
                termsList.Clear();
            }
            if (termsList.Count == 0)
            {
                //idfound();
                viewdata();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }   
        }

        private void EVENT_Load(object sender, EventArgs e)
        {
            selectstuData();
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

        private void btn_stream_Click(object sender, EventArgs e)
        {
            label_stream.Visible = false;
            btn_stream.Visible = false;
            stream.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbldaynm.Visible = false;
            btndaynm.Visible = false;
            daynm.Visible = true;
        }
    }
}
