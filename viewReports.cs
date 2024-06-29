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
    public partial class viewReports : MetroFramework.Forms.MetroForm
    {
        public viewReports()
        {
            InitializeComponent();
        }

        private void viewReports_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Choose_Task c = new Choose_Task();
            c.Show();
            this.Close();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Students_Report s = new Students_Report();
            s.Show();
            
        }

        private void btn_rsub_Click(object sender, EventArgs e)
        {
            Subject_Report s = new Subject_Report();
            s.Show();
            
        }

        private void btn_rmaek_Click(object sender, EventArgs e)
        {
            Student_Marks_Report m = new Student_Marks_Report();
            m.Show();
            
        }

        private void btn_rex_Click(object sender, EventArgs e)
        {
            ExamUnit_Report eu = new ExamUnit_Report();
            eu.Show();
            
        }

        private void btn_rlec_Click(object sender, EventArgs e)
        {
            Lecturer_Report l = new Lecturer_Report();
            l.Show();
            
        }
    }
}
