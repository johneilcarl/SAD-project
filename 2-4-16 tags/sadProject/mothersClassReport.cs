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
    public partial class mothersClassReport : MetroForm
    {
        public mothersClassReport()
        {
            InitializeComponent();
        }

        private void mothersClassReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orientationSchedSET.mothers_class1' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'orientationSchedSET.mothers_class' table. You can move, or remove it, as needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mothers_class1TableAdapter.Fill(this.orientationSchedSET.mothers_class1, metroDateTime1.Value, metroDateTime2.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
