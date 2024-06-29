using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApp3
{
    public partial class verifyAccount : MetroFramework.Forms.MetroForm
    {
        string randomCode;
        public static String to;

        public verifyAccount()
        {
            InitializeComponent();
        }

        private void verifyAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Enter your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        enterVCode en = new enterVCode();
                        en.Show();
                        this.Close();
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
    }
}
