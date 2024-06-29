
namespace WindowsFormsApp3
{
    partial class ExamUnit_Login
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
            this.cmb_EUid = new MetroFramework.Controls.MetroComboBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.tile_cancel = new MetroFramework.Controls.MetroTile();
            this.tile_login = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cmb_EUid
            // 
            this.cmb_EUid.FormattingEnabled = true;
            this.cmb_EUid.ItemHeight = 23;
            this.cmb_EUid.Location = new System.Drawing.Point(268, 72);
            this.cmb_EUid.Name = "cmb_EUid";
            this.cmb_EUid.Size = new System.Drawing.Size(272, 29);
            this.cmb_EUid.TabIndex = 0;
            this.cmb_EUid.UseSelectable = true;
            // 
            // txt_password
            // 
            this.txt_password.Lines = new string[] {
        "metroTextBox1"};
            this.txt_password.Location = new System.Drawing.Point(271, 151);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(268, 44);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "metroTextBox1";
            this.txt_password.UseSelectable = true;
            // 
            // tile_cancel
            // 
            this.tile_cancel.ActiveControl = null;
            this.tile_cancel.Location = new System.Drawing.Point(456, 268);
            this.tile_cancel.Name = "tile_cancel";
            this.tile_cancel.Size = new System.Drawing.Size(145, 51);
            this.tile_cancel.TabIndex = 2;
            this.tile_cancel.Text = "Cancel";
            this.tile_cancel.UseSelectable = true;
            this.tile_cancel.Click += new System.EventHandler(this.tile_cancel_Click);
            // 
            // tile_login
            // 
            this.tile_login.ActiveControl = null;
            this.tile_login.Location = new System.Drawing.Point(114, 271);
            this.tile_login.Name = "tile_login";
            this.tile_login.Size = new System.Drawing.Size(232, 59);
            this.tile_login.TabIndex = 3;
            this.tile_login.Text = "Login";
            this.tile_login.UseSelectable = true;
            this.tile_login.Click += new System.EventHandler(this.tile_login_Click);
            // 
            // ExamUnit_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_login);
            this.Controls.Add(this.tile_cancel);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.cmb_EUid);
            this.Name = "ExamUnit_Login";
            this.Text = "ExamUnit_Login";
            this.Load += new System.EventHandler(this.ExamUnit_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmb_EUid;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroTile tile_cancel;
        private MetroFramework.Controls.MetroTile tile_login;
    }
}