﻿using System;
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
    public partial class enterVCodeEu : MetroFramework.Forms.MetroForm
    
    {
        string randomCode;

        public enterVCodeEu()
        {
            InitializeComponent();
        }

        private void enterVCodeEu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomCode = txt_code.Text;

            if (txt_code.Text.Length == 0)
            {
                MessageBox.Show("Get the Verification Code to your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_code.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Verification Code cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_code.Text != randomCode)
            {
                MessageBox.Show("Incorrect code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResetEu re = new ResetEu();
                re.Show();
                this.Close();
            }
        }
    }
}
