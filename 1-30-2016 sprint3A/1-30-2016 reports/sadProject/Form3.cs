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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthcenterDataSet9.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.healthcenterDataSet9.client,dateTimePicker1.Value,dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
