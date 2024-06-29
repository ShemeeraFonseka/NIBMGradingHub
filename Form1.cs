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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void tile_aboutUs_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.Show();
            this.Close();
        }

        private void tile_login_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
