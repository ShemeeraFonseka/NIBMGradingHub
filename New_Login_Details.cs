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
    public partial class New_Login_Details : MetroFramework.Forms.MetroForm
    {
        public New_Login_Details()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void New_Login_Details_Load(object sender, EventArgs e)
        {

        }

        private void tile_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

            string Student_ID, Student_Name, Student_Mail;

            Student_ID = txt_stid.Text;
            Student_Name = txt_stname.Text;
            Student_Mail = txt_stmail.Text;

            con.Open();
            SqlCommand com = new SqlCommand();
            com = new SqlCommand("Insert into Student_Details values (@a, @b, @c)", con);
            com.Parameters.AddWithValue("a", Student_ID);
            com.Parameters.AddWithValue("b", Student_Name);
            com.Parameters.AddWithValue("c", Student_Mail);

            int a = com.ExecuteNonQuery();

            if (a == 1)
            {
                MessageBox.Show("Data added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Data cannot Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Connection = con;

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

            string Password, St_ID;

            Password = pwd_con.Text;
            St_ID = txt_stid.Text;

            con1.Open();
            SqlCommand com1 = new SqlCommand();
            com1 = new SqlCommand("Insert into password values (@a, @b)", con1);
            com1.Parameters.AddWithValue("a", Student_ID);
            com1.Parameters.AddWithValue("b", Password);


            int b = com1.ExecuteNonQuery();

            if (b == 1)
            {
                MessageBox.Show("Data added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Data cannot Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com1.Connection = con1;
        }
    }
}
