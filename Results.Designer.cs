
namespace WindowsFormsApp3
{
    partial class Results
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
            this.tile_results = new MetroFramework.Controls.MetroTile();
            this.st_ID = new MetroFramework.Controls.MetroTextBox();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // tile_results
            // 
            this.tile_results.ActiveControl = null;
            this.tile_results.Location = new System.Drawing.Point(40, 168);
            this.tile_results.Name = "tile_results";
            this.tile_results.Size = new System.Drawing.Size(254, 70);
            this.tile_results.TabIndex = 0;
            this.tile_results.Text = "View Results";
            this.tile_results.UseSelectable = true;
            this.tile_results.Click += new System.EventHandler(this.tile_results_Click);
            // 
            // st_ID
            // 
            this.st_ID.Lines = new string[0];
            this.st_ID.Location = new System.Drawing.Point(175, 57);
            this.st_ID.MaxLength = 32767;
            this.st_ID.Name = "st_ID";
            this.st_ID.PasswordChar = '\0';
            this.st_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.st_ID.SelectedText = "";
            this.st_ID.Size = new System.Drawing.Size(247, 55);
            this.st_ID.TabIndex = 1;
            this.st_ID.UseSelectable = true;
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(508, 65);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(185, 197);
            this.Data.TabIndex = 2;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.st_ID);
            this.Controls.Add(this.tile_results);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_results;
        private MetroFramework.Controls.MetroTextBox st_ID;
        private System.Windows.Forms.DataGridView Data;
    }
}