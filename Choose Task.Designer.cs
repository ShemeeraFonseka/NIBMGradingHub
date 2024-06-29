
namespace WindowsFormsApp3
{
    partial class Choose_Task
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
            this.tile_marks = new MetroFramework.Controls.MetroTile();
            this.tile_course = new MetroFramework.Controls.MetroTile();
            this.tile_subject = new MetroFramework.Controls.MetroTile();
            this.tile_lecturer = new MetroFramework.Controls.MetroTile();
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_student
            // 
            this.tile_student.ActiveControl = null;
            this.tile_student.Location = new System.Drawing.Point(21, 70);
            this.tile_student.Name = "tile_student";
            this.tile_student.Size = new System.Drawing.Size(104, 83);
            this.tile_student.TabIndex = 0;
            this.tile_student.Text = "Manage Students";
            this.tile_student.UseSelectable = true;
            this.tile_student.Click += new System.EventHandler(this.tile_student_Click);
            // 
            // tile_marks
            // 
            this.tile_marks.ActiveControl = null;
            this.tile_marks.Location = new System.Drawing.Point(166, 72);
            this.tile_marks.Name = "tile_marks";
            this.tile_marks.Size = new System.Drawing.Size(93, 80);
            this.tile_marks.TabIndex = 1;
            this.tile_marks.Text = "Manage Marks";
            this.tile_marks.UseSelectable = true;
            this.tile_marks.Click += new System.EventHandler(this.tile_marks_Click);
            // 
            // tile_course
            // 
            this.tile_course.ActiveControl = null;
            this.tile_course.Location = new System.Drawing.Point(289, 67);
            this.tile_course.Name = "tile_course";
            this.tile_course.Size = new System.Drawing.Size(106, 84);
            this.tile_course.TabIndex = 2;
            this.tile_course.Text = "Manage Courses";
            this.tile_course.UseSelectable = true;
            this.tile_course.Click += new System.EventHandler(this.tile_course_Click);
            // 
            // tile_subject
            // 
            this.tile_subject.ActiveControl = null;
            this.tile_subject.Location = new System.Drawing.Point(431, 66);
            this.tile_subject.Name = "tile_subject";
            this.tile_subject.Size = new System.Drawing.Size(97, 84);
            this.tile_subject.TabIndex = 3;
            this.tile_subject.Text = "Manage Subjects";
            this.tile_subject.UseSelectable = true;
            this.tile_subject.Click += new System.EventHandler(this.tile_subject_Click);
            // 
            // tile_lecturer
            // 
            this.tile_lecturer.ActiveControl = null;
            this.tile_lecturer.Location = new System.Drawing.Point(559, 72);
            this.tile_lecturer.Name = "tile_lecturer";
            this.tile_lecturer.Size = new System.Drawing.Size(101, 80);
            this.tile_lecturer.TabIndex = 4;
            this.tile_lecturer.Text = "Manage Lecturers";
            this.tile_lecturer.UseSelectable = true;
            this.tile_lecturer.Click += new System.EventHandler(this.tile_lecturer_Click);
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(568, 270);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(91, 43);
            this.tile_back.TabIndex = 5;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // Choose_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_lecturer);
            this.Controls.Add(this.tile_subject);
            this.Controls.Add(this.tile_course);
            this.Controls.Add(this.tile_marks);
            this.Controls.Add(this.tile_student);
            this.Name = "Choose_Task";
            this.Text = "Choose_Task";
            this.Load += new System.EventHandler(this.Choose_Task_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_student;
        private MetroFramework.Controls.MetroTile tile_marks;
        private MetroFramework.Controls.MetroTile tile_course;
        private MetroFramework.Controls.MetroTile tile_subject;
        private MetroFramework.Controls.MetroTile tile_lecturer;
        private MetroFramework.Controls.MetroTile tile_back;
    }
}