
namespace WindowsFormsApp3
{
    partial class Update_Lecturers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmb_lecid = new System.Windows.Forms.ComboBox();
            this.scode = new System.Windows.Forms.ComboBox();
            this.lecname = new System.Windows.Forms.TextBox();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.Data = new System.Windows.Forms.DataGridView();
            this.lectureridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingsystemDataSet7 = new WindowsFormsApp3.gradingsystemDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lecturer_DetailsTableAdapter = new WindowsFormsApp3.gradingsystemDataSet7TableAdapters.Lecturer_DetailsTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingsystemDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 48);
            this.label6.TabIndex = 45;
            this.label6.Text = "Lecturer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 48);
            this.label5.TabIndex = 44;
            this.label5.Text = "Lecturer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 48);
            this.label4.TabIndex = 43;
            this.label4.Text = "Subject Code";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Bahnschrift", 34F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(122, 476);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(371, 102);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "Update Lecturer";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_lecid
            // 
            this.cmb_lecid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lecid.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.cmb_lecid.FormattingEnabled = true;
            this.cmb_lecid.Location = new System.Drawing.Point(274, 154);
            this.cmb_lecid.Name = "cmb_lecid";
            this.cmb_lecid.Size = new System.Drawing.Size(315, 41);
            this.cmb_lecid.TabIndex = 40;
            this.cmb_lecid.SelectedIndexChanged += new System.EventHandler(this.cmb_lecid_SelectedIndexChanged);
            // 
            // scode
            // 
            this.scode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scode.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.scode.FormattingEnabled = true;
            this.scode.Location = new System.Drawing.Point(274, 367);
            this.scode.Name = "scode";
            this.scode.Size = new System.Drawing.Size(315, 41);
            this.scode.TabIndex = 39;
            // 
            // lecname
            // 
            this.lecname.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.lecname.Location = new System.Drawing.Point(274, 258);
            this.lecname.Name = "lecname";
            this.lecname.Size = new System.Drawing.Size(315, 40);
            this.lecname.TabIndex = 38;
            this.lecname.TextChanged += new System.EventHandler(this.lecname_TextChanged);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.LightGray;
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(-20, -77);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(677, 865);
            this.metroGrid2.TabIndex = 46;
            // 
            // Data
            // 
            this.Data.AutoGenerateColumns = false;
            this.Data.BackgroundColor = System.Drawing.Color.White;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureridDataGridViewTextBoxColumn,
            this.lecturernameDataGridViewTextBoxColumn,
            this.subjectCodeDataGridViewTextBoxColumn});
            this.Data.DataSource = this.lecturerDetailsBindingSource;
            this.Data.Location = new System.Drawing.Point(840, 286);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(343, 319);
            this.Data.TabIndex = 47;
            // 
            // lectureridDataGridViewTextBoxColumn
            // 
            this.lectureridDataGridViewTextBoxColumn.DataPropertyName = "Lecturer_id";
            this.lectureridDataGridViewTextBoxColumn.HeaderText = "Lecturer_id";
            this.lectureridDataGridViewTextBoxColumn.Name = "lectureridDataGridViewTextBoxColumn";
            // 
            // lecturernameDataGridViewTextBoxColumn
            // 
            this.lecturernameDataGridViewTextBoxColumn.DataPropertyName = "Lecturer_name";
            this.lecturernameDataGridViewTextBoxColumn.HeaderText = "Lecturer_name";
            this.lecturernameDataGridViewTextBoxColumn.Name = "lecturernameDataGridViewTextBoxColumn";
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "Subject_Code";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject_Code";
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            // 
            // lecturerDetailsBindingSource
            // 
            this.lecturerDetailsBindingSource.DataMember = "Lecturer_Details";
            this.lecturerDetailsBindingSource.DataSource = this.gradingsystemDataSet7;
            // 
            // gradingsystemDataSet7
            // 
            this.gradingsystemDataSet7.DataSetName = "gradingsystemDataSet7";
            this.gradingsystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 44F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(721, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 71);
            this.label1.TabIndex = 56;
            this.label1.Text = "Update Lecturer Details";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightGray;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(23, 634);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 48);
            this.btn_back.TabIndex = 57;
            this.btn_back.Text = "<<Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lecturer_DetailsTableAdapter
            // 
            this.lecturer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.richTextBox1.Location = new System.Drawing.Point(687, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(650, 74);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "To update Lecturer Details successfully, enter the correct Lecturer ID, Lecturer " +
    "Name and Subject Code that you want to update";
            // 
            // Update_Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_lecid);
            this.Controls.Add(this.scode);
            this.Controls.Add(this.lecname);
            this.Controls.Add(this.metroGrid2);
            this.Name = "Update_Lecturers";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Update_Lecturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingsystemDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmb_lecid;
        private System.Windows.Forms.ComboBox scode;
        private System.Windows.Forms.TextBox lecname;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private gradingsystemDataSet7 gradingsystemDataSet7;
        private System.Windows.Forms.BindingSource lecturerDetailsBindingSource;
        private gradingsystemDataSet7TableAdapters.Lecturer_DetailsTableAdapter lecturer_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}