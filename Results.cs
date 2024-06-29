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
    public partial class Results : MetroFramework.Forms.MetroForm
    {
        public static string textPassedResults;
        public Results()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            st_ID.Text = Student_Login.textPassedStudentLogin;

        }

        private void Results_Load(object sender, EventArgs e)
        {
           
        }

        private void tile_results_Click(object sender, EventArgs e)
        {
            if (st_ID.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                binddatagrid();
                textPassedResults = st_ID.Text;
            }
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Marks] where Student_ID = '" + st_ID.Text + "'";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Marks");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;
        }
    }
}
