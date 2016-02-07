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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.mothers_classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orientationSchedSET = new sadProject.orientationSchedSET();
            this.mothers_class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mothers_classTableAdapter = new sadProject.orientationSchedSETTableAdapters.mothers_classTableAdapter();
            this.mothers_class1TableAdapter = new sadProject.orientationSchedSETTableAdapters.mothers_class1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mothers_classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationSchedSET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mothers_class1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mothers_class1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sadProject.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(839, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(321, 28);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 1;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(552, 28);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(274, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "From";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(527, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mothers_classBindingSource
            // 
            this.mothers_classBindingSource.DataMember = "mothers_class";
            this.mothers_classBindingSource.DataSource = this.orientationSchedSET;
            // 
            // orientationSchedSET
            // 
            this.orientationSchedSET.DataSetName = "orientationSchedSET";
            this.orientationSchedSET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mothers_class1BindingSource
            // 
            this.mothers_class1BindingSource.DataMember = "mothers_class1";
            this.mothers_class1BindingSource.DataSource = this.orientationSchedSET;
            // 
            // mothers_classTableAdapter
            // 
            this.mothers_classTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "mothersClassReport";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "mothersClassReport";
            this.Load += new System.EventHandler(this.mothersClassReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mothers_classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationSchedSET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mothers_class1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mothers_classBindingSource;
        private orientationSchedSET orientationSchedSET;
        private orientationSchedSETTableAdapters.mothers_classTableAdapter mothers_classTableAdapter;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mothers_class1BindingSource;
        private orientationSchedSETTableAdapters.mothers_class1TableAdapter mothers_class1TableAdapter;

    }
}