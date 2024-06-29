
namespace WindowsFormsApp3
{
    partial class Send_Email
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
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_body = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.Attachment1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_send.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold);
            this.btn_send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_send.Location = new System.Drawing.Point(95, 608);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(217, 64);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.txt_subject.Location = new System.Drawing.Point(259, 187);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(593, 40);
            this.txt_subject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label2.Location = new System.Drawing.Point(22, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label3.Location = new System.Drawing.Point(22, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // txt_body
            // 
            this.txt_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_body.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.txt_body.Location = new System.Drawing.Point(259, 270);
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(593, 193);
            this.txt_body.TabIndex = 8;
            this.txt_body.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.White;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_open.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_open.Location = new System.Drawing.Point(703, 511);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(149, 40);
            this.btn_open.TabIndex = 9;
            this.btn_open.Text = "Choose File";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Attachment1
            // 
            this.Attachment1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.Attachment1.Location = new System.Drawing.Point(259, 511);
            this.Attachment1.Name = "Attachment1";
            this.Attachment1.Size = new System.Drawing.Size(426, 40);
            this.Attachment1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label4.Location = new System.Drawing.Point(22, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Attachment";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancel.Location = new System.Drawing.Point(565, 608);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(217, 64);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.txt_Email.Location = new System.Drawing.Point(259, 114);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(593, 40);
            this.txt_Email.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(352, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 58);
            this.label5.TabIndex = 15;
            this.label5.Text = "Send Email";
            // 
            // Send_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Attachment1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txt_body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.btn_send);
            this.Name = "Send_Email";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Send_Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_body;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox Attachment1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}