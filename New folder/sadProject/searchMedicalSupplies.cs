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
    public partial class searchMedicalSupplies : MetroForm
    {
        public searchMedicalSupplies()
        {
            InitializeComponent();
        }
        private void loadRequisitionData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable requestTable = new DataTable();
            string requestDisplay = "SELECT r.DateOfRequisition AS Date_of_Requisition, ms.fullName AS Staff_Name, CONCAT(mn.MedicineName, ',' , mn.UnitType) AS Medicine, rl.Quantity as Quantity from requisition r LEFT JOIN requisition_line rl ON r.idRequisition = Requisition_idRequisition LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = r.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY idRequisition DESC;";
            MySqlCommand requestCommand = new MySqlCommand(requestDisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(requestCommand);
            da5.Fill(requestTable);
            dataGridView2.DataSource = requestTable;

            //requisition combobox
            DataTable dt2 = new DataTable();
            //string request = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            string request = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, SupplyID FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";

            MySqlCommand mycommand2 = new MySqlCommand(request, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);

            med_supplies.DataSource = dt2;
            med_supplies.DisplayMember = "Medicine";
            med_supplies.ValueMember = "SupplyID";

            med_supplies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            med_supplies.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            med_supplies.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void loadReceiveData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable receiveTable = new DataTable();
            string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Staff_Name, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rr.idReceivingReport DESC;";
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand receiveCommand = new MySqlCommand(receiveDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(receiveCommand);
            da4.Fill(receiveTable);
            dataGridView1.DataSource = receiveTable;
            /*
            //restock combobox
            DataTable dt1 = new DataTable();
            //string restock = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            string restock = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, SupplyID FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";
            MySqlCommand mycommand1 = new MySqlCommand(restock, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand1);
            da1.Fill(dt1);

            receiveMed.DataSource = dt1;
            receiveMed.DisplayMember = "Medicine";
            receiveMed.ValueMember = "SupplyID";

            receiveMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            receiveMed.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            receiveMed.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            */
        }

        private void loadAllData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable receiveTable = new DataTable();
            string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Staff_Name, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rr.idReceivingReport ORDER BY rl.SupplyID DESC;";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand receiveCommand = new MySqlCommand(receiveDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(receiveCommand);
            da4.Fill(receiveTable);
            dataGridView1.DataSource = receiveTable;

            DataTable requestTable = new DataTable();
            string requestDisplay = "SELECT r.DateOfRequisition AS Date_of_Requisition, ms.fullName AS Staff_Name, CONCAT(mn.MedicineName, ',' , mn.UnitType) AS Medicine, rl.Quantity as Quantity from requisition r LEFT JOIN requisition_line rl ON r.idRequisition = Requisition_idRequisition LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = r.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY idRequisition DESC;";
            MySqlCommand requestCommand = new MySqlCommand(requestDisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(requestCommand);
            da5.Fill(requestTable);
            dataGridView2.DataSource = requestTable;


            //restock combobox
            DataTable dt1 = new DataTable();
            //string restock = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            string restock = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, SupplyID FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";
            MySqlCommand mycommand1 = new MySqlCommand(restock, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand1);
            da1.Fill(dt1);

            receiveMed.DataSource = dt1;
            receiveMed.DisplayMember = "Medicine";
            receiveMed.ValueMember = "SupplyID";

            receiveMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            receiveMed.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            receiveMed.AutoCompleteSource = AutoCompleteSource.ListItems;
        
            //requisition combobox
            DataTable dt2 = new DataTable();
            //string request = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            string request = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, SupplyID FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";

            MySqlCommand mycommand2 = new MySqlCommand(request, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);

            med_supplies.DataSource = dt2;
            med_supplies.DisplayMember = "Medicine";
            med_supplies.ValueMember = "SupplyID";

            med_supplies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            med_supplies.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            med_supplies.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchMedicalSupplies_Load(object sender, EventArgs e)
        {


        
            //dateReceived.MinDate = DateTime.Now;
            dateReceive.MaxDate = DateTime.Now;
            loadAllData();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {
                string requestBy = "INSERT INTO medical_staff (fullName) VALUES ('"
                       + this.fullName.Text +
                       "');";

                string requisition = "INSERT INTO requisition (StaffID, DateOfRequisition) VALUES ((SELECT StaffID FROM medical_staff ORDER BY StaffID DESC LIMIT 1),'"
                       + this.dateRequest.Value.ToString("yyyy/MM/dd") +
                       "');";

                string requisitionLine = "INSERT INTO requisition_line (Requisition_idRequisition, SupplyID, Quantity) VALUES ((select idRequisition from requisition order by idRequisition desc limit 1),'"
                    + this.med_supplies.SelectedValue + "','"
                    + this.quantity.Text +
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand reqCommand = new MySqlCommand(requisition, myConn);
                myConn.Open();

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand reqlineCommand = new MySqlCommand(requisitionLine, myConn2);
                myConn2.Open();

                MySqlConnection myConn3 = new MySqlConnection(myConnection);
                MySqlCommand nameCommand = new MySqlCommand(requestBy, myConn3);
                myConn3.Open();

                nameCommand.ExecuteReader();
                reqCommand.ExecuteReader();
                reqlineCommand.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY REQUEST");
                myConn.Close();


                loadRequisitionData();
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {
                string receivedBy = "INSERT INTO medical_staff (fullName) VALUES ('"
                      + this.receivefullName.Text +
                      "');";

                string update_totalQuantity = "UPDATE medical_supplies_inventory SET totalQuantity = (totalQuantity + '" + this.receivedQuantity.Text + "') WHERE SupplyID =" + this.receiveMed.SelectedValue +";";

                string receiving_report = "INSERT INTO receiving_report (StaffID, DateOfReceive) VALUES ((SELECT StaffID FROM medical_staff ORDER BY StaffID DESC LIMIT 1),'"
                       + this.dateReceive.Value.ToString("yyyy/MM/dd") +
                       "');";

                string receiving_line = "INSERT INTO receiving_line (idReceivingReport, SupplyID, Quantity, ExpirationDate) VALUES ((SELECT idReceivingReport FROM receiving_report ORDER BY idReceivingReport DESC LIMIT 1),'"
                        + this.receiveMed.SelectedValue + "','"
                        + this.receivedQuantity.Text + "','"
                        +this.expireDate.Value.ToString("yyyy/MM/dd") +
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand reqCommand = new MySqlCommand(receiving_report, myConn);
                myConn.Open();

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand reqlineCommand = new MySqlCommand(receiving_line, myConn2);
                myConn2.Open();

                MySqlConnection myConn3 = new MySqlConnection(myConnection);
                MySqlCommand updateCom = new MySqlCommand(update_totalQuantity, myConn3);
                myConn3.Open();

                MySqlConnection myConn4 = new MySqlConnection(myConnection);
                MySqlCommand receivedCom = new MySqlCommand(receivedBy, myConn4);
                myConn4.Open();

                receivedCom.ExecuteReader();
                reqCommand.ExecuteReader();
                reqlineCommand.ExecuteReader();
                updateCom.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY RECEIVED");
                myConn.Close();

                loadReceiveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void staffId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateRestock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateReceived_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
