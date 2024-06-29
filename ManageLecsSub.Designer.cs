
namespace WindowsFormsApp3
{
    partial class ManageLecsSub
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
            this.btn_lecup = new System.Windows.Forms.Button();
            this.btn_subup = new System.Windows.Forms.Button();
            this.btn_subjects = new System.Windows.Forms.Button();
            this.btn_lec = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lecup
            // 
            this.btn_lecup.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_lecup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lecup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lecup.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold);
            this.btn_lecup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_lecup.Location = new System.Drawing.Point(756, 429);
            this.btn_lecup.Name = "btn_lecup";
            this.btn_lecup.Size = new System.Drawing.Size(394, 106);
            this.btn_lecup.TabIndex = 31;
            this.btn_lecup.Text = "Update Lecturers";
            this.btn_lecup.UseVisualStyleBackColor = false;
            this.btn_lecup.Click += new System.EventHandler(this.btn_lecup_Click);
            // 
            // btn_subup
            // 
            this.btn_subup.BackColor = System.Drawing.Color.LightGray;
            this.btn_subup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_subup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_subup.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold);
            this.btn_subup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_subup.Location = new System.Drawing.Point(214, 429);
            this.btn_subup.Name = "btn_subup";
            this.btn_subup.Size = new System.Drawing.Size(394, 106);
            this.btn_subup.TabIndex = 30;
            this.btn_subup.Text = "Update Subjects";
            this.btn_subup.UseVisualStyleBackColor = false;
            this.btn_subup.Click += new System.EventHandler(this.btn_subup_Click);
            // 
            // btn_subjects
            // 
            this.btn_subjects.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_subjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_subjects.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold);
            this.btn_subjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_subjects.Location = new System.Drawing.Point(214, 249);
            this.btn_subjects.Name = "btn_subjects";
            this.btn_subjects.Size = new System.Drawing.Size(394, 106);
            this.btn_subjects.TabIndex = 29;
            this.btn_subjects.Text = "Insert Subjects";
            this.btn_subjects.UseVisualStyleBackColor = false;
            this.btn_subjects.Click += new System.EventHandler(this.btn_subjects_Click);
            // 
            // btn_lec
            // 
            this.btn_lec.BackColor = System.Drawing.Color.LightGray;
            this.btn_lec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lec.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold);
            this.btn_lec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_lec.Location = new System.Drawing.Point(756, 249);
            this.btn_lec.Name = "btn_lec";
            this.btn_lec.Size = new System.Drawing.Size(394, 106);
            this.btn_lec.TabIndex = 28;
            this.btn_lec.Text = "Insert Lecturers";
            this.btn_lec.UseVisualStyleBackColor = false;
            this.btn_lec.Click += new System.EventHandler(this.btn_lec_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.richTextBox1.Location = new System.Drawing.Point(214, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(936, 42);
            this.richTextBox1.TabIndex = 61;
            this.richTextBox1.Text = "NIBM Grading Hub allows Exam Unit members to Insert and Update Subject and Lectur" +
    "er Details of NIBM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 44F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(237, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 71);
            this.label1.TabIndex = 60;
            this.label1.Text = "Manage Subject and Lecturer Details";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(23, 637);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(102, 45);
            this.btn_back.TabIndex = 62;
            this.btn_back.Text = "<<Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ManageLecsSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_lecup);
            this.Controls.Add(this.btn_subup);
            this.Controls.Add(this.btn_subjects);
            this.Controls.Add(this.btn_lec);
            this.Name = "ManageLecsSub";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageLecsSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lecup;
        private System.Windows.Forms.Button btn_subup;
        private System.Windows.Forms.Button btn_subjects;
        private System.Windows.Forms.Button btn_lec;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}