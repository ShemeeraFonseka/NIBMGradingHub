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
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Send_Email : MetroFramework.Forms.MetroForm
    {

        public Send_Email()
        {
            InitializeComponent();
        }

        private void Send_Email_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text.Length == 0)
            {
                MessageBox.Show("Member Mail cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            else
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = "siyumifonseka2000@gmail.com",
                        Password = "kandyraizysyncat"
                    }
                };

                MailAddress frommail = new MailAddress("siyumifonseka2000@gmail.com", "Shemeera Fonseka");
                MailAddress toemail = new MailAddress((txt_Email.Text).ToString());
                MailMessage message = new MailMessage()
                {
                    From = frommail,
                    Subject = txt_subject.Text,
                    Body = txt_body.Text,
                };

                message.To.Add(toemail);

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(Attachment1.Text);
                message.Attachments.Add(attachment);

                try
                {
                    client.Send(message);
                    MessageBox.Show("Sent Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string picpath = dlg.FileName.ToString();
                Attachment1.Text = picpath;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Choose_Task choose = new Choose_Task();
            choose.Show();
            this.Close(); 
        }
    }
}
