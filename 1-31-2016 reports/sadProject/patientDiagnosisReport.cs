using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sadProject
{
    public partial class patientDiagnosisReport : MetroForm
    {
        public patientDiagnosisReport()
        {
            InitializeComponent();
        }

        private void patientDiagnosisReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DiagnosisReport.checkup' table. You can move, or remove it, as needed.
            this.checkupTableAdapter.Fill(this.DiagnosisReport.checkup);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
