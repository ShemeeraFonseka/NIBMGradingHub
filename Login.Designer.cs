
namespace WindowsFormsApp3
{
    partial class Login
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
            this.tile_student = new MetroFramework.Controls.MetroTile();
            this.tile_examUnit = new MetroFramework.Controls.MetroTile();
            this.tile_newLogin = new MetroFramework.Controls.MetroTile();
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_student
            // 
            this.tile_student.ActiveControl = null;
            this.tile_student.Location = new System.Drawing.Point(33, 42);
            this.tile_student.Name = "tile_student";
            this.tile_student.Size = new System.Drawing.Size(184, 138);
            this.tile_student.TabIndex = 0;
            this.tile_student.Text = "Student";
            this.tile_student.UseSelectable = true;
            this.tile_student.Click += new System.EventHandler(this.tile_student_Click);
            // 
            // tile_examUnit
            // 
            this.tile_examUnit.ActiveControl = null;
            this.tile_examUnit.Location = new System.Drawing.Point(298, 45);
            this.tile_examUnit.Name = "tile_examUnit";
            this.tile_examUnit.Size = new System.Drawing.Size(175, 134);
            this.tile_examUnit.TabIndex = 1;
            this.tile_examUnit.Text = "Exam Unit";
            this.tile_examUnit.UseSelectable = true;
            this.tile_examUnit.Click += new System.EventHandler(this.tile_examUnit_Click);
            // 
            // tile_newLogin
            // 
            this.tile_newLogin.ActiveControl = null;
            this.tile_newLogin.Location = new System.Drawing.Point(554, 49);
            this.tile_newLogin.Name = "tile_newLogin";
            this.tile_newLogin.Size = new System.Drawing.Size(174, 130);
            this.tile_newLogin.TabIndex = 2;
            this.tile_newLogin.Text = "New Login";
            this.tile_newLogin.UseSelectable = true;
            this.tile_newLogin.Click += new System.EventHandler(this.tile_newLogin_Click);
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(108, 226);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(190, 106);
            this.tile_back.TabIndex = 3;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_newLogin);
            this.Controls.Add(this.tile_examUnit);
            this.Controls.Add(this.tile_student);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_student;
        private MetroFramework.Controls.MetroTile tile_examUnit;
        private MetroFramework.Controls.MetroTile tile_newLogin;
        private MetroFramework.Controls.MetroTile tile_back;
    }
}