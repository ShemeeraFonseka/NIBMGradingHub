
namespace WindowsFormsApp3
{
    partial class Lecturers
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
            this.txt_lecid = new MetroFramework.Controls.MetroTextBox();
            this.txt_lecname = new MetroFramework.Controls.MetroTextBox();
            this.txt_scode = new MetroFramework.Controls.MetroComboBox();
            this.cmb_lecid = new MetroFramework.Controls.MetroComboBox();
            this.lecname = new MetroFramework.Controls.MetroTextBox();
            this.scode = new MetroFramework.Controls.MetroComboBox();
            this.lecid = new MetroFramework.Controls.MetroComboBox();
            this.tile_insert = new MetroFramework.Controls.MetroTile();
            this.tile_update = new MetroFramework.Controls.MetroTile();
            this.tile_delete = new MetroFramework.Controls.MetroTile();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_lecid
            // 
            this.txt_lecid.Lines = new string[] {
        "metroTextBox1"};
            this.txt_lecid.Location = new System.Drawing.Point(83, 70);
            this.txt_lecid.MaxLength = 32767;
            this.txt_lecid.Name = "txt_lecid";
            this.txt_lecid.PasswordChar = '\0';
            this.txt_lecid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lecid.SelectedText = "";
            this.txt_lecid.Size = new System.Drawing.Size(121, 27);
            this.txt_lecid.TabIndex = 0;
            this.txt_lecid.Text = "metroTextBox1";
            this.txt_lecid.UseSelectable = true;
            // 
            // txt_lecname
            // 
            this.txt_lecname.Lines = new string[] {
        "metroTextBox2"};
            this.txt_lecname.Location = new System.Drawing.Point(83, 120);
            this.txt_lecname.MaxLength = 32767;
            this.txt_lecname.Name = "txt_lecname";
            this.txt_lecname.PasswordChar = '\0';
            this.txt_lecname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lecname.SelectedText = "";
            this.txt_lecname.Size = new System.Drawing.Size(121, 27);
            this.txt_lecname.TabIndex = 1;
            this.txt_lecname.Text = "metroTextBox2";
            this.txt_lecname.UseSelectable = true;
            // 
            // txt_scode
            // 
            this.txt_scode.FormattingEnabled = true;
            this.txt_scode.ItemHeight = 23;
            this.txt_scode.Location = new System.Drawing.Point(84, 169);
            this.txt_scode.Name = "txt_scode";
            this.txt_scode.Size = new System.Drawing.Size(119, 29);
            this.txt_scode.TabIndex = 2;
            this.txt_scode.UseSelectable = true;
            // 
            // cmb_lecid
            // 
            this.cmb_lecid.FormattingEnabled = true;
            this.cmb_lecid.ItemHeight = 23;
            this.cmb_lecid.Location = new System.Drawing.Point(295, 68);
            this.cmb_lecid.Name = "cmb_lecid";
            this.cmb_lecid.Size = new System.Drawing.Size(119, 29);
            this.cmb_lecid.TabIndex = 3;
            this.cmb_lecid.UseSelectable = true;
            // 
            // lecname
            // 
            this.lecname.Lines = new string[] {
        "metroTextBox3"};
            this.lecname.Location = new System.Drawing.Point(295, 120);
            this.lecname.MaxLength = 32767;
            this.lecname.Name = "lecname";
            this.lecname.PasswordChar = '\0';
            this.lecname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lecname.SelectedText = "";
            this.lecname.Size = new System.Drawing.Size(121, 27);
            this.lecname.TabIndex = 4;
            this.lecname.Text = "metroTextBox3";
            this.lecname.UseSelectable = true;
            // 
            // scode
            // 
            this.scode.FormattingEnabled = true;
            this.scode.ItemHeight = 23;
            this.scode.Location = new System.Drawing.Point(297, 169);
            this.scode.Name = "scode";
            this.scode.Size = new System.Drawing.Size(119, 29);
            this.scode.TabIndex = 5;
            this.scode.UseSelectable = true;
            // 
            // lecid
            // 
            this.lecid.FormattingEnabled = true;
            this.lecid.ItemHeight = 23;
            this.lecid.Location = new System.Drawing.Point(494, 63);
            this.lecid.Name = "lecid";
            this.lecid.Size = new System.Drawing.Size(119, 29);
            this.lecid.TabIndex = 6;
            this.lecid.UseSelectable = true;
            // 
            // tile_insert
            // 
            this.tile_insert.ActiveControl = null;
            this.tile_insert.Location = new System.Drawing.Point(66, 246);
            this.tile_insert.Name = "tile_insert";
            this.tile_insert.Size = new System.Drawing.Size(146, 54);
            this.tile_insert.TabIndex = 7;
            this.tile_insert.Text = "Insert Lecturer";
            this.tile_insert.UseSelectable = true;
            this.tile_insert.Click += new System.EventHandler(this.tile_insert_Click);
            // 
            // tile_update
            // 
            this.tile_update.ActiveControl = null;
            this.tile_update.Location = new System.Drawing.Point(297, 246);
            this.tile_update.Name = "tile_update";
            this.tile_update.Size = new System.Drawing.Size(146, 54);
            this.tile_update.TabIndex = 8;
            this.tile_update.Text = "Update Lecturer";
            this.tile_update.UseSelectable = true;
            this.tile_update.Click += new System.EventHandler(this.tile_update_Click);
            // 
            // tile_delete
            // 
            this.tile_delete.ActiveControl = null;
            this.tile_delete.Location = new System.Drawing.Point(520, 246);
            this.tile_delete.Name = "tile_delete";
            this.tile_delete.Size = new System.Drawing.Size(146, 54);
            this.tile_delete.TabIndex = 9;
            this.tile_delete.Text = "Delete Lecturer";
            this.tile_delete.UseSelectable = true;
            this.tile_delete.Click += new System.EventHandler(this.tile_delete_Click);
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(163, 326);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(400, 88);
            this.Data.TabIndex = 10;
            // 
            // Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.tile_delete);
            this.Controls.Add(this.tile_update);
            this.Controls.Add(this.tile_insert);
            this.Controls.Add(this.lecid);
            this.Controls.Add(this.scode);
            this.Controls.Add(this.lecname);
            this.Controls.Add(this.cmb_lecid);
            this.Controls.Add(this.txt_scode);
            this.Controls.Add(this.txt_lecname);
            this.Controls.Add(this.txt_lecid);
            this.Name = "Lecturers";
            this.Text = "Lecturers";
            this.Load += new System.EventHandler(this.Lecturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_lecid;
        private MetroFramework.Controls.MetroTextBox txt_lecname;
        private MetroFramework.Controls.MetroComboBox txt_scode;
        private MetroFramework.Controls.MetroComboBox cmb_lecid;
        private MetroFramework.Controls.MetroTextBox lecname;
        private MetroFramework.Controls.MetroComboBox scode;
        private MetroFramework.Controls.MetroComboBox lecid;
        private MetroFramework.Controls.MetroTile tile_insert;
        private MetroFramework.Controls.MetroTile tile_update;
        private MetroFramework.Controls.MetroTile tile_delete;
        private System.Windows.Forms.DataGridView Data;
    }
}