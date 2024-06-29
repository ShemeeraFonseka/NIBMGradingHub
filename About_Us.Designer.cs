
namespace WindowsFormsApp3
{
    partial class About_Us
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
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(606, 326);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(136, 50);
            this.tile_back.TabIndex = 0;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // About_Us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_back);
            this.Name = "About_Us";
            this.Text = "About_Us";
            this.Load += new System.EventHandler(this.About_Us_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_back;
    }
}