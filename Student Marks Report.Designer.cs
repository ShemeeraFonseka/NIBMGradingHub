
namespace WindowsFormsApp3
{
    partial class Student_Marks_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMarks = new WindowsFormsApp3.studentMarks();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MarksTableAdapter = new WindowsFormsApp3.studentMarksTableAdapters.MarksTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // MarksBindingSource
            // 
            this.MarksBindingSource.DataMember = "Marks";
            this.MarksBindingSource.DataSource = this.studentMarks;
            // 
            // studentMarks
            // 
            this.studentMarks.DataSetName = "studentMarks";
            this.studentMarks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.MarksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Marks Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(942, 537);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // MarksTableAdapter
            // 
            this.MarksTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.button1.Location = new System.Drawing.Point(23, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Marks_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Student_Marks_Report";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Student_Marks_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MarksBindingSource;
        private studentMarks studentMarks;
        private studentMarksTableAdapters.MarksTableAdapter MarksTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}