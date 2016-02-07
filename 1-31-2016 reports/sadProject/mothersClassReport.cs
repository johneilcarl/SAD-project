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
    public partial class mothersClassReport : Form
    {
        public mothersClassReport()
        {
            InitializeComponent();
        }

        private void mothersClassReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orientationReport.mothers_class1' table. You can move, or remove it, as needed.
            this.mothers_class1TableAdapter.Fill(this.orientationReport.mothers_class1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
