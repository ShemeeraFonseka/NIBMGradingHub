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
using System.Configuration;


namespace WindowsFormsApp3
{
    public partial class Student_Login : MetroFramework.Forms.MetroForm
    {
        public static string textPassedStudentLogin;
        public Student_Login()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            cmb_ID.Text = Results.textPassedResults;

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_ID.Items.Clear();
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
                cmb_ID.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();
        }

        

        private void tile_login_Click(object sender, EventArgs e)
        {
            if (cmb_ID.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txt_pwd.Text.Length == 0)
            {
                MessageBox.Show("Please Enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con;
                SqlCommand com;

                con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");

                con.Open();
                com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT Password FROM password where Password='" + txt_pwd.Text + "'";
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);

                if (dt.Rows.Count > 0)

                {

                    MessageBox.Show("Login Success", "Informartion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textPassedStudentLogin = cmb_ID.Text;
                    Results choose = new Results();
                    choose.Show();
                    this.Close();
                }

                else

                {

                    MessageBox.Show("Login Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        
        private void tile_cancel_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

       

        private void Student_Login_Load(object sender, EventArgs e)
        {
            cmb_ID.Text = Results.textPassedResults;

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_ID.Items.Clear();
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
                cmb_ID.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();
        }

        private void tile_cancel_Click_1(object sender, EventArgs e)
        {
            Login win = new Login();
            win.Show();
            Close();
        }
    }
}
