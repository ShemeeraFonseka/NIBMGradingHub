using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    
    public partial class verifyemail : MetroFramework.Forms.MetroForm
    {
        

        string randomCode;
        public static String to;

        

        public verifyemail()
        {
            InitializeComponent();

            
        }

        private void verifyemail_Load(object sender, EventArgs e)
        {
        }
            

        private void btn_otp_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random random = new Random();
            randomCode = (random.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txt_Email.Text).ToString();
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
                MessageBox.Show("Code send Successfully");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_code.Text).ToString())
            {
                to = txt_Email.Text;
                MessageBox.Show("Great");


            }

            else
            {
                MessageBox.Show("Wrong code");
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
