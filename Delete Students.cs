using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Delete_Students : MetroFramework.Forms.MetroForm
    {
        public Delete_Students()
        {
            InitializeComponent();

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");

            txt_id.Items.Clear();
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
                txt_id.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();

            SqlConnection con1;
            SqlCommand com1;

            con1 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");

            txt_sub.Items.Clear();
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
                txt_sub.Items.Add(dr1["Subject_Code"].ToString());
            }
            con1.Close();
        }

        private void Delete_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingsystemDataSet1.Marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter.Fill(this.gradingsystemDataSet1.Marks);
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


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_id.Text.Length==0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(txt_sub.Text.Length==0)
            {
                MessageBox.Show("Subject ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");

            try
            {
                
                con.Open();
                cmd = new SqlCommand("Delete from Marks where Student_ID = '" + txt_id.Text + "'and subject_ID = '"+txt_sub.Text+"'", con);
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
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            ManageMarks man = new ManageMarks();
            man.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_sub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}