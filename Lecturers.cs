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
    public partial class Lecturers : MetroFramework.Forms.MetroForm
    {
        public Lecturers()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            binddatagrid();

            SqlConnection con1;
            SqlCommand com1;

            con1 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            txt_scode.Items.Clear();
            scode.Items.Clear();
            con1.Open();
            com1 = con1.CreateCommand();
            com1.CommandType = CommandType.Text;
            com1.CommandText = "SELECT Subject_Code FROM Subjects";
            com1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            da1.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                txt_scode.Items.Add(dr1["Subject_Code"].ToString());
                scode.Items.Add(dr1["Subject_Code"].ToString());
            }
            con1.Close();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_lecid.Items.Clear();
            lecid.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Lecturer_ID FROM Lecturer_Details";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb_lecid.Items.Add(dr["Lecturer_ID"].ToString());
                lecid.Items.Add(dr["Lecturer_ID"].ToString());
            }
            con.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Lecturer_Details]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Lecturer_Details");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;

        }

        private void Lecturers_Load(object sender, EventArgs e)
        {

        }

        private void tile_delete_Click(object sender, EventArgs e)
        {
            if (lecid.Text.Length == 0)
            {
                MessageBox.Show("Lecturer ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Delete from Lecturer_Details where Lecturer = '" + cmb_lecid.Text + "'", con);
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

        private void tile_update_Click(object sender, EventArgs e)
        {
            if (cmb_lecid.Text.Length == 0)
            {
                MessageBox.Show("Lecturer ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (lecname.Text.Length == 0)
            {
                MessageBox.Show("Lecturer Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (lecname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Lecturer Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (scode.Text.Length == 0)
            {
                MessageBox.Show("Subject Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Update Lecturer_Details set  Lecturer_Name= '" + lecname.Text + "', Subject_Code = '" + scode.Text + "' where Lecturer_ID = '" + cmb_lecid.Text + "'", con);
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

        private void tile_insert_Click(object sender, EventArgs e)
        {
            if (txt_lecid.Text.Length == 0)
            {
                MessageBox.Show("Lecturer ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_lecname.Text.Length == 0)
            {
                MessageBox.Show("Lecturer Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_lecname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Lecturer Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_scode.Text.Length == 0)
            {
                MessageBox.Show("Subject Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

                string Lecturer_ID, Lecturer_Name, Subject_Code;

                Lecturer_ID = txt_lecid.Text;
                Lecturer_Name = txt_lecname.Text;
                Subject_Code = txt_scode.Text;

                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Lecturer_Details values (@a, @b, @c)", con);
                com.Parameters.AddWithValue("a", Lecturer_ID);
                com.Parameters.AddWithValue("b", Lecturer_Name);
                com.Parameters.AddWithValue("c", Subject_Code);

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
