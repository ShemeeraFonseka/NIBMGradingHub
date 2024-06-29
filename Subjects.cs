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
    public partial class Subjects : MetroFramework.Forms.MetroForm
    {
        public Subjects()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_scode.Items.Clear();
            scode.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Subject_Code FROM Subjects";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb_scode.Items.Add(dr["Subject_Code"].ToString());
                scode.Items.Add(dr["Subject_Code"].ToString());
            }
            con.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Subjects]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Subjects");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;
        }

        private void Subjects_Load(object sender, EventArgs e)
        {

        }

        private void tile_insert_Click(object sender, EventArgs e)
        {
            if (txt_scode.Text.Length == 0)
            {
                MessageBox.Show("Subject Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_sname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Subject Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_sname.Text.Length == 0)
            {
                MessageBox.Show("Subject Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_noofcre.Text.Length == 0)
            {
                MessageBox.Show("Number of Credits cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_noofcre.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Number of Credits cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

                string Subject_Code, Subject_Name, no_of_credits;

                Subject_Code = txt_scode.Text;
                Subject_Name = txt_sname.Text;
                no_of_credits = txt_noofcre.Text;

                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Subjects values (@a, @b, @c)", con);
                com.Parameters.AddWithValue("a", Subject_Code);
                com.Parameters.AddWithValue("b", Subject_Name);
                com.Parameters.AddWithValue("c", no_of_credits);

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
            if (cmb_scode.Text.Length == 0)
            {
                MessageBox.Show("Subject Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Subject Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sname.Text.Length == 0)
            {
                MessageBox.Show("Subject Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (noofcre.Text.Length == 0)
            {
                MessageBox.Show("Number of Credits cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (noofcre.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Number of Credits cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Update Subjects set  Subject_Name= '" + sname.Text + "', no_of_credits = '" + noofcre.Text + "' where Subject_Code = '" + cmb_scode.Text + "'", con);
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
            if (scode.Text.Length == 0)
            {
                MessageBox.Show("Subject Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Delete from Subjects where Subject_Code = '" + cmb_scode.Text + "'", con);
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

        private void tile_clear1_Click(object sender, EventArgs e)
        {
            txt_scode.Clear();
            txt_sname.Clear();
            txt_noofcre.Clear();
        }

        private void tile_clear2_Click(object sender, EventArgs e)
        {
            cmb_scode.Items.Clear();
            sname.Clear();
            noofcre.Clear();
        }

        private void tile_clear3_Click(object sender, EventArgs e)
        {
            scode.Items.Clear();
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            Choose_Task choose = new Choose_Task();
            choose.Show();
            this.Close();
        }
    }
}
