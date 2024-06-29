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


namespace WindowsFormsApp3
{
    public partial class Students : MetroFramework.Forms.MetroForm
    {
        public Students()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            WindowState = FormWindowState.Maximized;

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_stid1.Items.Clear();
            stid.Items.Clear();
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
                cmb_stid1.Items.Add(dr["Student_ID"].ToString());
                stid.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Student_Details]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Student_Details");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;

        }

        private void Students_Load(object sender, EventArgs e)
        {
            
        }

        private void tile_insert_Click(object sender, EventArgs e)
        {
            if (txt_stid.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_stname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Student Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_stname.Text.Length == 0)
            {
                MessageBox.Show("Student Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_stmail.Text.Length == 0)
            {
                MessageBox.Show("Student Mail cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txt_stmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                    binddatagrid();
                }
                else
                {
                    MessageBox.Show("Data cannot Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                com.Connection = con;
            }
        }

        private void tile_update_Click(object sender, EventArgs e)
        {
            if (cmb_stid1.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (stname.Text.Length == 0)
            {
                MessageBox.Show("Student Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (stname.Text.Length == 0)
            {
                MessageBox.Show("Student Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (st_mail.Text.Length == 0)
            {
                MessageBox.Show("Student Mail cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txt_stmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Update Student_Details set  Student_Name= '" + stname.Text + "', Student_Mail = '" + st_mail.Text + "' where Student_ID = '" + cmb_stid1.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binddatagrid();
                }
                else
                    MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
        }

        private void tile_delete_Click(object sender, EventArgs e)
        {
            if (stid.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Delete from Student_Details where Student_ID = '" + stid.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(this, "Data delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binddatagrid();
                }
                else
                    MessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            Choose_Task task = new Choose_Task();
            task.Show();
            this.Close();
        }
    }
}
