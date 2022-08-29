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
//using System.Drawing;
using System.Drawing.Imaging; 

namespace CMS_COLLEGE
{
    
    public partial class NEW_STU : Form
    {
       SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            
        SqlCommand cmd;
      //  SqlDataAdapter da;
        string radio= null;
        List<string> termsList = new List<string>();
        List<string> comboList = new List<string>();
        Boolean emai = true;
        //int a=0;
       // MemoryStream ms;
       

        public NEW_STU()
        {

            InitializeComponent();
            surname.KeyPress += new KeyPressEventHandler(textsurname_KeyPress);
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void button2_Click(object sender, EventArgs e)
        {
            
          

            //------NULL VALUE------------
            if (String.IsNullOrEmpty(surname.Text) || surname.Text == "surname") listmsg("surname\n");

            if (String.IsNullOrEmpty(name.Text) || name.Text == "name") listmsg("name\n");
            if (String.IsNullOrEmpty(fathername.Text) || fathername.Text == "father name") listmsg("father\n");
            if (String.IsNullOrEmpty(address.Text)) listmsg("address\n");
            if (String.IsNullOrEmpty(aadhar.Text)) listmsg("aadhar no\n");
            if (String.IsNullOrEmpty(phone.Text)) listmsg("phone\n");
            if (String.IsNullOrEmpty(email.Text)) listmsg("email\n");

            if (String.IsNullOrEmpty(laststream.Text)) listmsg("laststream\n");

           

            ////-----RADIO BUTTON---------

            
            //else
            //    MessageBox.Show("select any one option[male/female]");

            //-------COMBOBOX-------------

            if (day.Value == DateTime.Now.Date) listcombo("DOB \n");
            if (gender.SelectedItem == null) listcombo("Gender\n");
            if (course.SelectedItem == null) listcombo("Course\n");
            if (stream.SelectedItem == null) listcombo("Stream\n");
            if (jday.Value == DateTime.Now.Date) listcombo("Join day\n");
           
          //  if (pictureBox1.Image == null) listcombo("Image..");

            
            

            if (aadhar.Text.Length != 12) { MessageBox.Show("you miss any digit in Aadhar no.(length = " + aadhar.Text.Length + ")...."); }
            if (phone.Text.Length != 10) { MessageBox.Show("you miss any digit in Phone no.(length = " + phone.Text.Length + ")...."); }
            


            //-------INSERT DATA-----------

            if (comboList.Count != 0)
            {
                MessageBox.Show("select option in \n" + string.Join(" , ", comboList));
                comboList.Clear();
            }
            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value in\n" + string.Join(" , ", termsList));
                termsList.Clear();
            }
          //  else if (male.Checked != true && female.Checked != true) MessageBox.Show("select male or female....");
            //else if (aadhar.Text.Length == 12) MessageBox.Show("aadhar error");
            //else if (phone.Text.Length == 10) MessageBox.Show("phone error");
            else if (emai == true) MessageBox.Show("emai error");
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                con.Open();
                cmd = new SqlCommand("insert into stu_info(photo,surname,name,fathernm,BDay,gender,address,aadhar,phone,email,course,stream,jday,laststream) values(@photo,'" + surname.Text + "','" + name.Text + "','" + fathername.Text + "','" + day.Text + "','" + radio + "','" + address.Text + "','" + aadhar.Text + "','" + phone.Text + "','" + email.Text + "','" + course.SelectedItem + "','" + stream.SelectedItem + "','" + jday.Text + "','" + laststream.Text + "')",con);
               // methodphoto();
                cmd.Parameters.AddWithValue("@photo", img);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
                con.Close();
                if (m > 0)
                {
                    MessageBox.Show("insert data");

                    con.Close();

                }
                else
                {
                    MessageBox.Show("not insert");
                    con.Close();
                }
            }
            refreshdata();
        }


        public void methodphoto()
        {
           
               
            
        }

       
       
        private void refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

        private void btnview_Click(object sender, EventArgs e)
        {
            (new UPDATE_PRO()).Show();
        }

        private void stream_SelectedIndexChanged(object sender, EventArgs e)
        {

            course.Items.Clear();
            coursedata();
        }

     

