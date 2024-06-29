
namespace WindowsFormsApp3
{
    partial class Subject_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new WindowsFormsApp3.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SubjectsTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.SubjectsTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gradingsystemDataSet = new WindowsFormsApp3.gradingsystemDataSet();
            this.subjectsTableAdapter1 = new WindowsFormsApp3.gradingsystemDataSetTableAdapters.SubjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingsystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsBindingSource
            // 
            this.SubjectsBindingSource.DataMember = "Subjects";
            this.SubjectsBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SubjectsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.subjectReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(654, 459);
            this.reportViewer1.TabIndex = 0;
            // 
            // SubjectsTableAdapter
            // 
            this.SubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_back.Location = new System.Drawing.Point(23, 521);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(119, 45);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "<<Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.subjectsBindingSource1;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(715, 36);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "No Of Credits";
            series2.XValueMember = "Subject_Code";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueMembers = "no_of_credits";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(506, 459);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataMember = "Subjects";
            this.subjectsBindingSource1.DataSource = this.gradingsystemDataSet;
            // 
            // gradingsystemDataSet
            // 
            this.gradingsystemDataSet.DataSetName = "gradingsystemDataSet";
            this.gradingsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsTableAdapter1
            // 
            this.subjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // Subject_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 589);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Subject_Report";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Subject_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingsystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SubjectsBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SubjectsTableAdapter SubjectsTableAdapter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private gradingsystemDataSet gradingsystemDataSet;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private gradingsystemDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter1;
    }
}