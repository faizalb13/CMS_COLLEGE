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
    public partial class UPDATE_FAC : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HUJL9OE\SQLEXPRESS2005;Initial Catalog=cmsclg;Integrated Security=True");
        SqlDataAdapter da;
        //SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        
        List<string> termsList = new List<string>();
        List<string> comboList = new List<string>();
        //Boolean emai, txt;
       // int a = 0 , rno = 0;
        MemoryStream ms;
        byte[] photo_aray;
        string wk1, wk2, wk3;
        Boolean emai =true;

        public UPDATE_FAC()
        {
            InitializeComponent();
        }

        //------------KEYPRESS-----------



        private void UPDATE_FAC_Load(object sender, EventArgs e)
        {
           
            selectstuData();
        }

        private void stuID_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }

  
        }
        void viewdata()
        {
            con.Open();
            SqlCommand cmmd = new SqlCommand("select * from fac_info where id='" + stuID.Text + "' or name = '" + name.Text + "'", con);
            SqlDataReader dr = cmmd.ExecuteReader();
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
                surname.Text = dr.GetValue(2).ToString().Replace(" ", String.Empty);
                name.Text = dr.GetValue(3).ToString().Replace(" ", String.Empty);
                fathername.Text = dr.GetValue(4).ToString().Replace(" ", String.Empty);
                day.Value =Convert.ToDateTime(dr.GetValue(5));
                label_gender.Text = dr.GetValue(6).ToString().Replace(" ", String.Empty);
                address.Text = dr.GetValue(7).ToString().Replace(" ", String.Empty);
                aadhar.Text = dr.GetValue(8).ToString().Replace(" ", String.Empty);
                phone.Text = dr.GetValue(9).ToString().Replace(" ", String.Empty);
                email.Text = dr.GetValue(10).ToString().Replace(" ", String.Empty);
                skill.Text = dr.GetValue(11).ToString().Replace(" ", String.Empty);
                lastplace.Text = dr.GetValue(13).ToString().Replace(" ", String.Empty);
                lastwork.Text = dr.GetValue(12).ToString().Replace(" ", String.Empty);
                work1.Text = dr.GetValue(14).ToString().Replace(" ", String.Empty);
                work2.Text = dr.GetValue(15).ToString().Replace(" ", String.Empty);
                salary.Text = dr.GetValue(16).ToString().Replace(" ", String.Empty);


            }
            con.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            viewdata();
            /*int rno = 0;
            if (stuID.Text == null) MessageBox.Show("Must Enter 'Sutdent ID' or 'Name'");
            else
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from fac_info where id = '" + stuID.Text + "' or name = '" + name.Text + "'", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "fac_info");



                if (ds.Tables[0].Rows.Count > 0)
                {
                    stuID.Text = ds.Tables[0].Rows[rno][0].ToString();
                    pictureBox1.Image = null;
                    if (ds.Tables[0].Rows[rno][1] != System.DBNull.Value)
                    {
                        photo_aray = (byte[])ds.Tables[0].Rows[rno][1];
                        MemoryStream ms = new MemoryStream(photo_aray);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    surname.Text = ds.Tables[0].Rows[rno][2].ToString();
                    name.Text = ds.Tables[0].Rows[rno][3].ToString();
                    fathername.Text = ds.Tables[0].Rows[rno][4].ToString();
                    day.SelectedItem = ds.Tables[0].Rows[rno][5].ToString();
                    month.SelectedItem = ds.Tables[0].Rows[rno][6].ToString();
                    year.SelectedItem = ds.Tables[0].Rows[rno][7].ToString();
                    lblgender.Text = ds.Tables[0].Rows[rno][8].ToString();
                    address.Text = ds.Tables[0].Rows[rno][9].ToString();
                    aadhar.Text = ds.Tables[0].Rows[rno][10].ToString();
                    phone.Text = ds.Tables[0].Rows[rno][11].ToString();
                    email.Text = ds.Tables[0].Rows[rno][12].ToString();
                    skill.Text = ds.Tables[0].Rows[rno][13].ToString();
                    lastwork.Text = ds.Tables[0].Rows[rno][14].ToString();
                    lastplace.Text = ds.Tables[0].Rows[rno][15].ToString();
                    work1.Text = ds.Tables[0].Rows[rno][16].ToString();
                    work2.Text = ds.Tables[0].Rows[rno][17].ToString();
                    work3.Text = ds.Tables[0].Rows[rno][18].ToString();





                }
                else
                    MessageBox.Show("No Records");
            }
            con.Close();*/
        }

        //----------END KEYPRESS----------------
        //****************************************************

        //
        //
        //-----------EXTRA METHOD---------------------
        //
        //

        //************** Update Method *************
        public DataSet updatestuData()
        {

            con.Open();
            SqlCommand cmdQuery = new SqlCommand("UPDATE fac_info SET photo = @photo , surname = '" + surname.Text + "', name ='" + name.Text + "', fathernm ='" + fathername.Text + "', DOB ='" + day.Text.ToString() + "', gender ='" + gender.SelectedItem.ToString() + "', address ='" + address.Text + "', aadhar ='" + aadhar.Text + "', phone ='" + phone.Text + "', email ='" + email.Text + "', skill ='" + skill.Text + "', lastwork ='" + lastwork.Text + "', lastclg ='" + lastplace.Text + "', exp1 ='" + work1.Text + "', exp2 ='" + work2.Text + "', exp3 ='" + salary.Text + "' ", con);
            conv_photo();
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            sda.Fill(cmsclgdatabase);
            con.Close();
            return cmsclgdatabase;
            
           


        }

        //**************End Update Method **********

        //************** Delete Method *************
        public DataSet deletestuData()
        {
           
            con.Open();
            SqlCommand cmdQuery = new SqlCommand("delete from fac_info where id = '" + stuID.Text + "' or name = '" + name.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            sda.Fill(cmsclgdatabase);
            con.Close();
            return cmsclgdatabase;
          

        }

        //**************End Delete Method **********

        //************** Select Method *************
        public void selectstuData()
        {

            con.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from fac_info", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        void loaddata()
        {
            con.Open();
            da = new SqlDataAdapter("select * from fac_info",con );
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet(); 
            da.Fill(ds, "fac_info");
            con.Close();
        }
       /* void showdata()
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                stuID.Text = ds.Tables[0].Rows[rno][0].ToString();
                surname.Text = ds.Tables[0].Rows[rno][2].ToString();
                name.Text = ds.Tables[0].Rows[rno][3].ToString();
                fathername.Text = ds.Tables[0].Rows[rno][4].ToString();
                day.SelectedItem = ds.Tables[0].Rows[rno][5].ToString();
                month.SelectedItem = ds.Tables[0].Rows[rno][6].ToString();
                year.SelectedItem = ds.Tables[0].Rows[rno][7].ToString();
               gender.SelectedItem = ds.Tables[0].
                address.Text = ds.Tables[0].Rows[rno][9].ToString();
                aadhar.Text = ds.Tables[0].Rows[rno][10].ToString();
                phone.Text = ds.Tables[0].Rows[rno][11].ToString();
                email.Text = ds.Tables[0].Rows[rno][12].ToString();
                skill.Text = ds.Tables[0].Rows[rno][13].ToString();
                lastwork.Text = ds.Tables[0].Rows[rno][14].ToString();
                lastplace.Text = ds.Tables[0].Rows[rno][15].ToString();
                work1.Text = ds.Tables[0].Rows[rno][16].ToString();
                work2.Text = ds.Tables[0].Rows[rno][17].ToString();
                work3.Text = ds.Tables[0].Rows[rno][18].ToString();

                
                if (ds.Tables[0].Rows[rno][1] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[rno][1];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
                MessageBox.Show("No Records");
        }  */
       
        //**************End SELECT Method **********

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
            label_gender.Visible = true;
            btn_gender.Visible = true;
            gender.Visible = false;
            gender.Text = "male / female";
            errorProvider1.Clear();
            aadhar.Text = "";
            phone.Text = "";
            email.Text = "";
            address.Text = "";
            skill.Text = "";
            lastwork.Text = "";
            lastplace.Text = "";
            work1.Text = "";
            work2.Text = "";
            salary.Text = "";
            pictureBox1.Image = null;
        }

        //
        //
        //-----------END EXTRA METHOD-------
        //
        //

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (stuID.Text != null || name.Text != null)
            {

                string message = "Do you want to Delete in " + name.Text.ToString() + stuID.Text.ToString();
                string title = "Delete Message";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                //msg Yes
                if (result == DialogResult.Yes)
                {

                    deletestuData();
                    selectstuData();
                    con.Close();
                    refreshdata();


                }
                //msg NO
                else
                {
                    MessageBox.Show("Not Delete.....");

                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (aadhar.Text.Length <= 11) { MessageBox.Show("you miss any digit in aadhar no.(length = " + aadhar.Text.Length + ")...."); }
           else if (phone.Text.Length <= 9) { MessageBox.Show("you miss any digit in Phone no.(length = " + phone.Text.Length + ")...."); }
            else
            {
                //experi1 = exp1.SelectedItem.ToString() + "," + work1.Text;
                //experi2 = exp2.SelectedItem.ToString() + "," + work2.Text;
                //experi3 = exp3.SelectedItem.ToString() + "," + work3.Text;
                string var_gender;
                if (gender.Visible == true) var_gender = gender.SelectedItem.ToString();
                else var_gender = label_gender.Text;
                if (stuID.Text != null || name.Text != null)
                {

                    string message = "Do you want to Update in id = " + stuID.Text.ToString() + " , Name = " + name.Text.ToString();
                    string title = "Update Message";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    //msg Yes
                    if (result == DialogResult.Yes)
                    {

                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        con.Open();

                        SqlCommand cmd = new SqlCommand("update fac_info set  photo=@photo,surname = '" + surname.Text + "', name ='" + name.Text + "', fathernm ='" + fathername.Text + "', DOB ='" + day.Value + "', gender ='" + var_gender + "', address ='" + address.Text + "', aadhar ='" + aadhar.Text + "', phone ='" + phone.Text + "', email ='" + email.Text + "', skill ='" + skill.Text + "', lastwork ='" + lastwork.Text + "', lastclg ='" + lastplace.Text + "', exp1 ='" + work1.Text + "', exp2 ='" + work2.Text + "', total salary ='" + float.Parse(salary.Text) + "' where id='" + stuID.Text + "'", con);
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@photo", img);
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            MessageBox.Show("Record Updated");
                            loaddata();
                        }
                        else
                            MessageBox.Show("Updation Failed");

                        //updatestuData();
                        selectstuData();
                        con.Close();
                        refreshdata();

                    }
                    //msg NO
                    else
                    {
                        MessageBox.Show("Not Update.....");

                    }
                }
            }
        }
        

        private void stuID_KeyUp(object sender, KeyEventArgs e)
        {

            char[] testarr = stuID.Text.ToCharArray();//stroe the every caharter u enter in the textbox

            if (testarr != null)
            {

                for (int i = 0; i < testarr.Length; i++)//to check the symbols in the given input through for loop
                {
                    //Isletter property of char is using to chek the special charcters

                    if (!char.IsDigit(testarr[i]))
                    {
                        errorProvider1.SetError(surname, "Symbols are not allowed");
                        MessageBox.Show("symbol are not allowed");
                        stuID.Clear();
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
            }
        }

        private void surname_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = surname.Text.ToCharArray();//stroe the every caharter u enter in the textbox

            if (testarr != null)
            {

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
        }

        private void name_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = name.Text.ToCharArray();//stroe the every caharter u enter in the textbox

            if (testarr != null)
            {
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
           
        }

        private void fathername_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = fathername.Text.ToCharArray();//stroe the every caharter u enter in the textbox
            if (testarr != null)
            {


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
        }

        private void aadhar_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = aadhar.Text.ToCharArray();//stroe the every caharter u enter in the textbox

            if (testarr != null)
            {

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
        }

        private void phone_KeyUp(object sender, KeyEventArgs e)
        {
            char[] testarr = phone.Text.ToCharArray();//stroe the every caharter u enter in the textbox

            if (testarr != null)
            {

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
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.stu_infoTableAdapter1.FillBy1(this.cmsDataset1.stu_info);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void insert_Click(object sender, EventArgs e)
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
            

            //-------COMBOBOX-------------

           
            if (gender.SelectedItem == null) listcombo("Gender");


            if (comboList.Count != 0)
            {
                MessageBox.Show("select option in " + string.Join(" , ", comboList));
                comboList.RemoveRange(0, 9);
            }

            //------EXPRINCE & WORK ---------
           
            if (work1.Text != null) wk1 = work1.Text;
            if (work2.Text != null) wk2 = work2.Text;
            if (salary.Text != null) wk3 = salary.Text;
            //string csvString = string.Join(",", wk1, wk2, wk3);

            //------image null----------
            Boolean imgA=true;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please , Select Image");
                imgA = false;
            }

            //if (aadhar.Text.Length != 12) { MessageBox.Show("you miss any digit in Phone no.(length = " + aadhar.Text.Length + ")...."); }
            //if (phone.Text.Length != 10) { MessageBox.Show("you miss any digit in Phone no.(length = " + phone.Text.Length + ")...."); }


            //-------INSERT DATA-----------

            if (comboList.Count == 0 && termsList.Count == 0 && gender.SelectedItem != null && imgA == true && aadhar.Text.Length == 12 && phone.Text.Length == 10)
            {

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                con.Open();
                cmd = new SqlCommand("insert into fac_info(photo,surname,name,fathernm,DOB,gender,address,aadhar,phone,email,skill,lastwork,lastclg,exp1,exp2,total_salary,paid_salary) values(@photo,'" + surname.Text + "','" + name.Text + "','" + fathername.Text + "','" + day.Value + "','" + gender.SelectedItem.ToString() + "','" + address.Text + "','" + aadhar.Text + "','" + phone.Text + "','" + email.Text + "','" + skill.Text + "','" + lastwork.Text + "','" + lastplace.Text + "','" + wk1 + "','" + wk2 + "','" + float.Parse(salary.Text) + "' , 0 )");
                cmd.Parameters.AddWithValue("@photo", img);
                cmd.Connection = con;
               
                int m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("insert data");
                    con.Close();
                    refreshdata();
                    selectstuData();
                   

                }
                else
                {
                    MessageBox.Show("not insert");
                    con.Close();
                }


            }
        }     //-----------ERROR LIST ----------------
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FINANCE_FAC()).Show();
        }

        private void btn_gender_Click(object sender, EventArgs e)
        {
            gender.Visible = true;
            label_gender.Visible = false;
            btn_gender.Visible = false;
        }
    }
}
