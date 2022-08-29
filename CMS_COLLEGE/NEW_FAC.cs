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
    public partial class NEW_FAC : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        string radio;
        List<string> termsList = new List<string>();
        List<string> comboList = new List<string>();
        Boolean imgA=true;
        Boolean emai = true;
        //int a = 0;
        MemoryStream ms;
       // byte[] photo_aray;
        string exwk1, exwk2, exwk3;

        public NEW_FAC()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
            con.Open();

            InitializeComponent();
        }

       

        private void NEW_FAC_Load(object sender, EventArgs e)
        {

        }
         
        //-----------Close window--------------
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //------END CLOSED WINDOW--------------

        //---------BTN VIEW------------
        private void button1_Click(object sender, EventArgs e)
        {
            UPDATE_FAC upfac = new UPDATE_FAC();
            upfac.ShowDialog();
        }


        //---------BROWSE IMG-----------
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

       

        //------------Submit Button------------




        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(surname.Text) && surname.Text == "Surname") listmsg("Surname    ");
            if (String.IsNullOrEmpty(name.Text) && name.Text == "Name") listmsg("Name  ");
            if (String.IsNullOrEmpty(fathername.Text) && fathername.Text == "Father name") listmsg("Father name ");
            if (String.IsNullOrEmpty(address.Text)) listmsg("Address    ");
            if (String.IsNullOrEmpty(aadhar.Text)) listmsg("Aadhar no   ");
            if (String.IsNullOrEmpty(phone.Text)) listmsg("Phone    ");
            if (String.IsNullOrEmpty(email.Text)) listmsg("Email    ");
            if (String.IsNullOrEmpty(skill.Text)) listmsg("Skill    ");
            if (String.IsNullOrEmpty(lbllastwork.Text)) listmsg("Last work    ");
            if (String.IsNullOrEmpty(lbllastcompany.Text)) listmsg("Last Place   ");
            if (String.IsNullOrEmpty(work1.Text)) listmsg("/n Work .");


            if (termsList.Count != 0)
            {
                MessageBox.Show("enter value" + string.Join(" , ", termsList));
                termsList.RemoveRange(0, 9);
            }


            //-----RADIO BUTTON---------
            if (male.Checked == true)
                radio = "male";
            else if (female.Checked == true)
                radio = "female";
            else
                MessageBox.Show("select any one option[male/female]");

            //-------COMBOBOX-------------

           
            if (exp1.SelectedItem == null) listcombo("Exprience");

            if (comboList.Count != 0)
            {
                MessageBox.Show("select option in " + string.Join(" , ", comboList));
                comboList.RemoveRange(0, 9);
            }

            //------EXPRINCE & WORK ---------
            if (exp1.SelectedItem != null && work1.Text != null) exwk1 = exp1.SelectedItem.ToString() + " : " + work1.Text;
            if (exp2.SelectedItem != null && work2.Text != null) exwk2 = exp2.SelectedItem.ToString() + " : " + work2.Text;
            if (exp3.SelectedItem != null && work3.Text != null) exwk3 = exp3.SelectedItem.ToString() + " : " + work3.Text;
            string csvString = string.Join(",", exwk1, exwk2, exwk3);

            //------image null----------
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please , Select Image");
                imgA = false;
            }

            if (aadhar.Text.Length != 12) { MessageBox.Show("you miss any digit in Phone no.(length = " + aadhar.Text.Length + ")...."); }
            if (phone.Text.Length != 10) { MessageBox.Show("you miss any digit in Phone no.(length = " + phone.Text.Length + ")...."); }


            //-------INSERT DATA-----------

            if (comboList.Count == 0 && termsList.Count == 0 && radio != null && imgA == true && aadhar.Text.Length == 12 && phone.Text.Length == 10)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                cmd = new SqlCommand("insert into fac_info(photo,surname,name,fathernm,BDay,gender,address,aadhar,phone,email,skill,lastwork,lastclg,exp1,exp2,exp3) values(@photo,'" + surname.Text + "','" + name.Text + "','" + fathername.Text + "','" + day.Text + "','" + radio + "','" + address.Text + "','" + aadhar.Text + "','" + phone.Text + "','" + email.Text + "','" + skill.Text + "','" + lastwork.Text + "','" + lastplace.Text + "','" + exwk1 + "','" + exwk2 + "','" + exwk3 + "')");
                cmd.Parameters.AddWithValue("@photo", img);
                cmd.Connection = con;
                int m = cmd.ExecuteNonQuery();
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
        }
        //-----------End Submit Button-----------

         

       




        //-----------VALIDATION------------------


        //-----------SURNAME-----------
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
         private void textsurname_TextChanged(object sender, EventArgs e)
         {
             symbolmsg(surname.Text, "Surname");
         }

         //-----------NAME-----------
         private void name_TextChanged(object sender, EventArgs e)
         {
             symbolmsg(name.Text, "Name");
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

         //-----------FATHER NAME-----------
         private void textfather_TextChanged(object sender, EventArgs e)
         {
             symbolmsg(fathername.Text, "Father name");
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

         //-----------AADHAR NO---------
         private void textaadhar_TextChanged(object sender, EventArgs e)
         {
             
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

         //-------PHONE NUMBER-----
         private void textphone_TextChanged(object sender, EventArgs e)
         {

         }
         private void phone_KeyPress(object sender, KeyPressEventArgs e)
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
         

         //-------------EMAIL VALIDATION---------------
         private void textemail_TextChanged(object sender, EventArgs e)
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



         //-----------END VALIDATION------------------

      
        //---------EXTRA METHODS----------------




         //-----------ERROR LIST ----------------
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
         //--------END ERROR LIST------

        //--------TEXT VALIDATION------
         void symbolmsg(string txt, string txtnm)
         {
             var regexItem = new Regex("^[a-zA-Z]*$");

             if (!regexItem.IsMatch(txt))
             {
                 MessageBox.Show("symbol & number not allow in " + txtnm);

             }
         }

         //--------NUMBER VALIDATION------
         void symbolmsg1(string txt, string txtnm)
         {
             var regexItem = new Regex("^[0-9]*$");

             if (!regexItem.IsMatch(txt))
             {
                 MessageBox.Show("symbol & Alphabet(a-z,A-Z) not allow in " + txtnm);

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

         private void surname_Enter(object sender, EventArgs e)
         {
             if (surname.Text == "Surname") surname.Clear();
         }

         private void name_Enter(object sender, EventArgs e)
         {
             if (name.Text == "Name") name.Clear();
         }

         private void fathername_Enter(object sender, EventArgs e)
         {
             if (fathername.Text == "Father name") fathername.Clear();
         }

       

        

        //---------END EXTRA METHODS----------------
    }
}
