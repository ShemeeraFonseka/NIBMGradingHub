
namespace WindowsFormsApp3
{
    partial class Manage_Marks
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
            this.SuspendLayout();
            // 
            // tile_insert
            // 
            this.tile_insert.ActiveControl = null;
            this.tile_insert.Location = new System.Drawing.Point(86, 113);
            this.tile_insert.Name = "tile_insert";
            this.tile_insert.Size = new System.Drawing.Size(154, 97);
            this.tile_insert.TabIndex = 0;
            this.tile_insert.Text = "Insert Marks";
            this.tile_insert.UseSelectable = true;
            this.tile_insert.Click += new System.EventHandler(this.tile_insert_Click);
            // 
            // tile_update
            // 
            this.tile_update.ActiveControl = null;
            this.tile_update.Location = new System.Drawing.Point(308, 113);
            this.tile_update.Name = "tile_update";
            this.tile_update.Size = new System.Drawing.Size(154, 97);
            this.tile_update.TabIndex = 1;
            this.tile_update.Text = "Update Marks";
            this.tile_update.UseSelectable = true;
            this.tile_update.Click += new System.EventHandler(this.tile_update_Click);
            // 
            // tile_delete
            // 
            this.tile_delete.ActiveControl = null;
            this.tile_delete.Location = new System.Drawing.Point(547, 113);
            this.tile_delete.Name = "tile_delete";
            this.tile_delete.Size = new System.Drawing.Size(154, 97);
            this.tile_delete.TabIndex = 2;
            this.tile_delete.Text = "Delete Marks";
            this.tile_delete.UseSelectable = true;
            this.tile_delete.Click += new System.EventHandler(this.tile_delete_Click);
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(506, 330);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(104, 55);
            this.tile_back.TabIndex = 3;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // Manage_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_delete);
            this.Controls.Add(this.tile_update);
            this.Controls.Add(this.tile_insert);
            this.Name = "Manage_Marks";
            this.Text = "Manage_Marks";
            this.Load += new System.EventHandler(this.Manage_Marks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_insert;
        private MetroFramework.Controls.MetroTile tile_update;
        private MetroFramework.Controls.MetroTile tile_delete;
        private MetroFramework.Controls.MetroTile tile_back;
    }
}