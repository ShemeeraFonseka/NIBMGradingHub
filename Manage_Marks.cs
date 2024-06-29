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
    public partial class Manage_Marks : MetroFramework.Forms.MetroForm
    {
        public Manage_Marks()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Manage_Marks_Load(object sender, EventArgs e)
        {

        }

        private void tile_insert_Click(object sender, EventArgs e)
        {
            MarkSheet marks = new MarkSheet();
            marks.Show();
            this.Close();
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            Choose_Task choose = new Choose_Task();
            choose.Show();
            this.Close();
        }

        private void tile_update_Click(object sender, EventArgs e)
        {
            Update_Details up = new Update_Details();
            up.Show();
            this.Close();
        }

        private void tile_delete_Click(object sender, EventArgs e)
        {
            Delete_Details del = new Delete_Details();
            del.Show();
            this.Close();
        }
    }
}
