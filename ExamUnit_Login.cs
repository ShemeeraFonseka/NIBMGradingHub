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
    public partial class ExamUnit_Login : MetroFramework.Forms.MetroForm
    {
        public ExamUnit_Login()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            cmb_EUid.Items.Clear();
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
                cmb_EUid.Items.Add(dr["Member_id"].ToString());
            }
            con.Close();
        }

        string ID, email, pwd;

        private void tile_login_Click(object sender, EventArgs e)
        {
            if (cmb_EUid.Text.Length == 0)
            {
                MessageBox.Show("Member ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text.Length == 0)
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
                com.CommandText = "SELECT Password FROM EUpassword where Password='" + txt_password.Text + "'";
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);

                if (dt.Rows.Count > 0)

                {

                    MessageBox.Show("Login Success", "Informartion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Choose_Task choose = new Choose_Task();
                    choose.Show();
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
            Close();
        }

        private void ExamUnit_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
