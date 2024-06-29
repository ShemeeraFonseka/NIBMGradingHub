
namespace WindowsFormsApp3
{
    partial class verifyemail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_otp = new System.Windows.Forms.Button();
            this.btn_verify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F);
            this.label1.Location = new System.Drawing.Point(96, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F);
            this.label2.Location = new System.Drawing.Point(96, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verification Code";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.75F);
            this.txt_Email.Location = new System.Drawing.Point(359, 100);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(342, 49);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.75F);
            this.txt_code.Location = new System.Drawing.Point(359, 278);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(342, 49);
            this.txt_code.TabIndex = 3;
            // 
            // btn_otp
            // 
            this.btn_otp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_otp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_otp.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F);
            this.btn_otp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_otp.Location = new System.Drawing.Point(174, 193);
            this.btn_otp.Name = "btn_otp";
            this.btn_otp.Size = new System.Drawing.Size(527, 60);
            this.btn_otp.TabIndex = 4;
            this.btn_otp.Text = "Send Verification Code";
            this.btn_otp.UseVisualStyleBackColor = false;
            this.btn_otp.Click += new System.EventHandler(this.btn_otp_Click);
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.LightGray;
            this.btn_verify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_verify.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F);
            this.btn_verify.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_verify.Location = new System.Drawing.Point(292, 367);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(223, 60);
            this.btn_verify.TabIndex = 5;
            this.btn_verify.Text = "verify";
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(284, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email Verification";
            // 
            // verifyemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.btn_otp);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "verifyemail";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.verifyemail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_otp;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Label label3;
    }
}