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
    public partial class Courses : MetroFramework.Forms.MetroForm
    {
        public Courses()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            binddatagrid();

            SqlConnection con2;
            SqlCommand com2;

            con2 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_ccode.Items.Clear();
            ccode.Items.Clear();
            con2.Open();
            com2 = con2.CreateCommand();
            com2.CommandType = CommandType.Text;
            com2.CommandText = "SELECT course_code FROM Courses";
            com2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(com2);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                cmb_ccode.Items.Add(dr2["course_code"].ToString());
                ccode.Items.Add(dr2["course_code"].ToString());
            }
            con2.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Courses]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Courses");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;

        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tile_update_Click(object sender, EventArgs e)
        {
            if (cmb_ccode.Text.Length == 0)
            {
                MessageBox.Show("Course Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cname.Text.Length == 0)
            {
                MessageBox.Show("Course Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Course Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Update Courses set  course_name= '" + cname.Text + "' where course_code = '" + cmb_ccode.Text + "'", con);
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
            if (cmb_ccode.Text.Length == 0)
            {
                MessageBox.Show("Course Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Delete from Courses where course_code = '" + ccode.Text + "'", con);
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

        private void tile_insert_Click(object sender, EventArgs e)
        {
            if (txt_ccode.Text.Length == 0)
            {
                MessageBox.Show("Course Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_cname.Text.Length == 0)
            {
                MessageBox.Show("Course Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_cname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Course Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

                string course_code, course_name;

                course_code = txt_ccode.Text;
                course_name = txt_cname.Text;

                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Courses values (@a, @b)", con);
                com.Parameters.AddWithValue("a", course_code);
                com.Parameters.AddWithValue("b", course_name);


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
    }
}
