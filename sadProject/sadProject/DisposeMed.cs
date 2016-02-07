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
using MetroFramework.Forms;

namespace sadProject
{
    public partial class DisposeMed : MetroForm
    {
        public DisposeMed()
        {
            InitializeComponent();
        }

        string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

 

        private void loadData()
        {
            
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            //getting the values
            DataTable incomingExpiry = new DataTable();
            string incomingExpiryDisplay = "SELECT rl.idReceivingReport,msi.SupplyID, rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date, rl.status FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE DATEDIFF(CURDATE(), ExpirationDate)+7 <=7 AND DATEDIFF(CURDATE(), ExpirationDate)+7 >=0 AND status <> 'Expired';";
       
            MySqlCommand expiryCom = new MySqlCommand(incomingExpiryDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(expiryCom);
            da4.Fill(incomingExpiry);
            dataGridView1.DataSource = incomingExpiry;

            //displaying the incoming expiry supplies
            DataTable expiry = new DataTable();
            string ExpiryDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE DATEDIFF(CURDATE(), ExpirationDate)+7 <=7 AND DATEDIFF(CURDATE(), ExpirationDate)+7 >=0 AND status <> 'Expired';";
            MySqlCommand expiryCom2 = new MySqlCommand(ExpiryDisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(expiryCom2);
            da5.Fill(expiry);
            displayExpiry.DataSource = expiry;

            //display the expired supplies
            DataTable expiredMed = new DataTable();
            string expiredDis = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE rl.ExpirationDate <= CURDATE();";
            MySqlCommand expiredCommand = new MySqlCommand(expiredDis, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(expiredCommand);
            da1.Fill(expiredMed);
            dataGridView2.DataSource = expiredMed;


        }

        private void disposeData()
        {

            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable incomingExpiry = new DataTable();
            string incomingExpiryDisplay = "SELECT rl.idReceivingReport, msi.SupplyID, rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date, rl.status FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE DATEDIFF(CURDATE(), ExpirationDate)+7 <=7 AND DATEDIFF(CURDATE(), ExpirationDate)+7 >=0 AND rl.Quantity > 0 AND status <> 'Expired';";
            MySqlCommand expiryCom = new MySqlCommand(incomingExpiryDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(expiryCom);
            da4.Fill(incomingExpiry);
            dataGridView1.DataSource = incomingExpiry;

            try
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {

                    string expiredd = dataGridView1.Rows[rows].Cells[6].Value.ToString();
                    string quantity = dataGridView1.Rows[rows].Cells[5].Value.ToString();
                    string supplyid = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                    string idreport = dataGridView1.Rows[rows].Cells[0].Value.ToString();

                    DateTime expiredDate = Convert.ToDateTime(expiredd);
                    //MessageBox.Show(supplyid);
                    string updateTotalQuantity = "UPDATE medical_supplies_inventory SET totalQuantity = (totalQuantity - " + quantity + ") WHERE SupplyID =" + supplyid + ";";
                    MySqlConnection myconn6 = new MySqlConnection(MyConnection2);
                    MySqlCommand updatecom = new MySqlCommand(updateTotalQuantity, myconn6);
                    myconn6.Open();

                    string checkStatus = "UPDATE receiving_line SET status = 'Expired' WHERE idReceivingReport =" + idreport + ";";
                    MySqlConnection myconn8 = new MySqlConnection(MyConnection2);
                    MySqlCommand checksCom = new MySqlCommand(checkStatus, myconn8);
                    myconn8.Open();

                    if (DateTime.Now.Date == expiredDate)
                    {

                            updatecom.ExecuteReader();
                            checksCom.ExecuteReader();

                        
                    }
                     myconn6.Close();
                     myconn8.Close();
                }

            }
            catch (Exception ex)
            {
               // MessageBox.Show("Successfully disposed!");

                MessageBox.Show(ex.Message);
            }

        }
           

        private void DisposeMed_Load(object sender, EventArgs e)
        {
            loadData();
        }

        // will close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //int checks = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //disposeData();

            if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                    disposeData();
                    loadData();
             
            }
            else
            {

            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
                toolTip1.SetToolTip(button2, "Stock out all Expired Medical Supplies");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
