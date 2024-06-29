
namespace WindowsFormsApp3
{
    partial class Courses
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
            this.txt_ccode = new MetroFramework.Controls.MetroTextBox();
            this.txt_cname = new MetroFramework.Controls.MetroTextBox();
            this.cname = new MetroFramework.Controls.MetroTextBox();
            this.cmb_ccode = new MetroFramework.Controls.MetroComboBox();
            this.ccode = new MetroFramework.Controls.MetroComboBox();
            this.tile_insert = new MetroFramework.Controls.MetroTile();
            this.tile_clear1 = new MetroFramework.Controls.MetroTile();
            this.tile_update = new MetroFramework.Controls.MetroTile();
            this.tile_clear2 = new MetroFramework.Controls.MetroTile();
            this.tile_delete = new MetroFramework.Controls.MetroTile();
            this.tile_clear3 = new MetroFramework.Controls.MetroTile();
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ccode
            // 
            this.txt_ccode.Lines = new string[] {
        "metroTextBox1"};
            this.txt_ccode.Location = new System.Drawing.Point(75, 84);
            this.txt_ccode.MaxLength = 32767;
            this.txt_ccode.Name = "txt_ccode";
            this.txt_ccode.PasswordChar = '\0';
            this.txt_ccode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ccode.SelectedText = "";
            this.txt_ccode.Size = new System.Drawing.Size(134, 29);
            this.txt_ccode.TabIndex = 0;
            this.txt_ccode.Text = "metroTextBox1";
            this.txt_ccode.UseSelectable = true;
            // 
            // txt_cname
            // 
            this.txt_cname.Lines = new string[] {
        "metroTextBox2"};
            this.txt_cname.Location = new System.Drawing.Point(75, 140);
            this.txt_cname.MaxLength = 32767;
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.PasswordChar = '\0';
            this.txt_cname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cname.SelectedText = "";
            this.txt_cname.Size = new System.Drawing.Size(134, 29);
            this.txt_cname.TabIndex = 1;
            this.txt_cname.Text = "metroTextBox2";
            this.txt_cname.UseSelectable = true;
            // 
            // cname
            // 
            this.cname.Lines = new string[] {
        "metroTextBox3"};
            this.cname.Location = new System.Drawing.Point(307, 140);
            this.cname.MaxLength = 32767;
            this.cname.Name = "cname";
            this.cname.PasswordChar = '\0';
            this.cname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cname.SelectedText = "";
            this.cname.Size = new System.Drawing.Size(134, 29);
            this.cname.TabIndex = 2;
            this.cname.Text = "metroTextBox3";
            this.cname.UseSelectable = true;
            // 
            // cmb_ccode
            // 
            this.cmb_ccode.FormattingEnabled = true;
            this.cmb_ccode.ItemHeight = 23;
            this.cmb_ccode.Location = new System.Drawing.Point(291, 74);
            this.cmb_ccode.Name = "cmb_ccode";
            this.cmb_ccode.Size = new System.Drawing.Size(158, 29);
            this.cmb_ccode.TabIndex = 3;
            this.cmb_ccode.UseSelectable = true;
            // 
            // ccode
            // 
            this.ccode.FormattingEnabled = true;
            this.ccode.ItemHeight = 23;
            this.ccode.Location = new System.Drawing.Point(538, 74);
            this.ccode.Name = "ccode";
            this.ccode.Size = new System.Drawing.Size(158, 29);
            this.ccode.TabIndex = 4;
            this.ccode.UseSelectable = true;
            this.ccode.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // tile_insert
            // 
            this.tile_insert.ActiveControl = null;
            this.tile_insert.Location = new System.Drawing.Point(33, 215);
            this.tile_insert.Name = "tile_insert";
            this.tile_insert.Size = new System.Drawing.Size(89, 36);
            this.tile_insert.TabIndex = 5;
            this.tile_insert.Text = "Insert Course";
            this.tile_insert.UseSelectable = true;
            this.tile_insert.Click += new System.EventHandler(this.tile_insert_Click);
            // 
            // tile_clear1
            // 
            this.tile_clear1.ActiveControl = null;
            this.tile_clear1.Location = new System.Drawing.Point(157, 215);
            this.tile_clear1.Name = "tile_clear1";
            this.tile_clear1.Size = new System.Drawing.Size(89, 36);
            this.tile_clear1.TabIndex = 6;
            this.tile_clear1.Text = "Clear";
            this.tile_clear1.UseSelectable = true;
            // 
            // tile_update
            // 
            this.tile_update.ActiveControl = null;
            this.tile_update.Location = new System.Drawing.Point(307, 215);
            this.tile_update.Name = "tile_update";
            this.tile_update.Size = new System.Drawing.Size(89, 36);
            this.tile_update.TabIndex = 7;
            this.tile_update.Text = "Update Course";
            this.tile_update.UseSelectable = true;
            this.tile_update.Click += new System.EventHandler(this.tile_update_Click);
            // 
            // tile_clear2
            // 
            this.tile_clear2.ActiveControl = null;
            this.tile_clear2.Location = new System.Drawing.Point(420, 215);
            this.tile_clear2.Name = "tile_clear2";
            this.tile_clear2.Size = new System.Drawing.Size(89, 36);
            this.tile_clear2.TabIndex = 8;
            this.tile_clear2.Text = "Clear";
            this.tile_clear2.UseSelectable = true;
            // 
            // tile_delete
            // 
            this.tile_delete.ActiveControl = null;
            this.tile_delete.Location = new System.Drawing.Point(549, 215);
            this.tile_delete.Name = "tile_delete";
            this.tile_delete.Size = new System.Drawing.Size(89, 36);
            this.tile_delete.TabIndex = 9;
            this.tile_delete.Text = "Delete Course";
            this.tile_delete.UseSelectable = true;
            this.tile_delete.Click += new System.EventHandler(this.tile_delete_Click);
            // 
            // tile_clear3
            // 
            this.tile_clear3.ActiveControl = null;
            this.tile_clear3.Location = new System.Drawing.Point(664, 215);
            this.tile_clear3.Name = "tile_clear3";
            this.tile_clear3.Size = new System.Drawing.Size(89, 36);
            this.tile_clear3.TabIndex = 10;
            this.tile_clear3.Text = "Clear";
            this.tile_clear3.UseSelectable = true;
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(688, 391);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(89, 36);
            this.tile_back.TabIndex = 11;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(140, 291);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(348, 82);
            this.Data.TabIndex = 12;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_clear3);
            this.Controls.Add(this.tile_delete);
            this.Controls.Add(this.tile_clear2);
            this.Controls.Add(this.tile_update);
            this.Controls.Add(this.tile_clear1);
            this.Controls.Add(this.tile_insert);
            this.Controls.Add(this.ccode);
            this.Controls.Add(this.cmb_ccode);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.txt_ccode);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_ccode;
        private MetroFramework.Controls.MetroTextBox txt_cname;
        private MetroFramework.Controls.MetroTextBox cname;
        private MetroFramework.Controls.MetroComboBox cmb_ccode;
        private MetroFramework.Controls.MetroComboBox ccode;
        private MetroFramework.Controls.MetroTile tile_insert;
        private MetroFramework.Controls.MetroTile tile_clear1;
        private MetroFramework.Controls.MetroTile tile_update;
        private MetroFramework.Controls.MetroTile tile_clear2;
        private MetroFramework.Controls.MetroTile tile_delete;
        private MetroFramework.Controls.MetroTile tile_clear3;
        private MetroFramework.Controls.MetroTile tile_back;
        private System.Windows.Forms.DataGridView Data;
    }
}