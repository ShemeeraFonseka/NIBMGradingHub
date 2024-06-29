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
    public partial class Students_Report : MetroFramework.Forms.MetroForm
    {
        public Students_Report()
        {
            InitializeComponent();
        }

        private void Students_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Student_Details' table. You can move, or remove it, as needed.
            this.Student_DetailsTableAdapter.Fill(this.DataSet2.Student_Details);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            viewReports view = new viewReports();
            view.Show();
            this.Close();
        }
    }
}
