using MetroFramework;
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

using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace sadProject
{
    public partial class main : MetroForm
    {
        
        public main()
        {
            InitializeComponent();
        }



        string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";



        private void loadData()
        {

            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            try{

            DataTable incomingExpiry = new DataTable();
            string incomingExpiryDisplay = "SELECT msi.SupplyID, rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE DATEDIFF(CURDATE(), ExpirationDate)+7 <=7 AND DATEDIFF(CURDATE(), ExpirationDate)+7 >=0 AND status <> 'Expired';";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand expiryCom = new MySqlCommand(incomingExpiryDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(expiryCom);
            da4.Fill(incomingExpiry);
            dataGridView1.DataSource = incomingExpiry;

                if (dataGridView1.Rows.Count != 0)
                {
                    MessageBox.Show("" + (dataGridView1.Rows.Count - 1 ) + " items incoming expire medical supplies!");
                }

                }
                catch(Exception ex)
                {

             
                }
            

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
            loadData();
            panel2.Visible = false;
            panel3.Visible = false;
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
            patientDiagnosisReport mr = new patientDiagnosisReport();
            mr.ShowDialog(this);
        }


        private void button13_Click(object sender, EventArgs e)
        {
            Orientation_Sched_Planner osp = new Orientation_Sched_Planner();
            osp.ShowDialog(this);
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
            MedicalSuppliesReport isr = new MedicalSuppliesReport();
            isr.ShowDialog(this);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            searchMedicalSupplies searchMS = new searchMedicalSupplies();
            searchMS.ShowDialog(this);
        }



        private void button20_Click_1(object sender, EventArgs e)
        {
            DisposeMed dm = new DisposeMed();
            dm.ShowDialog(this);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(Owner,"Are you sure you want to logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog(this);
            }
        }
    }
}
