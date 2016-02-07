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


            DataTable incomingExpiry = new DataTable();
            string incomingExpiryDisplay = "SELECT msi.SupplyID, rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE DATEDIFF(CURDATE(), ExpirationDate)+7 <=7 AND DATEDIFF(CURDATE(), ExpirationDate)+7 >=0;";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand expiryCom = new MySqlCommand(incomingExpiryDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(expiryCom);
            da4.Fill(incomingExpiry);
            dataGridView1.DataSource = incomingExpiry;

            DataTable expiredMed = new DataTable();
            string expiredDis = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE rl.ExpirationDate <= CURDATE();";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand expiredCommand = new MySqlCommand(expiredDis, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(expiredCommand);
            da1.Fill(expiredMed);
            dataGridView2.DataSource = expiredMed;

            /*for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                
                string expired = dataGridView1.Rows[rows].Cells[5].Value.ToString();
                string quantity = dataGridView1.Rows[rows].Cells[4].Value.ToString();
                string medicinename = dataGridView1.Rows[rows].Cells[3].Value.ToString();
                string supplyid = dataGridView1.Rows[rows].Cells[0].Value.ToString();

                DateTime expiredDate = Convert.ToDateTime(expired);
                //MessageBox.Show(supplyid);
                string updateTotalQuantity = "UPDATE medical_supplies_inventory SET totalQuantity = (totalQuantity - " + quantity + ") WHERE SupplyID =" + supplyid + ";";
                MySqlConnection myconn6 = new MySqlConnection(MyConnection2);
                MySqlCommand updatecom = new MySqlCommand(updateTotalQuantity, myconn6);
                myconn6.Open();

                string insertDispose = "INSERT INTO disposemedical_supplies (date_of_dispose, medicineName, quantity) VALUES ('"
                          + expired + "','"
                          + medicinename + "','"
                          + quantity +
                          "');";

                MySqlConnection myConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand disposeCom = new MySqlCommand(insertDispose, myConn2);
                myConn2.Open();


                if (DateTime.Now.Date == expiredDate)
                {
                    MessageBox.Show("success updated");
                    //MessageBox.Show(expired + "," + quantity + DateTime.Now.Date + " " + supplyid );
                    disposeCom.ExecuteReader();
                    updatecom.ExecuteReader();

                    
 
                    
                    
             
                    
                }

               // MessageBox.Show(check);
               // myConn2.Close();
                // myconn6.Close();
            }*/

        }

        private void disposeData()
        {

            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable incomingExpiry = new DataTable();
            string incomingExpiryDisplay = "SELECT msi.SupplyID, rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName WHERE DATEDIFF(CURDATE(), ExpirationDate)+7 <=7 AND DATEDIFF(CURDATE(), ExpirationDate)+7 >=0;";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand expiryCom = new MySqlCommand(incomingExpiryDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(expiryCom);
            da4.Fill(incomingExpiry);
            dataGridView1.DataSource = incomingExpiry;

            try
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {

                    string expiredd = dataGridView1.Rows[rows].Cells[5].Value.ToString();
                    string quantity = dataGridView1.Rows[rows].Cells[4].Value.ToString();
                    string supplyid = dataGridView1.Rows[rows].Cells[0].Value.ToString();

                    DateTime expiredDate = Convert.ToDateTime(expiredd);
                    //MessageBox.Show(supplyid);
                    string updateTotalQuantity = "UPDATE medical_supplies_inventory SET totalQuantity = (totalQuantity - " + quantity + ") WHERE SupplyID =" + supplyid + ";";
                    MySqlConnection myconn6 = new MySqlConnection(MyConnection2);
                    MySqlCommand updatecom = new MySqlCommand(updateTotalQuantity, myconn6);
                    myconn6.Open();

                    if (DateTime.Now.Date == expiredDate)
                    {
                            //MessageBox.Show(expiredDate + "," + quantity + DateTime.Now.Date + " " + supplyid);
                            updatecom.ExecuteReader();


                       // MessageBox.Show("success updated");


                        
                    }

                    // MessageBox.Show(check);
                    // myconn6.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Successfully disposed!");
            }

        }
           

        private void DisposeMed_Load(object sender, EventArgs e)
        {
            //if (current)
            loadData();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

 


        private void button2_Click(object sender, EventArgs e)
        {

            disposeData();
        }

    }
}
