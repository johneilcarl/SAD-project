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
    public partial class main : MetroForm
    {
        
        public main()
        {
            InitializeComponent();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            PMSboxes patient = new PMSboxes();
           //patient.instance.Show();
            patient.ShowDialog(this);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?","LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MCInventory mci = new MCInventory();
            mci.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventorySubsystem inventSub = new InventorySubsystem();
            inventSub.ShowDialog(this);
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
