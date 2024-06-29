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
    public partial class Exam_Unit : MetroFramework.Forms.MetroForm
    {
        public Exam_Unit()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_memid.Items.Clear();
            memid.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Member_ID FROM ExamUnit_Details";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb_memid.Items.Add(dr["Member_ID"].ToString());
                memid.Items.Add(dr["Member_ID"].ToString());
            }
            con.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [ExamUnit_Details]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("ExamUnit_Details");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;

        }

        private void Exam_Unit_Load(object sender, EventArgs e)
        {

        }

        private void tile_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete from ExamUnit_Details where Member_ID = '" + memid.Text + "'", con);
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

        private void tile_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

            string Member_ID, Member_Name, Member_Mail;

            Member_ID = txt_memid.Text;
            Member_Name = txt_memname.Text;
            Member_Mail = txt_memmail.Text;

            con.Open();
            SqlCommand com = new SqlCommand();
            com = new SqlCommand("Insert into ExamUnit_Details values (@a, @b, @c)", con);
            com.Parameters.AddWithValue("a", Member_ID);
            com.Parameters.AddWithValue("b", Member_Name);
            com.Parameters.AddWithValue("c", Member_Mail);

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

        private void tile_update_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Update ExamUnit_Details set  Member_Name= '" + memname.Text + "', Member_Mail = '" + memmail.Text + "' where Member_ID = '" + cmb_memid.Text + "'", con);
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
}
