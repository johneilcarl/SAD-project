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

        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable receiveTable = new DataTable();
            string receiveDisplay = "SELECT * from receiving_line";
            MySqlCommand receiveCommand = new MySqlCommand(receiveDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(receiveCommand);
            da4.Fill(receiveTable);
            dataGridView1.DataSource = receiveTable;

            DataTable requestTable = new DataTable();
            string requestDisplay = "SELECT * from requisition_line";
            MySqlCommand requestCommand = new MySqlCommand(requestDisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(requestCommand);
            da5.Fill(requestTable);
            dataGridView2.DataSource = requestTable;


            //restock combobox
            DataTable dt1 = new DataTable();
            string restock = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            MySqlCommand mycommand1 = new MySqlCommand(restock, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand1);
            da1.Fill(dt1);

            receiveMed.DataSource = dt1;
            receiveMed.DisplayMember = "Medicine";
            receiveMed.ValueMember = "idMedicineName";

            receiveMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            receiveMed.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            receiveMed.AutoCompleteSource = AutoCompleteSource.ListItems;
        
            //requisition combobox
            DataTable dt2 = new DataTable();
            string request = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            MySqlCommand mycommand2 = new MySqlCommand(request, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);

            med_supplies.DataSource = dt2;
            med_supplies.DisplayMember = "Medicine";
            med_supplies.ValueMember = "idMedicineName";

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
            loadData();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {

                string requisition = "INSERT INTO requisition (Medical_Staff_StaffID, DateOfRequisition) VALUES ('"
                       + this.staffId.SelectedValue + "','"
                       + this.dateRequest.Value.ToString("yyyy/MM/dd") +
                       "');";

                string requisitionLine = "INSERT INTO requisition_line (Medical_Supplies_Inventory_SupplyID, Quantity) VALUES ('"
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
                loadData();
                myConn.Close();

                
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

                string receiving_report = "INSERT INTO receiving_report (Medical_Staff_StaffID, DateOfReceive) VALUES ('"
                       + this.staffId.SelectedValue + "','"
                       + this.dateReceived.Value.ToString("yyyy/MM/dd") +
                       "');";

                string receiving_line = "INSERT INTO receiving_line (Medical_Supplies_Inventory_SupplyID, Quantity, ExpirationDate) VALUES ('"
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

                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
