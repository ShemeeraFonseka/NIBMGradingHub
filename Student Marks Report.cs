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
    public partial class Student_Marks_Report : MetroFramework.Forms.MetroForm
    {
        public Student_Marks_Report()
        {
            InitializeComponent();
        }

        private void Student_Marks_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMarks.Marks' table. You can move, or remove it, as needed.
            this.MarksTableAdapter.Fill(this.studentMarks.Marks);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewReports view = new viewReports();
            view.Show();
            this.Close();
        }
    }
}
