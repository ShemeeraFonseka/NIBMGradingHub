
namespace WindowsFormsApp3
{
    partial class ExamUnit_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExamUnit_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new WindowsFormsApp3.DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExamUnit_DetailsTableAdapter = new WindowsFormsApp3.DataSet3TableAdapters.ExamUnit_DetailsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExamUnit_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamUnit_DetailsBindingSource
            // 
            this.ExamUnit_DetailsBindingSource.DataMember = "ExamUnit_Details";
            this.ExamUnit_DetailsBindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ExamUnit_DetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.examunitReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(774, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExamUnit_DetailsTableAdapter
            // 
            this.ExamUnit_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.button1.Location = new System.Drawing.Point(23, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExamUnit_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExamUnit_Report";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.ExamUnit_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamUnit_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExamUnit_DetailsBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.ExamUnit_DetailsTableAdapter ExamUnit_DetailsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}