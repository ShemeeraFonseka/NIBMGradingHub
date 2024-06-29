
namespace WindowsFormsApp3
{
    partial class Students
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
            this.tile_insert = new MetroFramework.Controls.MetroTile();
            this.tile_update = new MetroFramework.Controls.MetroTile();
            this.tile_delete = new MetroFramework.Controls.MetroTile();
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.txt_stid = new MetroFramework.Controls.MetroTextBox();
            this.txt_stname = new MetroFramework.Controls.MetroTextBox();
            this.txt_stmail = new MetroFramework.Controls.MetroTextBox();
            this.cmb_stid1 = new MetroFramework.Controls.MetroComboBox();
            this.stname = new MetroFramework.Controls.MetroTextBox();
            this.st_mail = new MetroFramework.Controls.MetroTextBox();
            this.stid = new MetroFramework.Controls.MetroComboBox();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // tile_insert
            // 
            this.tile_insert.ActiveControl = null;
            this.tile_insert.Location = new System.Drawing.Point(55, 262);
            this.tile_insert.Name = "tile_insert";
            this.tile_insert.Size = new System.Drawing.Size(187, 59);
            this.tile_insert.TabIndex = 0;
            this.tile_insert.Text = "Insert";
            this.tile_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_insert.UseSelectable = true;
            this.tile_insert.Click += new System.EventHandler(this.tile_insert_Click);
            // 
            // tile_update
            // 
            this.tile_update.ActiveControl = null;
            this.tile_update.Location = new System.Drawing.Point(344, 257);
            this.tile_update.Name = "tile_update";
            this.tile_update.Size = new System.Drawing.Size(185, 64);
            this.tile_update.TabIndex = 1;
            this.tile_update.Text = "Update";
            this.tile_update.UseSelectable = true;
            this.tile_update.Click += new System.EventHandler(this.tile_update_Click);
            // 
            // tile_delete
            // 
            this.tile_delete.ActiveControl = null;
            this.tile_delete.Location = new System.Drawing.Point(585, 265);
            this.tile_delete.Name = "tile_delete";
            this.tile_delete.Size = new System.Drawing.Size(182, 56);
            this.tile_delete.TabIndex = 2;
            this.tile_delete.Text = "Delete";
            this.tile_delete.UseSelectable = true;
            this.tile_delete.Click += new System.EventHandler(this.tile_delete_Click);
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(676, 374);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(91, 53);
            this.tile_back.TabIndex = 3;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // txt_stid
            // 
            this.txt_stid.Lines = new string[] {
        "metroTextBox1"};
            this.txt_stid.Location = new System.Drawing.Point(87, 78);
            this.txt_stid.MaxLength = 32767;
            this.txt_stid.Name = "txt_stid";
            this.txt_stid.PasswordChar = '\0';
            this.txt_stid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stid.SelectedText = "";
            this.txt_stid.Size = new System.Drawing.Size(143, 29);
            this.txt_stid.TabIndex = 4;
            this.txt_stid.Text = "metroTextBox1";
            this.txt_stid.UseSelectable = true;
            // 
            // txt_stname
            // 
            this.txt_stname.Lines = new string[] {
        "metroTextBox2"};
            this.txt_stname.Location = new System.Drawing.Point(91, 124);
            this.txt_stname.MaxLength = 32767;
            this.txt_stname.Name = "txt_stname";
            this.txt_stname.PasswordChar = '\0';
            this.txt_stname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stname.SelectedText = "";
            this.txt_stname.Size = new System.Drawing.Size(138, 29);
            this.txt_stname.TabIndex = 5;
            this.txt_stname.Text = "metroTextBox2";
            this.txt_stname.UseSelectable = true;
            // 
            // txt_stmail
            // 
            this.txt_stmail.Lines = new string[] {
        "metroTextBox3"};
            this.txt_stmail.Location = new System.Drawing.Point(91, 171);
            this.txt_stmail.MaxLength = 32767;
            this.txt_stmail.Name = "txt_stmail";
            this.txt_stmail.PasswordChar = '\0';
            this.txt_stmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stmail.SelectedText = "";
            this.txt_stmail.Size = new System.Drawing.Size(137, 38);
            this.txt_stmail.TabIndex = 6;
            this.txt_stmail.Text = "metroTextBox3";
            this.txt_stmail.UseSelectable = true;
            // 
            // cmb_stid1
            // 
            this.cmb_stid1.FormattingEnabled = true;
            this.cmb_stid1.ItemHeight = 23;
            this.cmb_stid1.Location = new System.Drawing.Point(374, 71);
            this.cmb_stid1.Name = "cmb_stid1";
            this.cmb_stid1.Size = new System.Drawing.Size(137, 29);
            this.cmb_stid1.TabIndex = 7;
            this.cmb_stid1.UseSelectable = true;
            // 
            // stname
            // 
            this.stname.Lines = new string[] {
        "metroTextBox4"};
            this.stname.Location = new System.Drawing.Point(374, 117);
            this.stname.MaxLength = 32767;
            this.stname.Name = "stname";
            this.stname.PasswordChar = '\0';
            this.stname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stname.SelectedText = "";
            this.stname.Size = new System.Drawing.Size(136, 35);
            this.stname.TabIndex = 8;
            this.stname.Text = "metroTextBox4";
            this.stname.UseSelectable = true;
            // 
            // st_mail
            // 
            this.st_mail.Lines = new string[] {
        "metroTextBox5"};
            this.st_mail.Location = new System.Drawing.Point(386, 178);
            this.st_mail.MaxLength = 32767;
            this.st_mail.Name = "st_mail";
            this.st_mail.PasswordChar = '\0';
            this.st_mail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.st_mail.SelectedText = "";
            this.st_mail.Size = new System.Drawing.Size(123, 30);
            this.st_mail.TabIndex = 9;
            this.st_mail.Text = "metroTextBox5";
            this.st_mail.UseSelectable = true;
            // 
            // stid
            // 
            this.stid.FormattingEnabled = true;
            this.stid.ItemHeight = 23;
            this.stid.Location = new System.Drawing.Point(597, 70);
            this.stid.Name = "stid";
            this.stid.Size = new System.Drawing.Size(145, 29);
            this.stid.TabIndex = 10;
            this.stid.UseSelectable = true;
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(63, 350);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(477, 76);
            this.Data.TabIndex = 11;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.stid);
            this.Controls.Add(this.st_mail);
            this.Controls.Add(this.stname);
            this.Controls.Add(this.cmb_stid1);
            this.Controls.Add(this.txt_stmail);
            this.Controls.Add(this.txt_stname);
            this.Controls.Add(this.txt_stid);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_delete);
            this.Controls.Add(this.tile_update);
            this.Controls.Add(this.tile_insert);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_insert;
        private MetroFramework.Controls.MetroTile tile_update;
        private MetroFramework.Controls.MetroTile tile_delete;
        private MetroFramework.Controls.MetroTile tile_back;
        private MetroFramework.Controls.MetroTextBox txt_stid;
        private MetroFramework.Controls.MetroTextBox txt_stname;
        private MetroFramework.Controls.MetroTextBox txt_stmail;
        private MetroFramework.Controls.MetroComboBox cmb_stid1;
        private MetroFramework.Controls.MetroTextBox stname;
        private MetroFramework.Controls.MetroTextBox st_mail;
        private MetroFramework.Controls.MetroComboBox stid;
        private System.Windows.Forms.DataGridView Data;
    }
}