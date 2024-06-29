
namespace WindowsFormsApp3
{
    partial class Student_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tile_login = new MetroFramework.Controls.MetroTile();
            this.tile_cancel = new MetroFramework.Controls.MetroTile();
            this.cmb_ID = new MetroFramework.Controls.MetroComboBox();
            this.txt_pwd = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tile_login
            // 
            this.tile_login.ActiveControl = null;
            this.tile_login.Location = new System.Drawing.Point(100, 274);
            this.tile_login.Name = "tile_login";
            this.tile_login.Size = new System.Drawing.Size(185, 61);
            this.tile_login.TabIndex = 0;
            this.tile_login.Text = "Login";
            this.tile_login.UseSelectable = true;
            this.tile_login.Click += new System.EventHandler(this.tile_login_Click);
            // 
            // tile_cancel
            // 
            this.tile_cancel.ActiveControl = null;
            this.tile_cancel.Location = new System.Drawing.Point(380, 275);
            this.tile_cancel.Name = "tile_cancel";
            this.tile_cancel.Size = new System.Drawing.Size(189, 59);
            this.tile_cancel.TabIndex = 1;
            this.tile_cancel.Text = "Cancel";
            this.tile_cancel.UseSelectable = true;
            this.tile_cancel.Click += new System.EventHandler(this.tile_cancel_Click_1);
            // 
            // cmb_ID
            // 
            this.cmb_ID.FormattingEnabled = true;
            this.cmb_ID.ItemHeight = 23;
            this.cmb_ID.Location = new System.Drawing.Point(247, 29);
            this.cmb_ID.Name = "cmb_ID";
            this.cmb_ID.Size = new System.Drawing.Size(200, 29);
            this.cmb_ID.TabIndex = 4;
            this.cmb_ID.UseSelectable = true;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Lines = new string[0];
            this.txt_pwd.Location = new System.Drawing.Point(247, 98);
            this.txt_pwd.MaxLength = 32767;
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '\0';
            this.txt_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pwd.SelectedText = "";
            this.txt_pwd.Size = new System.Drawing.Size(208, 34);
            this.txt_pwd.TabIndex = 5;
            this.txt_pwd.UseSelectable = true;
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.cmb_ID);
            this.Controls.Add(this.tile_cancel);
            this.Controls.Add(this.tile_login);
            this.Name = "Student_Login";
            this.Text = "Student_Login";
            this.Load += new System.EventHandler(this.Student_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_login;
        private MetroFramework.Controls.MetroTile tile_cancel;
        private MetroFramework.Controls.MetroComboBox cmb_ID;
        private MetroFramework.Controls.MetroTextBox txt_pwd;
    }
}