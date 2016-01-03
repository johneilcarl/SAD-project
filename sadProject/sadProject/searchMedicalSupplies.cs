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
    public partial class searchMedicalSupplies : Form
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
            string requestDisplay = "SELECT r.DateOfRequisition AS Date_of_Requisition, CONCAT(ms.LastName, ',' , ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' , mn.UnitType) AS Medicine, rl.Quantity as Quantity from requisition r LEFT JOIN requisition_line rl ON r.idRequisition = Requisition_idRequisition LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = r.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY idRequisition ORDER BY idRequisition DESC;";
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
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rr.idReceivingReport;";
            string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand receiveCommand = new MySqlCommand(receiveDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(receiveCommand);
            da4.Fill(receiveTable);
            dataGridView1.DataSource = receiveTable;

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

        }

        private void loadAllData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable receiveTable = new DataTable();
            string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rr.idReceivingReport ORDER BY rl.SupplyID DESC;";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand receiveCommand = new MySqlCommand(receiveDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(receiveCommand);
            da4.Fill(receiveTable);
            dataGridView1.DataSource = receiveTable;

            DataTable requestTable = new DataTable();
            string requestDisplay = "SELECT r.DateOfRequisition AS Date_of_Requisition, CONCAT(ms.LastName, ',' , ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' , mn.UnitType) AS Medicine, rl.Quantity as Quantity from requisition r LEFT JOIN requisition_line rl ON r.idRequisition = Requisition_idRequisition LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = r.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY idRequisition ORDER BY idRequisition DESC;";
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

            DataTable dt3 = new DataTable();
            string medstaff = "SELECT CONCAT(LastName , ', ' , FirstName) AS staff, StaffID FROM medical_staff";
            MySqlCommand mycommand3 = new MySqlCommand(medstaff, myconn);
            MySqlDataAdapter da3 = new MySqlDataAdapter(mycommand3);
            da3.Fill(dt3);

            staffId.DataSource = dt3;
            staffId.DisplayMember = "staff";
            staffId.ValueMember = "StaffID";
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchMedicalSupplies_Load(object sender, EventArgs e)
        {


        
            //dateReceived.MinDate = DateTime.Now;
            dateReceived.MaxDate = DateTime.Now;
            loadAllData();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {

                string requisition = "INSERT INTO requisition (StaffID, DateOfRequisition) VALUES ('"
                       + this.staffId.SelectedValue + "','"
                       + this.dateRequest.Value.ToString("yyyy/MM/dd") +
                       "');";

                string requisitionLine = "INSERT INTO requisition_line (Requisition_idRequisition, SupplyID, Quantity) VALUES ((select idRequisition from requisition order by idRequisition desc limit 1),'"
                    + this.med_supplies.SelectedValue + "','"
                        + this.metroTextBox1.Text +
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand reqCommand = new MySqlCommand(requisition, myConn);
                myConn.Open();

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand reqlineCommand = new MySqlCommand(requisitionLine, myConn2);
                myConn2.Open();

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

                string receiving_report = "INSERT INTO receiving_report (StaffID, DateOfReceive) VALUES ('"
                       + this.staffId.SelectedValue + "','"
                       + this.dateReceived.Value.ToString("yyyy/MM/dd") +
                       "');";

                string receiving_line = "INSERT INTO receiving_line (idReceivingReport, SupplyID, Quantity, ExpirationDate) VALUES ((SELECT idReceivingReport FROM receiving_report order by idReceivingReport desc limit 1),'"
                        + this.receiveMed.SelectedValue + "','"
                        + this.metroTextBox2.Text + "','"
                        +this.dateRestock.Value.ToString("yyyy/MM/dd") +
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand reqCommand = new MySqlCommand(receiving_report, myConn);
                myConn.Open();

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand reqlineCommand = new MySqlCommand(receiving_line, myConn2);
                myConn2.Open();

                reqCommand.ExecuteReader();
                reqlineCommand.ExecuteReader();
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
