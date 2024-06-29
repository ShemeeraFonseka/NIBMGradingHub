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

namespace WindowsFormsApp3
{
    public partial class resetpass : MetroFramework.Forms.MetroForm
    {
        public resetpass()
        {
            InitializeComponent();
            txt_pwd.PasswordChar = '*';
            txt_conpwd.PasswordChar = '*';

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            comboBox1.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Student_ID FROM Student_Details";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();
        }

        private void resetpass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pwd.Text.Length == 0)
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
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");

                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update Student_Details set Password = '" + txt_pwd.Text + "' where Student_ID = '" + comboBox1.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show(this, "Login with your new Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Student_Login st = new Student_Login();
                        st.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show(this, "Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }

                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_pwd.PasswordChar == '*')
            {
                button3.BringToFront();
                txt_pwd.PasswordChar = '\0';
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_conpwd.PasswordChar == '*')
            {
                button5.BringToFront();
                txt_conpwd.PasswordChar = '\0';
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
    }
}
