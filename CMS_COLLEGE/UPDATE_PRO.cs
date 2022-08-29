using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.IO;
//using System.Drawing;
using System.Drawing.Imaging;

namespace CMS_COLLEGE
{
    public partial class UPDATE_PRO : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        //SqlDataAdapter da;


        List<string> termsList = new List<string>();
        List<string> comboList = new List<string>();
       Boolean emai;
        //int a = 0,rno = 0;
        MemoryStream ms;
        byte[] photo_aray;

        public UPDATE_PRO()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            //con.Open();

            InitializeComponent();

        }



        //        ------------KEYPRESS-----------

        private void stuID_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
      
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
          
        }

        private void fathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }

           
        }

        private void aadhar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] testarr = phone.Text.ToCharArray();//stroe the every caharter u enter in the textbox
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }



         

        }

        // ----------END KEYPRESS----------------
        //****************************************************






        // ---------extra method--------------




        //************** Upadte Method *************
        public DataSet updatestuData()
        {
            SqlConnection conString = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            conString.Open();
            SqlCommand cmdQuery = new SqlCommand("update stu_info set surname='" + surname.Text + "',name='" + name.Text + "',fathernm='" + fathername.Text + "', DOB = '" + day.Text.ToString() + "' ,gender = '" + gender.SelectedText.ToString() + "' ,address='" + address.Text + "',aadhar='" + aadhar.Text + "',phone='" + phone.Text + "',email='" + email.Text + "', course = '" + course.SelectedText.ToString() + "', jday = '" + jday.Text.ToString() + "', laststream='" + laststream.Text + "' where id = '" + stuID.Text + "' or name = '" + name.Text + "'", conString);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            sda.Fill(myfirstdata1);
            conString.Close();
            return myfirstdata1;

        }

        // **************End Update Method **********

     
        public void deletestuData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from stu_info where id = '" + stuID.Text + "' or name = '" + name.Text + "'", con);
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

        //  **************End Delete Method **********

     
        public void selectstuData()
        {

            //con.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from stu_info", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            con.Close();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        //        **************End SELECT Method **********

        //      ***********ERROR MSG**************
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
        //    ****************************************

        //  ***********PHOTO METHOD****************

        void conv_photo()
        {
            //    converting photo to binary data  
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

        void refreshdata()
        {
            stuID.Text = "";
            surname.Text = "";
            name.Text = "";
            fathername.Text = "";
            day.Value = DateTime.Now.Date;
            jday.Value = DateTime.Now.Date;
            label_gender.Visible = true;
            btn_gender.Visible = true;
            gender.Visible = false;
            label_gender.Text = "Gender :-";
            gender.Text = "male / female";
            aadhar.Text = "";
            phone.Text = "";
            label_stream.Visible = true;
            btn_stream.Visible = true;
            stream.Visible = false;
            course.Text = "Select Course";
            label_course.Visible = true;
            label_course.Text = "Course :-";
            label_stream.Text = "Stream :-";
            btn_course.Visible = true;
            course.Visible = false;
            stream.Text = "Select Stream";
            email.Text = "";
            address.Text = "";
            laststream.Text = "";
            pictureBox1.Image = null;
            photo_aray = null;
        }

        public void viewdata()
        {
            selectstuData();

            con.Open();
            cmd = new SqlCommand("select * from stu_info where id = '" + stuID.Text + "' or name = '" + name.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                stuID.Text = dr.GetValue(0).ToString().Replace(" ", String.Empty);
                pictureBox1.Image = null;
                if (dr.GetValue(1) != System.DBNull.Value)
                {
                    photo_aray = (byte[])dr.GetValue(1);
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                surname.Text = dr.GetValue(2).ToString().Replace(" ",String.Empty);
                name.Text = dr.GetValue(3).ToString().Replace(" ", String.Empty);
                fathername.Text = dr.GetValue(4).ToString().Replace(" ", String.Empty);
                day.Value = Convert.ToDateTime(dr.GetValue(5));
                label_gender.Text = dr.GetValue(6).ToString().Replace(" ", String.Empty);
                address.Text = dr.GetValue(7).ToString().Replace(" ", String.Empty);
                aadhar.Text = dr.GetValue(8).ToString().Replace(" ", String.Empty);
                phone.Text = dr.GetValue(9).ToString().Replace(" ", String.Empty);
                email.Text = dr.GetValue(10).ToString().Replace(" ", String.Empty);
                label_course.Text = dr.GetValue(11).ToString().Replace(" ", String.Empty);
                label_stream.Text = dr.GetValue(12).ToString().Replace(" ", String.Empty);
                jday.Value = Convert.ToDateTime(dr.GetValue(13));
                laststream.Text = dr.GetValue(14).ToString().Replace(" ", String.Empty);


               

            }
            dr.Close();
            con.Close();

        }
       



        // ******************************************

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //************  btn UPDATE  **********

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stuID.Text) && String.IsNullOrEmpty(name.Text)) MessageBox.Show("Must Enter 'Sutdent ID' or 'Name'");
          
            string var_course;
            if (course.Visible == true) var_course = course.SelectedItem.ToString();
            else var_course = label_course.Text;
            string var_stream;
            if (stream.Visible == true) var_stream = stream.SelectedItem.ToString();
            else var_stream = label_stream.Text;
            string var_gender;
            if (gender.Visible == true) var_gender = gender.SelectedItem.ToString();
            else var_gender = label_gender.Text;

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
                        cmd = new SqlCommand("update stu_info set  photo = @photo,surname=@surname,name=@name,fathernm=@fathernm,DOB=@day , gender=@gender  ,address=@address,aadhar=@aadhar,phone=@phone,email=@email,stream=@stream ,course=@course ,jday=@jday, laststream=@lastst where id = '" + stuID.Text + "' or name = '" + name.Text + "' ", con);
                        cmd.Parameters.AddWithValue("@id", stuID.Text);
                        cmd.Parameters.AddWithValue("@photo", img);
                        cmd.Parameters.AddWithValue("@surname", surname.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@fathernm", fathername.Text);
                        cmd.Parameters.AddWithValue("@day", day.Value);
                        cmd.Parameters.AddWithValue("@gender", var_gender);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@aadhar", aadhar.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@stream", var_stream);
                        cmd.Parameters.AddWithValue("@course", var_course);
                        cmd.Parameters.AddWithValue("@jday", jday.Value);
                        cmd.Parameters.AddWithValue("@lastst", laststream.Text);
                       
                         cmd.Connection = con;
                        int m = cmd.ExecuteNonQuery();
                        con.Close();
                        if (m > 0) MessageBox.Show("Update Done...");
                        else MessageBox.Show("Update Fail ..!!!!");
                       
                   
                   // updatestuData();


                }
                selectstuData();

                refreshdata();

            }
            //msg NO
            else
            {
                MessageBox.Show("Not update.....");
                selectstuData();

                refreshdata();

            }
        }




        private void btndelete_Click(object sender, EventArgs e)
        {
            if (stuID.Text != null || name.Text != null)
            {

                string message = "Do you want to Delete in " + name.Text.ToString() + stuID.Text.ToString();
                string title = "Delete Message";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                // msg Yes
                if (result == DialogResult.Yes)
                {

                    deletestuData();


                    selectstuData();
                    refreshdata();

                }
                //  msg NO
                else
                {
                    MessageBox.Show("Not Delete.....");

                }
            }
        }

        private void UPDATE_PRO_Load(object sender, EventArgs e)
        {
            
        }

      
        private void btnviewall_Click(object sender, EventArgs e)
        {
            viewdata();
          

        }

       

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            selectstuData();
            refreshdata();
        }

        

        private void UPDATE_PRO_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmsclgdatabase.course_info' table. You can move, or remove it, as needed.
          
            
            selectstuData();
            refreshdata();
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




        //
        //**************************** INSERT DATA******************** 
        //

        private void insert_Click(object sender, EventArgs e)
        {
            //------NULL VALUE------------
            if (String.IsNullOrEmpty(surname.Text) && surname.Text == "surname") listmsg("surname");

            if (String.IsNullOrEmpty(name.Text) && name.Text == "name") listmsg("name");
            if (String.IsNullOrEmpty(fathername.Text) && fathername.Text == "father name") listmsg("father");
            if (String.IsNullOrEmpty(address.Text)) listmsg("address");
            if (String.IsNullOrEmpty(aadhar.Text)) listmsg("aadhar no");
            if (String.IsNullOrEmpty(phone.Text)) listmsg("phone");
            if (String.IsNullOrEmpty(email.Text)) listmsg("email");
            if (day.Text == null) listcombo(" BOD ,");
            if (jday.Text == null) listcombo(" Join date,");

            if (String.IsNullOrEmpty(laststream.Text)) listmsg("laststream");



            ////-----RADIO BUTTON---------


            //else
            //    MessageBox.Show("select any one option[male/female]");

            //-------COMBOBOX-------------

            
           
            if (gender.SelectedItem == null) listcombo(" Gender ,");
            if (course.SelectedItem == null) listcombo(" course ,");
            if (stream.SelectedItem == null) listcombo(" stream ,");
           
            
            //  if (pictureBox1.Image == null) listcombo("Image..");




            if (aadhar.Text.Length != 12) { MessageBox.Show("you miss any digit in Phone no.(length = " + aadhar.Text.Length + ")...."); }
            if (phone.Text.Length != 10) { MessageBox.Show("you miss any digit in Phone no.(length = " + phone.Text.Length + ")...."); }



            //-------INSERT DATA-----------

            if (comboList.Count != 0)
            {
                MessageBox.Show("select option in " + string.Join(" , ", comboList));
                comboList.Clear();
            }
            else if (termsList.Count != 0)
            {
                MessageBox.Show("enter value" + string.Join(" , ", termsList));
                termsList.RemoveRange(0, 9);
            }
           
            //else if (aadhar.Text.Length == 12) MessageBox.Show("aadhar error");
            //else if (phone.Text.Length == 10) MessageBox.Show("phone error");
            else if (emai == true) MessageBox.Show("emai error");
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                con.Open();
                cmd = new SqlCommand("insert into stu_info(photo,surname,name,fathernm,DOB,gender,address,aadhar,phone,email,course,stream,jday,laststream,paidfee) values(@photo,'" + surname.Text + "','" + name.Text + "','" + fathername.Text + "','" + day.Value + "','" + gender.SelectedItem + "','" + address.Text + "','" + aadhar.Text + "','" + phone.Text + "','" + email.Text + "','" + course.SelectedItem + "','" + stream.SelectedItem + "','" + jday.Value + "','" + laststream.Text + "',0)", con);
                cmd.Parameters.AddWithValue("@photo", img);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                con.Close();
                if (m > 0)
                {
                    MessageBox.Show("insert data");
                    refreshdata();
                    selectstuData();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("not insert");
                    con.Close();
                }

            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][.\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.email, "invalid email");
                emai = false;
                return;
            }
        }

        private void stream_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
             
            SqlCommand cmmd = new SqlCommand("select c_name from course where s_name='"+stream.SelectedItem.ToString()+"'", con);
            SqlDataReader dr = cmmd.ExecuteReader();
            while (dr.Read())
            {
                //s_id = int.Parse(dr.GetValue(0).ToString());
                course.Items.Add(dr.GetValue(0).ToString());

            }
            con.Close();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FINANCE_STU()).Show();
        }

        private void btn_stream_Click(object sender, EventArgs e)
        {
            stream.Visible = true;
            label_stream.Visible = false;
            btn_stream.Visible = false;
        }

        private void btn_course_Click(object sender, EventArgs e)
        {

            course.Visible = true;
            label_course.Visible = false;
            btn_course.Visible = false;
        }

        private void btn_gender_Click(object sender, EventArgs e)
        {
            gender.Visible = true;
            label_gender.Visible = false;
            btn_gender.Visible = false;
        }

   
       

      



        //************ END btn UPDATE  **********

    }

}