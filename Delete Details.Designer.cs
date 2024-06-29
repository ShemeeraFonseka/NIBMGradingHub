
namespace WindowsFormsApp3
{
    partial class Delete_Details
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
            this.st_ID = new MetroFramework.Controls.MetroComboBox();
            this.tile_delete = new MetroFramework.Controls.MetroTile();
            this.tile_clear = new MetroFramework.Controls.MetroTile();
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // st_ID
            // 
            this.st_ID.FormattingEnabled = true;
            this.st_ID.ItemHeight = 23;
            this.st_ID.Location = new System.Drawing.Point(295, 60);
            this.st_ID.Name = "st_ID";
            this.st_ID.Size = new System.Drawing.Size(155, 29);
            this.st_ID.TabIndex = 0;
            this.st_ID.UseSelectable = true;
            // 
            // tile_delete
            // 
            this.tile_delete.ActiveControl = null;
            this.tile_delete.Location = new System.Drawing.Point(140, 137);
            this.tile_delete.Name = "tile_delete";
            this.tile_delete.Size = new System.Drawing.Size(145, 38);
            this.tile_delete.TabIndex = 1;
            this.tile_delete.Text = "Delete Details";
            this.tile_delete.UseSelectable = true;
            this.tile_delete.Click += new System.EventHandler(this.tile_delete_Click);
            // 
            // tile_clear
            // 
            this.tile_clear.ActiveControl = null;
            this.tile_clear.Location = new System.Drawing.Point(414, 137);
            this.tile_clear.Name = "tile_clear";
            this.tile_clear.Size = new System.Drawing.Size(145, 38);
            this.tile_clear.TabIndex = 2;
            this.tile_clear.Text = "Clear";
            this.tile_clear.UseSelectable = true;
            this.tile_clear.Click += new System.EventHandler(this.tile_clear_Click);
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(616, 398);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(145, 38);
            this.tile_back.TabIndex = 3;
            this.tile_back.Text = " Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(166, 216);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(392, 107);
            this.Data.TabIndex = 4;
            // 
            // Delete_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_clear);
            this.Controls.Add(this.tile_delete);
            this.Controls.Add(this.st_ID);
            this.Name = "Delete_Details";
            this.Text = "Delete_Details";
            this.Load += new System.EventHandler(this.Delete_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox st_ID;
        private MetroFramework.Controls.MetroTile tile_delete;
        private MetroFramework.Controls.MetroTile tile_clear;
        private MetroFramework.Controls.MetroTile tile_back;
        private System.Windows.Forms.DataGridView Data;
    }
}