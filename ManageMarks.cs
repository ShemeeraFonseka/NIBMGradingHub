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
    public partial class ManageMarks : MetroFramework.Forms.MetroForm
    {
        public ManageMarks()
        {
            InitializeComponent();
        }

        private void ManageMarks_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Choose_Task c = new Choose_Task();
            c.Show();
            this.Close();
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            MarkSheet m = new MarkSheet();
            m.Show();
            this.Close();
        }

        private void btnUpMark_Click(object sender, EventArgs e)
        {
            Update_Details u = new Update_Details();
            u.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete_Students d = new Delete_Students();
            d.Show();
            this.Close();
        }
    }
}
