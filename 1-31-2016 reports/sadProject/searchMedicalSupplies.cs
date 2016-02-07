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
           // listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
        }
        private void loadRequisitionData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable requestTable = new DataTable();
            string requestDisplay = "SELECT r.DateOfRequisition AS Date_of_Requisition, ms.fullName AS Requested_By, rl.listMed AS List_of__Requested_Medical_Supplies from requisition r LEFT JOIN requisition_line rl ON r.idRequisition = Requisition_idRequisition LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = r.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY idRequisition DESC;";
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
            string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rr.idReceivingReport DESC;";
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
            string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, ms.fullName AS Received_By, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, rl.Quantity as Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rr.idReceivingReport DESC;";
            //with total quantity
            //string receiveDisplay = "SELECT rr.DateOfReceive as Date_of_Receive, CONCAT(ms.LastName, ',' ,ms.StaffType) AS Staff, CONCAT(mn.MedicineName, ',' ,mn.UnitType) AS Medicine, SUM(rl.Quantity) as Total_Quantity, rl.ExpirationDate as Expiration_Date FROM receiving_report rr LEFT JOIN receiving_line rl ON rl.idReceivingReport = rr.idReceivingReport LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = rr.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY rl.SupplyID ORDER BY rl.SupplyID DESC;";
            MySqlCommand receiveCommand = new MySqlCommand(receiveDisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(receiveCommand);
            da4.Fill(receiveTable);
            dataGridView1.DataSource = receiveTable;

            DataTable requestTable = new DataTable();
            string requestDisplay = "SELECT r.DateOfRequisition AS Date_of_Requisition, ms.fullName AS Requested_By, rl.listMed AS List_of__Requested_Medical_Supplies from requisition r LEFT JOIN requisition_line rl ON r.idRequisition = Requisition_idRequisition LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = rl.SupplyID LEFT JOIN medical_staff ms ON ms.StaffID = r.StaffID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY idRequisition DESC;";
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
                       + this.dateRequest.Value.ToString("yyyy/MM/dd hh:mm") +
                       "');";

                string requisitionLine = "INSERT INTO requisition_line (Requisition_idRequisition, listMed) VALUES ((select idRequisition from requisition order by idRequisition desc limit 1),'"
                    + this.richTextBox1.Text +
                        "');";

             

                    /*
                    for (int i = 0; i <= listBox1.Items.Count; i++)
                    {
                        string sql = "insert into requisition_med_list (idRequisition, list_med) values((select idRequisition from requisition order by idRequisition desc limit 1),'" + this.listBox1.Items[i] + "')";

                        MySqlConnection listConn = new MySqlConnection(myConnection);
                        MySqlCommand listCom = new MySqlCommand(sql, listConn);
                        listConn.Open();
                        listCom.ExecuteNonQuery();
                    }
                */
                if(this.fullName.Text == "")
                {
                    MessageBox.Show("Full Name must not empty","error");
                }
                else if(this.richTextBox1.Text == "")
                {
                    MessageBox.Show("You must Save All Supply List","error");
                }
                else if(this.fullName.Text == "" && this.richTextBox1.Text == "")
                {
                    MessageBox.Show("Full Name and List must not be empty.","error");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
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
                        MessageBox.Show("SUCCESSFULLY REQUESTED");
                        myConn.Close();

                        fullName.Text = "";
                        quantity.Text = "";
                        button6_Click(sender, e);
                        button4_Click(sender, e);

                        loadRequisitionData();
                    }
                    else
                    {

                    }
                }
              


                
                

                
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
                       + this.dateReceive.Value.ToString("yyyy/MM/dd hh:mm") +
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

                if (this.receivedQuantity.Text == "" && this.receivefullName.Text == "")
                {
                    MessageBox.Show("Quantity must not be empty.","error");
                }
                else if(this.receivefullName.Text =="")
                {
                    MessageBox.Show("Full Name must not be empty.", "error");
                }
                else if(this.receivedQuantity.Text == "")
                {
                    MessageBox.Show("Quantity and Full Name must not be empty.", "error");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        receivedCom.ExecuteReader();
                        reqCommand.ExecuteReader();
                        reqlineCommand.ExecuteReader();
                        updateCom.ExecuteReader();
                        MessageBox.Show("SUCCESSFULLY RECEIVED");
                        myConn.Close();

                        loadReceiveData();
                    }
                    else
                    {

                    }
                }
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            if(this.quantity.Text != "")
            {
                listBox1.Items.Add(" | " + this.med_supplies.Text.ToString() + ", \t \t \t" + this.quantity.Text.ToString()+ " ");
                this.quantity.Focus();
                this.quantity.Clear();
            }
            else
            {
                MessageBox.Show("Please enter quantity","error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.quantity.Focus();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          if(this.listBox1.SelectedIndex >= 0)
          {
              this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
          }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedItems.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                button3_Click_1(sender, e);
                StringBuilder sb = new StringBuilder();
                foreach (object row in listBox1.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                richTextBox1.SelectedText = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void receivedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void receivefullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8 && e.KeyChar != (char)44;
        }

        private void fullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8 && e.KeyChar != (char)44;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
