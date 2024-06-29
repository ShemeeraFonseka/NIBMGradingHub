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
    public partial class Subject_Report : MetroFramework.Forms.MetroForm
    {
        public Subject_Report()
        {
            InitializeComponent();
        }

        private void Subject_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingsystemDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter1.Fill(this.gradingsystemDataSet.Subjects);
            // TODO: This line of code loads data into the 'DataSet1.Subjects' table. You can move, or remove it, as needed.
            this.SubjectsTableAdapter.Fill(this.DataSet1.Subjects);

            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            viewReports view = new viewReports();
            view.Show();
            this.Close();
        }
    }
}
