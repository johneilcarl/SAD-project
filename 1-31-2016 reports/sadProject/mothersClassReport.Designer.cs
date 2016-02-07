namespace sadProject
{
    partial class mothersClassReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.orientationReport = new sadProject.orientationReport();
            this.mothers_class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mothers_class1TableAdapter = new sadProject.orientationReportTableAdapters.mothers_class1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orientationReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mothers_class1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Month:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mothers_class1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sadProject.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(54, 147);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 299);
            this.reportViewer1.TabIndex = 12;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // orientationReport
            // 
            this.orientationReport.DataSetName = "orientationReport";
            this.orientationReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mothers_class1BindingSource
            // 
            this.mothers_class1BindingSource.DataMember = "mothers_class1";
            this.mothers_class1BindingSource.DataSource = this.orientationReport;
            // 
            // mothers_class1TableAdapter
            // 
            this.mothers_class1TableAdapter.ClearBeforeFill = true;
            // 
            // mothersClassReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 576);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mothersClassReport";
            this.ShowInTaskbar = false;
            this.Text = "mothersClassReport";
            this.Load += new System.EventHandler(this.mothersClassReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orientationReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mothers_class1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mothers_class1BindingSource;
        private orientationReport orientationReport;
        private orientationReportTableAdapters.mothers_class1TableAdapter mothers_class1TableAdapter;
    }
}