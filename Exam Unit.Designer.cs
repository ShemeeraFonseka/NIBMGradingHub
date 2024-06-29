
namespace WindowsFormsApp3
{
    partial class Exam_Unit
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
            this.txt_memid = new MetroFramework.Controls.MetroTextBox();
            this.txt_memmail = new MetroFramework.Controls.MetroTextBox();
            this.txt_memname = new MetroFramework.Controls.MetroTextBox();
            this.memmail = new MetroFramework.Controls.MetroTextBox();
            this.memname = new MetroFramework.Controls.MetroTextBox();
            this.cmb_memid = new MetroFramework.Controls.MetroComboBox();
            this.memid = new MetroFramework.Controls.MetroComboBox();
            this.tile_insert = new MetroFramework.Controls.MetroTile();
            this.tile_update = new MetroFramework.Controls.MetroTile();
            this.tile_delete = new MetroFramework.Controls.MetroTile();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_memid
            // 
            this.txt_memid.Lines = new string[] {
        "metroTextBox1"};
            this.txt_memid.Location = new System.Drawing.Point(65, 73);
            this.txt_memid.MaxLength = 32767;
            this.txt_memid.Name = "txt_memid";
            this.txt_memid.PasswordChar = '\0';
            this.txt_memid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memid.SelectedText = "";
            this.txt_memid.Size = new System.Drawing.Size(142, 28);
            this.txt_memid.TabIndex = 0;
            this.txt_memid.Text = "metroTextBox1";
            this.txt_memid.UseSelectable = true;
            // 
            // txt_memmail
            // 
            this.txt_memmail.Lines = new string[] {
        "metroTextBox2"};
            this.txt_memmail.Location = new System.Drawing.Point(76, 177);
            this.txt_memmail.MaxLength = 32767;
            this.txt_memmail.Name = "txt_memmail";
            this.txt_memmail.PasswordChar = '\0';
            this.txt_memmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memmail.SelectedText = "";
            this.txt_memmail.Size = new System.Drawing.Size(142, 28);
            this.txt_memmail.TabIndex = 1;
            this.txt_memmail.Text = "metroTextBox2";
            this.txt_memmail.UseSelectable = true;
            // 
            // txt_memname
            // 
            this.txt_memname.Lines = new string[] {
        "metroTextBox3"};
            this.txt_memname.Location = new System.Drawing.Point(76, 125);
            this.txt_memname.MaxLength = 32767;
            this.txt_memname.Name = "txt_memname";
            this.txt_memname.PasswordChar = '\0';
            this.txt_memname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memname.SelectedText = "";
            this.txt_memname.Size = new System.Drawing.Size(142, 28);
            this.txt_memname.TabIndex = 2;
            this.txt_memname.Text = "metroTextBox3";
            this.txt_memname.UseSelectable = true;
            // 
            // memmail
            // 
            this.memmail.Lines = new string[] {
        "metroTextBox4"};
            this.memmail.Location = new System.Drawing.Point(337, 177);
            this.memmail.MaxLength = 32767;
            this.memmail.Name = "memmail";
            this.memmail.PasswordChar = '\0';
            this.memmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memmail.SelectedText = "";
            this.memmail.Size = new System.Drawing.Size(142, 28);
            this.memmail.TabIndex = 3;
            this.memmail.Text = "metroTextBox4";
            this.memmail.UseSelectable = true;
            // 
            // memname
            // 
            this.memname.Lines = new string[] {
        "metroTextBox5"};
            this.memname.Location = new System.Drawing.Point(337, 125);
            this.memname.MaxLength = 32767;
            this.memname.Name = "memname";
            this.memname.PasswordChar = '\0';
            this.memname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memname.SelectedText = "";
            this.memname.Size = new System.Drawing.Size(142, 28);
            this.memname.TabIndex = 4;
            this.memname.Text = "metroTextBox5";
            this.memname.UseSelectable = true;
            // 
            // cmb_memid
            // 
            this.cmb_memid.FormattingEnabled = true;
            this.cmb_memid.ItemHeight = 23;
            this.cmb_memid.Location = new System.Drawing.Point(335, 63);
            this.cmb_memid.Name = "cmb_memid";
            this.cmb_memid.Size = new System.Drawing.Size(143, 29);
            this.cmb_memid.TabIndex = 5;
            this.cmb_memid.UseSelectable = true;
            // 
            // memid
            // 
            this.memid.FormattingEnabled = true;
            this.memid.ItemHeight = 23;
            this.memid.Location = new System.Drawing.Point(548, 63);
            this.memid.Name = "memid";
            this.memid.Size = new System.Drawing.Size(143, 29);
            this.memid.TabIndex = 6;
            this.memid.UseSelectable = true;
            // 
            // tile_insert
            // 
            this.tile_insert.ActiveControl = null;
            this.tile_insert.Location = new System.Drawing.Point(73, 246);
            this.tile_insert.Name = "tile_insert";
            this.tile_insert.Size = new System.Drawing.Size(133, 49);
            this.tile_insert.TabIndex = 7;
            this.tile_insert.Text = "Insert Member";
            this.tile_insert.UseSelectable = true;
            this.tile_insert.Click += new System.EventHandler(this.tile_insert_Click);
            // 
            // tile_update
            // 
            this.tile_update.ActiveControl = null;
            this.tile_update.Location = new System.Drawing.Point(337, 246);
            this.tile_update.Name = "tile_update";
            this.tile_update.Size = new System.Drawing.Size(133, 49);
            this.tile_update.TabIndex = 8;
            this.tile_update.Text = "Update Member";
            this.tile_update.UseSelectable = true;
            this.tile_update.Click += new System.EventHandler(this.tile_update_Click);
            // 
            // tile_delete
            // 
            this.tile_delete.ActiveControl = null;
            this.tile_delete.Location = new System.Drawing.Point(558, 246);
            this.tile_delete.Name = "tile_delete";
            this.tile_delete.Size = new System.Drawing.Size(133, 49);
            this.tile_delete.TabIndex = 9;
            this.tile_delete.Text = "Delete Member";
            this.tile_delete.UseSelectable = true;
            this.tile_delete.Click += new System.EventHandler(this.tile_delete_Click);
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(203, 332);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(257, 71);
            this.Data.TabIndex = 10;
            // 
            // Exam_Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.tile_delete);
            this.Controls.Add(this.tile_update);
            this.Controls.Add(this.tile_insert);
            this.Controls.Add(this.memid);
            this.Controls.Add(this.cmb_memid);
            this.Controls.Add(this.memname);
            this.Controls.Add(this.memmail);
            this.Controls.Add(this.txt_memname);
            this.Controls.Add(this.txt_memmail);
            this.Controls.Add(this.txt_memid);
            this.Name = "Exam_Unit";
            this.Text = "Exam_Unit";
            this.Load += new System.EventHandler(this.Exam_Unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_memid;
        private MetroFramework.Controls.MetroTextBox txt_memmail;
        private MetroFramework.Controls.MetroTextBox txt_memname;
        private MetroFramework.Controls.MetroTextBox memmail;
        private MetroFramework.Controls.MetroTextBox memname;
        private MetroFramework.Controls.MetroComboBox cmb_memid;
        private MetroFramework.Controls.MetroComboBox memid;
        private MetroFramework.Controls.MetroTile tile_insert;
        private MetroFramework.Controls.MetroTile tile_update;
        private MetroFramework.Controls.MetroTile tile_delete;
        private System.Windows.Forms.DataGridView Data;
    }
}