
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.tile_aboutUs = new MetroFramework.Controls.MetroTile();
            this.tile_login = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_aboutUs
            // 
            this.tile_aboutUs.ActiveControl = null;
            this.tile_aboutUs.Location = new System.Drawing.Point(1115, 37);
            this.tile_aboutUs.Name = "tile_aboutUs";
            this.tile_aboutUs.Size = new System.Drawing.Size(86, 47);
            this.tile_aboutUs.TabIndex = 1;
            this.tile_aboutUs.Text = "About Us";
            this.tile_aboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_aboutUs.UseSelectable = true;
            this.tile_aboutUs.Click += new System.EventHandler(this.tile_aboutUs_Click);
            // 
            // tile_login
            // 
            this.tile_login.ActiveControl = null;
            this.tile_login.Location = new System.Drawing.Point(1220, 37);
            this.tile_login.Name = "tile_login";
            this.tile_login.Size = new System.Drawing.Size(89, 47);
            this.tile_login.TabIndex = 2;
            this.tile_login.Text = "Login";
            this.tile_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_login.UseSelectable = true;
            this.tile_login.Click += new System.EventHandler(this.tile_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 620);
            this.Controls.Add(this.tile_login);
            this.Controls.Add(this.tile_aboutUs);
            this.Name = "Form1";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tile_aboutUs;
        private MetroFramework.Controls.MetroTile tile_login;
    }
}

