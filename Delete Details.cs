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
    public partial class Delete_Details : MetroFramework.Forms.MetroForm
    {
        public Delete_Details()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            st_ID.Items.Clear();
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
                st_ID.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Marks]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Marks");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;

        }

        private void Delete_Details_Load(object sender, EventArgs e)
        {

        }

        private void tile_delete_Click(object sender, EventArgs e)
        {
            if (st_ID.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Delete from Marks where Student_ID = '" + st_ID.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(this, "Data delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binddatagrid();
                }
                else
                {
                    MessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
            }
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            Manage_Marks man = new Manage_Marks();
            man.Show();
            this.Close();
        }

        private void tile_clear_Click(object sender, EventArgs e)
        {
            st_ID.Items.Clear();
        }
    }
}
