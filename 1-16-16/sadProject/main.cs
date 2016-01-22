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
           /* PMSboxes patient = new PMSboxes();
           //patient.instance.Show();
            patient.MdiParent = this;
            patient.Show();*/

            panel2.Visible = false;
            panel3.Visible = false;
        
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
            /*MCInventory mci = new MCInventory();
            mci.ShowDialog(this);*/
            panel2.Visible = true;
            panel3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*InventorySubsystem inventSub = new InventorySubsystem();
            inventSub.ShowDialog(this);*/
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void main_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            createpatientform cpf = new createpatientform();
            cpf.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            recordPatDiagnosis rpd = new recordPatDiagnosis();
            rpd.ShowDialog(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            searchpatientform spf = new searchpatientform();
            spf.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            distributeMeds dm = new distributeMeds();
            dm.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            monthlyReport mr = new monthlyReport();
            mr.ShowDialog(this);
        }


        private void button13_Click(object sender, EventArgs e)
        {
            createnewOrientation cnO = new createnewOrientation();
            cnO.ShowDialog(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mothersClassReport mcr = new mothersClassReport();
            mcr.ShowDialog(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            distributeMeds dm = new distributeMeds();
            dm.ShowDialog(this);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            medicalSuppliesInventory msibox = new medicalSuppliesInventory();
            msibox.ShowDialog(this);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            inventorySubReport isr = new inventorySubReport();
            isr.ShowDialog(this);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            searchMedicalSupplies searchMS = new searchMedicalSupplies();
            searchMS.ShowDialog(this);
        }
    }
}
