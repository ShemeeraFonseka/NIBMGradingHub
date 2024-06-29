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
    public partial class Choose_Task : MetroFramework.Forms.MetroForm
    {
        public Choose_Task()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Choose_Task_Load(object sender, EventArgs e)
        {

        }

        private void tile_marks_Click(object sender, EventArgs e)
        {
            Manage_Marks marks = new Manage_Marks();
            marks.Show();
            this.Close();
        }

        private void tile_subject_Click(object sender, EventArgs e)
        {
            Subjects sub = new Subjects();
            sub.Show();
            this.Close();
        }

        private void tile_course_Click(object sender, EventArgs e)
        {
            Courses course = new Courses();
            course.Show();
            this.Close();
        }

        private void tile_lecturer_Click(object sender, EventArgs e)
        {
            Lecturers lec = new Lecturers();
            lec.Show();
            this.Close();
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            ExamUnit_Login login = new ExamUnit_Login();
            login.Show();
            this.Close();
        }

        private void tile_student_Click(object sender, EventArgs e)
        {
            Students st = new Students();
            st.Show();
            this.Close();
        }
    }
}
