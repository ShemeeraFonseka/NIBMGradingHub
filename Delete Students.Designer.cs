
namespace WindowsFormsApp3
{
    partial class Delete_Students
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.ComboBox();
            this.txt_sub = new System.Windows.Forms.ComboBox();
            this.Data = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseworkmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exammarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradepointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingsystemDataSet1 = new WindowsFormsApp3.gradingsystemDataSet1();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tile_back = new System.Windows.Forms.Button();
            this.marksTableAdapter = new WindowsFormsApp3.gradingsystemDataSet1TableAdapters.MarksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingsystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift", 34F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(785, 511);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(353, 95);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete Marks";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_id
            // 
            this.txt_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_id.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(206, 202);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(268, 41);
            this.txt_id.TabIndex = 3;
            this.txt_id.SelectedIndexChanged += new System.EventHandler(this.txt_id_SelectedIndexChanged);
            // 
            // txt_sub
            // 
            this.txt_sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sub.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.txt_sub.FormattingEnabled = true;
            this.txt_sub.Location = new System.Drawing.Point(206, 320);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(268, 41);
            this.txt_sub.TabIndex = 4;
            this.txt_sub.SelectedIndexChanged += new System.EventHandler(this.txt_sub_SelectedIndexChanged);
            // 
            // Data
            // 
            this.Data.AutoGenerateColumns = false;
            this.Data.BackgroundColor = System.Drawing.Color.White;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.courseworkmarksDataGridViewTextBoxColumn,
            this.exammarksDataGridViewTextBoxColumn,
            this.finalmarksDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.gradepointDataGridViewTextBoxColumn});
            this.Data.DataSource = this.marksBindingSource;
            this.Data.Location = new System.Drawing.Point(585, 256);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(744, 204);
            this.Data.TabIndex = 5;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "subject_ID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "subject_ID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            // 
            // courseworkmarksDataGridViewTextBoxColumn
            // 
            this.courseworkmarksDataGridViewTextBoxColumn.DataPropertyName = "course_work_marks";
            this.courseworkmarksDataGridViewTextBoxColumn.HeaderText = "course_work_marks";
            this.courseworkmarksDataGridViewTextBoxColumn.Name = "courseworkmarksDataGridViewTextBoxColumn";
            // 
            // exammarksDataGridViewTextBoxColumn
            // 
            this.exammarksDataGridViewTextBoxColumn.DataPropertyName = "exam_marks";
            this.exammarksDataGridViewTextBoxColumn.HeaderText = "exam_marks";
            this.exammarksDataGridViewTextBoxColumn.Name = "exammarksDataGridViewTextBoxColumn";
            // 
            // finalmarksDataGridViewTextBoxColumn
            // 
            this.finalmarksDataGridViewTextBoxColumn.DataPropertyName = "final_marks";
            this.finalmarksDataGridViewTextBoxColumn.HeaderText = "final_marks";
            this.finalmarksDataGridViewTextBoxColumn.Name = "finalmarksDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // gradepointDataGridViewTextBoxColumn
            // 
            this.gradepointDataGridViewTextBoxColumn.DataPropertyName = "Grade_point";
            this.gradepointDataGridViewTextBoxColumn.HeaderText = "Grade_point";
            this.gradepointDataGridViewTextBoxColumn.Name = "gradepointDataGridViewTextBoxColumn";
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "Marks";
            this.marksBindingSource.DataSource = this.gradingsystemDataSet1;
            // 
            // gradingsystemDataSet1
            // 
            this.gradingsystemDataSet1.DataSetName = "gradingsystemDataSet1";
            this.gradingsystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.Black;
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(-42, -75);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(568, 866);
            this.metroGrid3.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 44F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(679, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(548, 71);
            this.label9.TabIndex = 47;
            this.label9.Text = "Delete Students Marks";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.richTextBox1.Location = new System.Drawing.Point(586, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(741, 81);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "To delete the marks record successfully, enter the correct student number and the" +
    " subject ID.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tile_back
            // 
            this.tile_back.BackColor = System.Drawing.Color.Black;
            this.tile_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile_back.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.tile_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tile_back.Location = new System.Drawing.Point(23, 631);
            this.tile_back.Name = "tile_back";
            this.tile_back.Size = new System.Drawing.Size(84, 51);
            this.tile_back.TabIndex = 49;
            this.tile_back.Text = "<<Back";
            this.tile_back.UseVisualStyleBackColor = false;
            this.tile_back.Click += new System.EventHandler(this.tile_back_Click);
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // Delete_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.tile_back);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.metroGrid3);
            this.Name = "Delete_Students";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Delete_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingsystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.ComboBox txt_sub;
        private System.Windows.Forms.DataGridView Data;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button tile_back;
        private gradingsystemDataSet1 gradingsystemDataSet1;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private gradingsystemDataSet1TableAdapters.MarksTableAdapter marksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseworkmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exammarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradepointDataGridViewTextBoxColumn;
    }
}