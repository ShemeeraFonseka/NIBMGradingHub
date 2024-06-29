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
    public partial class ManageLecsSub : MetroFramework.Forms.MetroForm
    {
        public ManageLecsSub()
        {
            InitializeComponent();
        }

        private void ManageLecsSub_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Choose_Task c = new Choose_Task();
            c.Show();
            this.Close();
        }

        private void btn_subjects_Click(object sender, EventArgs e)
        {
            Subjects s = new Subjects();
            s.Show();
            this.Close();
        }

        private void btn_subup_Click(object sender, EventArgs e)
        {
            Update_Subjects u = new Update_Subjects();
            u.Show();
            this.Close();
        }

        private void btn_lec_Click(object sender, EventArgs e)
        {
            Lecturers l = new Lecturers();
            l.Show();
            this.Close();
        }

        private void btn_lecup_Click(object sender, EventArgs e)
        {
            Update_Lecturers u = new Update_Lecturers();
            u.Show();
            this.Close();
        }
    }
}
