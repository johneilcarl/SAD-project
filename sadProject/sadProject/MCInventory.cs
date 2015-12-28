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
    public partial class MCInventory : MetroForm
    {
        public MCInventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            distributeMeds dm = new distributeMeds();
            dm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createnewOrientation cnO = new createnewOrientation();
            cnO.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mothersClassReport mcr = new mothersClassReport();
            mcr.ShowDialog(this);
        }

        private void MCInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
