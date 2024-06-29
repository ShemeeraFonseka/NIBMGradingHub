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
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp3
{
    public partial class New_Exam_Unit_Login : MetroFramework.Forms.MetroForm
    {
        string randomCode;
        public static String to;

        public New_Exam_Unit_Login()
        {
            InitializeComponent();

            txt_pwd.PasswordChar = '*';
            txt_conpwd.PasswordChar = '*';

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void New_Exam_Unit_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_eid.Text.Length == 0)
            {
                MessageBox.Show("Member ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_ename.Text.Length == 0)
            {
                MessageBox.Show("Member Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_ename.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Member Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Member Mail cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_pwd.Text.Length == 0)
            {
                MessageBox.Show("Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_conpwd.Text.Length == 0)
            {
                MessageBox.Show("Confirm Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_pwd.Text != txt_conpwd.Text)
            {
                MessageBox.Show("Confirm Password must same as the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_code.Text.Length == 0)
            {
                MessageBox.Show("Get the Verification Code to your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_code.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Verification Code cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_code.Text != randomCode)
            {
                MessageBox.Show("Incorrect code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

                string Member_ID, Member_Name, Member_Mail, Password;

                Member_ID = txt_eid.Text;
                Member_Name = txt_ename.Text;
                Member_Mail = txt_email.Text;
                Password = txt_conpwd.Text;

                try
                { 
                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into ExamUnit_Details values (@a, @b, @c,@d)", con);
                com.Parameters.AddWithValue("a", Member_ID);
                com.Parameters.AddWithValue("b", Member_Name);
                com.Parameters.AddWithValue("c", Member_Mail);
                com.Parameters.AddWithValue("d", Password);

                int a = com.ExecuteNonQuery();
                    if (a == 1)
                        MessageBox.Show(this, "Data save Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    com.Dispose();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_eid.Clear();
            txt_ename.Clear();
            txt_email.Clear();
            txt_pwd.Clear();
            txt_conpwd.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_pwd.PasswordChar == '*')
            {
                button3.BringToFront();
                txt_pwd.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_conpwd.PasswordChar == '*')
            {
                button5.BringToFront();
                txt_conpwd.PasswordChar = '\0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_pwd.PasswordChar == '\0')
            {
                button2.BringToFront();
                txt_pwd.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_conpwd.PasswordChar == '\0')
            {
                button4.BringToFront();
                txt_conpwd.PasswordChar = '*';
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (txt_eid.Text.Length == 0)
            {
                MessageBox.Show("Member ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_ename.Text.Length == 0)
            {
                MessageBox.Show("Member Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_ename.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Member Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Member Mail cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_pwd.Text.Length == 0)
            {
                MessageBox.Show("Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_conpwd.Text.Length == 0)
            {
                MessageBox.Show("Confirm Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_pwd.Text != txt_conpwd.Text)
            {
                MessageBox.Show("Confirm Password must same as the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    string from, pass, messageBody;
                    Random random = new Random();
                    randomCode = (random.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txt_email.Text).ToString();
                    from = "siyumifonseka2000@gmail.com";
                    pass = "fwvsxdikqeltrklx";
                    messageBody = "Your verification code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Verification code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code send Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
