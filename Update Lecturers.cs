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
    public partial class Update_Lecturers : MetroFramework.Forms.MetroForm
    {
        public Update_Lecturers()
        {
            InitializeComponent();

            binddatagrid();

            SqlConnection con1;
            SqlCommand com1;

            con1 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_lecid.Items.Clear();

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
                scode.Items.Add(dr1["Subject_Code"].ToString());

            }
            con1.Close();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_lecid.Items.Clear();
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

        private void Update_Lecturers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingsystemDataSet7.Lecturer_Details' table. You can move, or remove it, as needed.
            this.lecturer_DetailsTableAdapter.Fill(this.gradingsystemDataSet7.Lecturer_Details);

        }

        private void btn_update_Click(object sender, EventArgs e)
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

                try
                {
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

        private void btn_clear2_Click(object sender, EventArgs e)
        {
            cmb_lecid.Items.Clear();
            lecname.Clear();
            scode.Items.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManageLecsSub choose = new ManageLecsSub();
            choose.Show();
            this.Close();
        }

        private void cmb_lecid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
