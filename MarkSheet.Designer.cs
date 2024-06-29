
namespace WindowsFormsApp3
{
    partial class MarkSheet
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
            this.s_ID = new MetroFramework.Controls.MetroComboBox();
            this.c_ID = new MetroFramework.Controls.MetroComboBox();
            this.txt_CourseWork = new MetroFramework.Controls.MetroTextBox();
            this.txt_ExamMarks = new MetroFramework.Controls.MetroTextBox();
            this.tile_cal = new MetroFramework.Controls.MetroTile();
            this.txt_FinalMarks = new MetroFramework.Controls.MetroTextBox();
            this.credits = new MetroFramework.Controls.MetroTextBox();
            this.grade = new MetroFramework.Controls.MetroTextBox();
            this.tile_insert = new MetroFramework.Controls.MetroTile();
            this.tile_clear = new MetroFramework.Controls.MetroTile();
            this.tile_back = new MetroFramework.Controls.MetroTile();
            this.st_ID = new MetroFramework.Controls.MetroComboBox();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // s_ID
            // 
            this.s_ID.FormattingEnabled = true;
            this.s_ID.ItemHeight = 23;
            this.s_ID.Location = new System.Drawing.Point(94, 131);
            this.s_ID.Name = "s_ID";
            this.s_ID.Size = new System.Drawing.Size(137, 29);
            this.s_ID.TabIndex = 1;
            this.s_ID.UseSelectable = true;
            // 
            // c_ID
            // 
            this.c_ID.FormattingEnabled = true;
            this.c_ID.ItemHeight = 23;
            this.c_ID.Location = new System.Drawing.Point(94, 96);
            this.c_ID.Name = "c_ID";
            this.c_ID.Size = new System.Drawing.Size(137, 29);
            this.c_ID.TabIndex = 2;
            this.c_ID.UseSelectable = true;
            // 
            // txt_CourseWork
            // 
            this.txt_CourseWork.Lines = new string[] {
        "metroTextBox1"};
            this.txt_CourseWork.Location = new System.Drawing.Point(98, 176);
            this.txt_CourseWork.MaxLength = 32767;
            this.txt_CourseWork.Name = "txt_CourseWork";
            this.txt_CourseWork.PasswordChar = '\0';
            this.txt_CourseWork.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CourseWork.SelectedText = "";
            this.txt_CourseWork.Size = new System.Drawing.Size(132, 27);
            this.txt_CourseWork.TabIndex = 3;
            this.txt_CourseWork.Text = "metroTextBox1";
            this.txt_CourseWork.UseSelectable = true;
            // 
            // txt_ExamMarks
            // 
            this.txt_ExamMarks.Lines = new string[] {
        "metroTextBox2"};
            this.txt_ExamMarks.Location = new System.Drawing.Point(99, 220);
            this.txt_ExamMarks.MaxLength = 32767;
            this.txt_ExamMarks.Name = "txt_ExamMarks";
            this.txt_ExamMarks.PasswordChar = '\0';
            this.txt_ExamMarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ExamMarks.SelectedText = "";
            this.txt_ExamMarks.Size = new System.Drawing.Size(132, 27);
            this.txt_ExamMarks.TabIndex = 4;
            this.txt_ExamMarks.Text = "metroTextBox2";
            this.txt_ExamMarks.UseSelectable = true;
            // 
            // tile_cal
            // 
            this.tile_cal.ActiveControl = null;
            this.tile_cal.Location = new System.Drawing.Point(90, 262);
            this.tile_cal.Name = "tile_cal";
            this.tile_cal.Size = new System.Drawing.Size(157, 40);
            this.tile_cal.TabIndex = 5;
            this.tile_cal.Text = "Cakculate";
            this.tile_cal.UseSelectable = true;
            this.tile_cal.Click += new System.EventHandler(this.tile_cal_Click);
            // 
            // txt_FinalMarks
            // 
            this.txt_FinalMarks.Lines = new string[] {
        "metroTextBox3"};
            this.txt_FinalMarks.Location = new System.Drawing.Point(113, 317);
            this.txt_FinalMarks.MaxLength = 32767;
            this.txt_FinalMarks.Name = "txt_FinalMarks";
            this.txt_FinalMarks.PasswordChar = '\0';
            this.txt_FinalMarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_FinalMarks.SelectedText = "";
            this.txt_FinalMarks.Size = new System.Drawing.Size(117, 25);
            this.txt_FinalMarks.TabIndex = 6;
            this.txt_FinalMarks.Text = "metroTextBox3";
            this.txt_FinalMarks.UseSelectable = true;
            // 
            // credits
            // 
            this.credits.Lines = new string[] {
        "metroTextBox4"};
            this.credits.Location = new System.Drawing.Point(113, 391);
            this.credits.MaxLength = 32767;
            this.credits.Name = "credits";
            this.credits.PasswordChar = '\0';
            this.credits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.credits.SelectedText = "";
            this.credits.Size = new System.Drawing.Size(117, 25);
            this.credits.TabIndex = 7;
            this.credits.Text = "metroTextBox4";
            this.credits.UseSelectable = true;
            // 
            // grade
            // 
            this.grade.Lines = new string[] {
        "metroTextBox5"};
            this.grade.Location = new System.Drawing.Point(113, 352);
            this.grade.MaxLength = 32767;
            this.grade.Name = "grade";
            this.grade.PasswordChar = '\0';
            this.grade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade.SelectedText = "";
            this.grade.Size = new System.Drawing.Size(117, 25);
            this.grade.TabIndex = 8;
            this.grade.Text = "metroTextBox5";
            this.grade.UseSelectable = true;
            // 
            // tile_insert
            // 
            this.tile_insert.ActiveControl = null;
            this.tile_insert.Location = new System.Drawing.Point(405, 217);
            this.tile_insert.Name = "tile_insert";
            this.tile_insert.Size = new System.Drawing.Size(110, 45);
            this.tile_insert.TabIndex = 9;
            this.tile_insert.Text = "Insert Details";
            this.tile_insert.UseSelectable = true;
            this.tile_insert.Click += new System.EventHandler(this.tile_insert_Click);
            // 
            // tile_clear
            // 
            this.tile_clear.ActiveControl = null;
            this.tile_clear.Location = new System.Drawing.Point(612, 217);
            this.tile_clear.Name = "tile_clear";
            this.tile_clear.Size = new System.Drawing.Size(110, 45);
            this.tile_clear.TabIndex = 10;
            this.tile_clear.Text = "Clear";
            this.tile_clear.UseSelectable = true;
            this.tile_clear.Click += new System.EventHandler(this.tile_clear_Click);
            // 
            // tile_back
            // 
            this.tile_back.ActiveControl = null;
            this.tile_back.Location = new System.Drawing.Point(630, 371);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(110, 45);
            this.tile_back.TabIndex = 11;
            this.tile_back.Text = "Back";
            this.tile_back.UseSelectable = true;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // st_ID
            // 
            this.st_ID.FormattingEnabled = true;
            this.st_ID.ItemHeight = 23;
            this.st_ID.Location = new System.Drawing.Point(97, 60);
            this.st_ID.Name = "st_ID";
            this.st_ID.Size = new System.Drawing.Size(133, 29);
            this.st_ID.TabIndex = 12;
            this.st_ID.UseSelectable = true;
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(334, 32);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(325, 111);
            this.Data.TabIndex = 13;
            // 
            // MarkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.st_ID);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.tile_clear);
            this.Controls.Add(this.tile_insert);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.txt_FinalMarks);
            this.Controls.Add(this.tile_cal);
            this.Controls.Add(this.txt_ExamMarks);
            this.Controls.Add(this.txt_CourseWork);
            this.Controls.Add(this.c_ID);
            this.Controls.Add(this.s_ID);
            this.Name = "MarkSheet";
            this.Text = "MarkSheet";
            this.Load += new System.EventHandler(this.MarkSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox s_ID;
        private MetroFramework.Controls.MetroComboBox c_ID;
        private MetroFramework.Controls.MetroTextBox txt_CourseWork;
        private MetroFramework.Controls.MetroTextBox txt_ExamMarks;
        private MetroFramework.Controls.MetroTile tile_cal;
        private MetroFramework.Controls.MetroTextBox txt_FinalMarks;
        private MetroFramework.Controls.MetroTextBox credits;
        private MetroFramework.Controls.MetroTextBox grade;
        private MetroFramework.Controls.MetroTile tile_insert;
        private MetroFramework.Controls.MetroTile tile_clear;
        private MetroFramework.Controls.MetroTile tile_back;
        private MetroFramework.Controls.MetroComboBox st_ID;
        private System.Windows.Forms.DataGridView Data;
    }
}