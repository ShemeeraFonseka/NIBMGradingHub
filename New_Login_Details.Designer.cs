
namespace WindowsFormsApp3
{
    partial class New_Login_Details
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
            this.txt_stid = new MetroFramework.Controls.MetroTextBox();
            this.txt_stname = new MetroFramework.Controls.MetroTextBox();
            this.txt_stmail = new MetroFramework.Controls.MetroTextBox();
            this.ped = new MetroFramework.Controls.MetroTextBox();
            this.pwd_con = new MetroFramework.Controls.MetroTextBox();
            this.tile_save = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txt_stid
            // 
            this.txt_stid.Lines = new string[] {
        "metroTextBox1"};
            this.txt_stid.Location = new System.Drawing.Point(115, 72);
            this.txt_stid.MaxLength = 32767;
            this.txt_stid.Name = "txt_stid";
            this.txt_stid.PasswordChar = '\0';
            this.txt_stid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stid.SelectedText = "";
            this.txt_stid.Size = new System.Drawing.Size(145, 20);
            this.txt_stid.TabIndex = 0;
            this.txt_stid.Text = "metroTextBox1";
            this.txt_stid.UseSelectable = true;
            // 
            // txt_stname
            // 
            this.txt_stname.Lines = new string[] {
        "metroTextBox2"};
            this.txt_stname.Location = new System.Drawing.Point(115, 111);
            this.txt_stname.MaxLength = 32767;
            this.txt_stname.Name = "txt_stname";
            this.txt_stname.PasswordChar = '\0';
            this.txt_stname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stname.SelectedText = "";
            this.txt_stname.Size = new System.Drawing.Size(145, 20);
            this.txt_stname.TabIndex = 1;
            this.txt_stname.Text = "metroTextBox2";
            this.txt_stname.UseSelectable = true;
            // 
            // txt_stmail
            // 
            this.txt_stmail.Lines = new string[] {
        "metroTextBox3"};
            this.txt_stmail.Location = new System.Drawing.Point(115, 156);
            this.txt_stmail.MaxLength = 32767;
            this.txt_stmail.Name = "txt_stmail";
            this.txt_stmail.PasswordChar = '\0';
            this.txt_stmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stmail.SelectedText = "";
            this.txt_stmail.Size = new System.Drawing.Size(145, 20);
            this.txt_stmail.TabIndex = 2;
            this.txt_stmail.Text = "metroTextBox3";
            this.txt_stmail.UseSelectable = true;
            // 
            // ped
            // 
            this.ped.Lines = new string[] {
        "metroTextBox4"};
            this.ped.Location = new System.Drawing.Point(115, 195);
            this.ped.MaxLength = 32767;
            this.ped.Name = "ped";
            this.ped.PasswordChar = '\0';
            this.ped.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ped.SelectedText = "";
            this.ped.Size = new System.Drawing.Size(145, 20);
            this.ped.TabIndex = 3;
            this.ped.Text = "metroTextBox4";
            this.ped.UseSelectable = true;
            // 
            // pwd_con
            // 
            this.pwd_con.Lines = new string[] {
        "metroTextBox5"};
            this.pwd_con.Location = new System.Drawing.Point(115, 245);
            this.pwd_con.MaxLength = 32767;
            this.pwd_con.Name = "pwd_con";
            this.pwd_con.PasswordChar = '\0';
            this.pwd_con.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwd_con.SelectedText = "";
            this.pwd_con.Size = new System.Drawing.Size(145, 20);
            this.pwd_con.TabIndex = 4;
            this.pwd_con.Text = "metroTextBox5";
            this.pwd_con.UseSelectable = true;
            // 
            // tile_save
            // 
            this.tile_save.ActiveControl = null;
            this.tile_save.Location = new System.Drawing.Point(455, 110);
            this.tile_save.Name = "tile_save";
            this.tile_save.Size = new System.Drawing.Size(176, 46);
            this.tile_save.TabIndex = 8;
            this.tile_save.Text = "Sign In";
            this.tile_save.UseSelectable = true;
            this.tile_save.Click += new System.EventHandler(this.tile_save_Click);
            // 
            // New_Login_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_save);
            this.Controls.Add(this.pwd_con);
            this.Controls.Add(this.ped);
            this.Controls.Add(this.txt_stmail);
            this.Controls.Add(this.txt_stname);
            this.Controls.Add(this.txt_stid);
            this.Name = "New_Login_Details";
            this.Text = "New_Login_Details";
            this.Load += new System.EventHandler(this.New_Login_Details_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_stid;
        private MetroFramework.Controls.MetroTextBox txt_stname;
        private MetroFramework.Controls.MetroTextBox txt_stmail;
        private MetroFramework.Controls.MetroTextBox ped;
        private MetroFramework.Controls.MetroTextBox pwd_con;
        private MetroFramework.Controls.MetroTile tile_save;
    }
}