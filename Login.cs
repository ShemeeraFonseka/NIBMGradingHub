using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void tile_student_Click(object sender, EventArgs e)
        {
            Student_Login login = new Student_Login();
            login.Show();
            Close();
        }

        private void tile_examUnit_Click(object sender, EventArgs e)
        {
            ExamUnit_Login login = new ExamUnit_Login();
            login.Show();
            Close();
        }

        private void tile_newLogin_Click(object sender, EventArgs e)
        {
            New_Login_Details nlog = new New_Login_Details();
            nlog.Show();
            this.Close();
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
