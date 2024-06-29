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
    public partial class ExamUnit_Report : MetroFramework.Forms.MetroForm
    {
        public ExamUnit_Report()
        {
            InitializeComponent();
        }

        private void ExamUnit_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.ExamUnit_Details' table. You can move, or remove it, as needed.
            this.ExamUnit_DetailsTableAdapter.Fill(this.DataSet3.ExamUnit_Details);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewReports view = new viewReports();
            view.Show();
            this.Close();
        }
    }
}
