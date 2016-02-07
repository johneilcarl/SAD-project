namespace sadProject
{
    partial class patientDiagnosisReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiagnosisReport = new sadProject.DiagnosisReport();
            this.checkupTableAdapter = new sadProject.DiagnosisReportTableAdapters.checkupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DiagnosisSet";
            reportDataSource2.Value = this.checkupBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sadProject.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(598, 287);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // checkupBindingSource
            // 
            this.checkupBindingSource.DataMember = "checkup";
            this.checkupBindingSource.DataSource = this.DiagnosisReport;
            // 
            // DiagnosisReport
            // 
            this.DiagnosisReport.DataSetName = "DiagnosisReport";
            this.DiagnosisReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkupTableAdapter
            // 
            this.checkupTableAdapter.ClearBeforeFill = true;
            // 
            // patientDiagnosisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.reportViewer1);
            this.Name = "patientDiagnosisReport";
            this.Text = "Patient Diagnosis Report";
            this.Load += new System.EventHandler(this.patientDiagnosisReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource checkupBindingSource;
        private DiagnosisReport DiagnosisReport;
        private DiagnosisReportTableAdapters.checkupTableAdapter checkupTableAdapter;
    }
}