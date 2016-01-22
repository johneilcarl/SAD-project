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
    public partial class distributeMeds : MetroForm
    {
        public distributeMeds()
        {
            InitializeComponent();
        }

        string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

        private void loadCombo()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable dt1 = new DataTable();
            string PatientReference = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, SupplyID FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";
            MySqlCommand medCom = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(medCom);
            da2.Fill(dt1);

            medicineName.DataSource = dt1;
            medicineName.DisplayMember = "Medicine";
            medicineName.ValueMember = "SupplyID";
        }
        
        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);
            
            DataTable dt1 = new DataTable();
            string PatientReference = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, SupplyID, totalQuantity FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";
            MySqlCommand medCom = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(medCom);
            da2.Fill(dt1);

            medicineName.DataSource = dt1;
            medicineName.DisplayMember = "Medicine";
            medicineName.ValueMember = "SupplyID";
            
            totalQuantity.DataSource = dt1;
            totalQuantity.DisplayMember = "totalQuantity";
            totalQuantity.ValueMember = "totalQuantity";
            
            
            
            medicineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            medicineName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            medicineName.AutoCompleteSource = AutoCompleteSource.ListItems;

 
            DataTable dispensetb = new DataTable();
            //string dispenseDisplay = "SELECT i.DateOfIssuance as Date_of_Issuance, CONCAT(mn.MedicineName, ',' ,mn.UnitType) as Medicine,  SUM(il.Quantity) as Quantity FROM issuance i LEFT JOIN issuance_line il ON i.IssuanceID = il.IssuanceID LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = il.SupplyID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY il.SupplyID;";
            string dispenseDisplay = "SELECT i.DateOfIssuance as Date_of_Issuance, CONCAT(mn.MedicineName, ',' ,mn.UnitType) as Medicine, il.Quantity as Quantity, il.ExpirationDate as Expiration_Date FROM issuance i LEFT JOIN issuance_line il ON i.IssuanceID = il.IssuanceID LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = il.SupplyID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY i.IssuanceID ORDER BY i.IssuanceID desc;";
            MySqlCommand disCom = new MySqlCommand(dispenseDisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(disCom);
            da5.Fill(dispensetb);
            dataGridView1.DataSource = dispensetb;

        }

        private void quantityLoad()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable dt1 = new DataTable();
            DataRowView vrow = (DataRowView)medicineName.SelectedItem;
            String value = vrow["SupplyID"].ToString();
            string PatientReference = "SELECT SupplyID, totalQuantity FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.SupplyID = '"+ value +"'";
            MySqlCommand medCom = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(medCom);
            da2.Fill(dt1);

           // MessageBox.Show("" + value);

            totalQuantity.DataSource = dt1;
            totalQuantity.DisplayMember = "totalQuantity";
            totalQuantity.ValueMember = "totalQuantity";

            /*for (int i = 0; i < Convert.ToInt64(this.totalQuantity.Text); i++)
            {
                comboBox1.Items.Add(i);
            }*/
        }
        private void loadGridview()
        {
            MySqlConnection myconn = new MySqlConnection(MyConnection2);
            DataTable dispensetb = new DataTable();
            //string dispenseDisplay = "SELECT i.DateOfIssuance as Date_of_Issuance, CONCAT(mn.MedicineName, ',' ,mn.UnitType) as Medicine,  SUM(il.Quantity) as Quantity FROM issuance i LEFT JOIN issuance_line il ON i.IssuanceID = il.IssuanceID LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = il.SupplyID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY il.SupplyID;";
            string dispenseDisplay = "SELECT i.DateOfIssuance as Date_of_Issuance, CONCAT(mn.MedicineName, ',' ,mn.UnitType) as Medicine, il.Quantity as Quantity, il.ExpirationDate as Expiration_Date FROM issuance i LEFT JOIN issuance_line il ON i.IssuanceID = il.IssuanceID LEFT JOIN medical_supplies_inventory msi ON msi.SupplyID = il.SupplyID LEFT JOIN medicine_name mn ON mn.idMedicineName = msi.idMedicineName GROUP BY i.IssuanceID ORDER BY i.IssuanceID desc;";
            MySqlCommand disCom = new MySqlCommand(dispenseDisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(disCom);
            da5.Fill(dispensetb);
            dataGridView1.DataSource = dispensetb;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {
                string update_totalQuantity = "UPDATE medical_supplies_inventory SET totalQuantity = (totalQuantity - '" + this.disQuantity.Text + "') WHERE SupplyID =" + this.medicineName.SelectedValue + ";";

                string issuanceQuery = "INSERT INTO issuance (DateOfIssuance) VALUES ('"
                       + this.dispenseDate.Value.ToString("yyyy/MM/dd hh:mm") +
                       "');";

                string issuance_line = "INSERT INTO issuance_line (IssuanceID, SupplyID, Quantity, ExpirationDate) VALUES ((SELECT IssuanceID FROM issuance ORDER BY IssuanceID desc limit 1),'"
                        + this.medicineName.SelectedValue + "','"
                        + this.disQuantity.Text + "','"
                        +this.expirationDate.Value.ToString("yyyy/MM/dd") +
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand issCom = new MySqlCommand(issuanceQuery, myConn);
                myConn.Open(); 

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand isslineCom = new MySqlCommand(issuance_line, myConn2);
                myConn2.Open();

                MySqlConnection myConn3 = new MySqlConnection(myConnection);
                MySqlCommand updateCom = new MySqlCommand(update_totalQuantity, myConn3);
                myConn3.Open();


                if (Convert.ToInt64(this.totalQuantity.Text) <= 10 && Convert.ToInt64(this.disQuantity.Text) <= 10 && Convert.ToInt64(this.disQuantity.Text) >= 1)
                {
                    if (MessageBox.Show("Need to restock, Click Yes to Force Dispense", "Force Dispense", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       
                        issCom.ExecuteReader();
                        isslineCom.ExecuteReader();
                        updateCom.ExecuteReader();
                        MessageBox.Show("SUCCESSFULLY DISPENSE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        myConn.Close();
                        //this.disQuantity.Text = "";
                        disQuantity.Items.Clear();

                        loadData();
                    }
                    else
                    {

                    }
                }
                else if (Convert.ToInt64(this.totalQuantity.Text) == Convert.ToInt64(this.disQuantity.Text))
                {
                    MessageBox.Show("Cannot Distribute All Instock.", "error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (Convert.ToInt64(this.totalQuantity.Text) - Convert.ToInt64(this.disQuantity.Text) < 10 && Convert.ToInt64(this.totalQuantity.Text) > 10) //check the minimum of supplies
                {
                    MessageBox.Show("Number of supplies must be minimum of '10' in order to restock, this will only left '" + (Convert.ToInt64(this.totalQuantity.Text) - Convert.ToInt64(this.disQuantity.Text)) + "' total of quantity,  the maximum number of quantity can only restock is '" + (Convert.ToInt64(this.totalQuantity.Text) - 10) + "' below.", "error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    issCom.ExecuteReader();
                    isslineCom.ExecuteReader();
                    updateCom.ExecuteReader();
                    MessageBox.Show("SUCCESSFULLY DISPENSE","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myConn.Close();

                    disQuantity.Items.Clear();
                    //this.disQuantity.Text = "";
                    loadData();
                }

                //loadGridview();
                //loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void distributeMeds_Load(object sender, EventArgs e)
        {
           
            loadCombo();
            //this.medicineName.Text = "";
        }



        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)8;
        }


        private void medicineName_SelectedIndexChanged(object sender, EventArgs e)
        {
           // quantityLoad();
        }

        private void medicineName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadGridview();
            quantityLoad();

            this.disQuantity.Text = "";
            disQuantity.Items.Clear();
            

            for (int i = 1; i <= Convert.ToInt64(this.totalQuantity.Text); i++)
            {
                disQuantity.Items.Add(i);
            }
        }
    }
}
