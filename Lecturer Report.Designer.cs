
namespace WindowsFormsApp3
{
    partial class Lecturer_Report
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
            this.Lecturer_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lec = new WindowsFormsApp3.lec();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_back = new System.Windows.Forms.Button();
            this.Lecturer_DetailsTableAdapter = new WindowsFormsApp3.lecTableAdapters.Lecturer_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Lecturer_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lec)).BeginInit();
            this.SuspendLayout();
            // 
            // Lecturer_DetailsBindingSource
            // 
            this.Lecturer_DetailsBindingSource.DataMember = "Lecturer_Details";
            this.Lecturer_DetailsBindingSource.DataSource = this.lec;
            // 
            // lec
            // 
            this.lec.DataSetName = "lec";
            this.lec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Lecturer_DetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.lec Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(692, 502);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_back.Location = new System.Drawing.Point(23, 556);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 45);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "<<Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Lecturer_DetailsTableAdapter
            // 
            this.Lecturer_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Lecturer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 624);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Lecturer_Report";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Lecturer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lecturer_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Lecturer_DetailsBindingSource;
        private lec lec;
        private lecTableAdapters.Lecturer_DetailsTableAdapter Lecturer_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_back;
    }
}