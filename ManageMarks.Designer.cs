
namespace WindowsFormsApp3
{
    partial class ManageMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMarks));
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnUpMark = new System.Windows.Forms.Button();
            this.btn_marks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(419, 484);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(434, 103);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete Marks";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnUpMark
            // 
            this.btnUpMark.BackColor = System.Drawing.Color.LightGray;
            this.btnUpMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpMark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpMark.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpMark.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpMark.Location = new System.Drawing.Point(210, 335);
            this.btnUpMark.Name = "btnUpMark";
            this.btnUpMark.Size = new System.Drawing.Size(434, 103);
            this.btnUpMark.TabIndex = 35;
            this.btnUpMark.Text = "Update Marks";
            this.btnUpMark.UseVisualStyleBackColor = false;
            this.btnUpMark.Click += new System.EventHandler(this.btnUpMark_Click);
            // 
            // btn_marks
            // 
            this.btn_marks.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_marks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_marks.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_marks.Location = new System.Drawing.Point(41, 194);
            this.btn_marks.Name = "btn_marks";
            this.btn_marks.Size = new System.Drawing.Size(400, 97);
            this.btn_marks.TabIndex = 34;
            this.btn_marks.Text = "Insert Marks";
            this.btn_marks.UseVisualStyleBackColor = false;
            this.btn_marks.Click += new System.EventHandler(this.btn_marks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(897, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 44F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(407, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 71);
            this.label1.TabIndex = 38;
            this.label1.Text = "Manage Students Marks";
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
            this.btn_back.TabIndex = 58;
            this.btn_back.Text = "<<Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.richTextBox1.Location = new System.Drawing.Point(225, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(936, 42);
            this.richTextBox1.TabIndex = 59;
            this.richTextBox1.Text = "NIBM Grading Hub allows Exam Unit members to Insert, Update and Delete Marks of t" +
    "he Students at NIBM";
            // 
            // ManageMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnUpMark);
            this.Controls.Add(this.btn_marks);
            this.Name = "ManageMarks";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnUpMark;
        private System.Windows.Forms.Button btn_marks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}