        //
      //*********************** EVENTS*********************************
        //

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "surname") surname.Clear();

        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "name") name.Clear();
        }

        private void fathername_Enter(object sender, EventArgs e)
        {
            if (fathername.Text == "father name") fathername.Clear();
        }


        private void surname_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = surname.Text.ToCharArray();//stroe the every caharter u enter in the textbox


            for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
            {
                //Isletter property of char is using to chek the special charcters

                if (!char.IsLetter(testarr[i]))
                {
                    errorProvider1.SetError(surname, "Symbols are not allowed");
                    MessageBox.Show("symbol are not allowed");
                    surname.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void name_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = name.Text.ToCharArray();//stroe the every caharter u enter in the textbox


            for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
            {
                //Isletter property of char is using to chek the special charcters

                if (!char.IsLetter(testarr[i]))
                {
                    errorProvider1.SetError(name, "Symbols are not allowed");
                    MessageBox.Show("symbol are not allowed");
                    name.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void fathername_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = fathername.Text.ToCharArray();//stroe the every caharter u enter in the textbox


            for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
            {
                //Isletter property of char is using to chek the special charcters

                if (!char.IsLetter(testarr[i]))
                {
                    errorProvider1.SetError(fathername, "Symbols are not allowed");
                    MessageBox.Show("symbol are not allowed");
                    fathername.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void aadhar_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = aadhar.Text.ToCharArray();//stroe the every caharter u enter in the textbox


            for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
            {
                //Isletter property of char is using to chek the special charcters

                if (!char.IsDigit(testarr[i]))
                {
                    errorProvider1.SetError(aadhar, "Symbols are not allowed");
                    MessageBox.Show("symbol are not allowed");
                    aadhar.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void phone_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = phone.Text.ToCharArray();//stroe the every caharter u enter in the textbox


            for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
            {
                //Isletter property of char is using to chek the special charcters

                if (!char.IsDigit(testarr[i]))
                {
                    errorProvider1.SetError(phone, "Symbols are not allowed");
                    MessageBox.Show("symbol are not allowed");
                    phone.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }



        private void textsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar);
            e.Handled = char.IsSymbol(e.KeyChar) && char.IsControl(e.KeyChar);
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }

        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar);
            e.Handled = char.IsSymbol(e.KeyChar) && char.IsControl(e.KeyChar);
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }

        }

        private void textfather_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar);
            e.Handled = char.IsSymbol(e.KeyChar) && char.IsControl(e.KeyChar);
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }

        }

        private void textlaststream_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar);
            e.Handled = char.IsSymbol(e.KeyChar) && char.IsControl(e.KeyChar);
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
            }
            else
            {
                e.Handled = false; //Reject the input
            }
        }

        private void textaadhar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            e.Handled = char.IsSymbol(e.KeyChar) && char.IsControl(e.KeyChar);
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
            
        }




        void refreshdata()
        {
          
            surname.Text = "surname";
            name.Text = "name";
            fathername.Text = "father name";
            day.Value = DateTime.Now.Date;
           gender.Text = "male/female";
           gender.SelectedItem = null;
            aadhar.Text = "";
            jday.Value = DateTime.Now.Date;
            phone.Text = "";
            course.SelectedItem = null;
            stream.SelectedItem = null;
            email.Text = "";
            address.Text = "";
            laststream.Text = "";
            pictureBox1.Image = null;
           
        }

        private void NEW_STU_Load(object sender, EventArgs e)
        {
            streamdata();
        }
        void streamdata()
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select s_name from stream_info", con);
            SqlDataReader dr = cmmd.ExecuteReader();
            while (dr.Read())
            {
                stream.Items.Add(dr.GetValue(0).ToString());

            }
            con.Close();


        }
        void coursedata()
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select c_name from course where s_name = '" + stream.SelectedItem.ToString() + "'", con);
            SqlDataReader dr = cmmd.ExecuteReader();

            while (dr.Read())
            {
                course.Items.Add(dr.GetValue(0).ToString());
               
            }
            con.Close();

        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select fee from course where c_name = '" + course.SelectedItem.ToString() + "'", con);
            SqlDataReader dr = cmmd.ExecuteReader();

            while (dr.Read())
            {
                totfee.Text = dr.GetValue(0).ToString();
            }
            con.Close();
            
        }
    }
}
