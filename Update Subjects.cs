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
    public partial class Update_Subjects : MetroFramework.Forms.MetroForm
    {
        public Update_Subjects()
        {
            InitializeComponent();

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_scode.Items.Clear();
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

        private void Update_Subjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingsystemDataSet8.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.gradingsystemDataSet8.Subjects);

        }

        private void btn_update_Click(object sender, EventArgs e)
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

                try
                {
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
            cmb_scode.Items.Clear();
            sname.Clear();
            noofcre.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManageLecsSub choose = new ManageLecsSub();
            choose.Show();
            this.Close();
        }
    }
}
