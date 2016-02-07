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
    public partial class InventorySubsystem : MetroForm
    {
        public InventorySubsystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medicalSuppliesInventory msibox = new medicalSuppliesInventory();
            msibox.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchMedicalSupplies searchMS = new searchMedicalSupplies();
            searchMS.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void InventorySubsystem_Load(object sender, EventArgs e)
        {

        }
    }
}
