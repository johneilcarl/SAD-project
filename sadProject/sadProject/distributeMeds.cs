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
            
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "totalQuantity";
            
            
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {
                string update_totalQuantity = "UPDATE medical_supplies_inventory SET totalQuantity = (totalQuantity - '" + this.quantity.Text + "') WHERE SupplyID =" + this.medicineName.SelectedValue + ";";

                string issuanceQuery = "INSERT INTO issuance (DateOfIssuance) VALUES ('"
                       + this.dispenseDate.Value.ToString("yyyy/MM/dd") +
                       "');";

                string issuance_line = "INSERT INTO issuance_line (IssuanceID, SupplyID, Quantity, ExpirationDate) VALUES ((SELECT IssuanceID FROM issuance ORDER BY IssuanceID desc limit 1),'"
                        + this.medicineName.SelectedValue + "','"
                        + this.quantity.Text + "','"
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

                issCom.ExecuteReader();
                isslineCom.ExecuteReader();
                updateCom.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY DISPENSE");
                myConn.Close();

                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void distributeMeds_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(medicineName.SelectedValue == this.medicineName.SelectedValue)
            {
                DataTable dtt = new DataTable();
                string query = "select * from medical_supplies_inventory where SupplyID= "+this.medicineName.SelectedValue+";";
                MySqlConnection conn = new MySqlConnection(MyConnection2);
                MySqlCommand medCom = new MySqlCommand(query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(medCom);
                sda.Fill(dtt);

                for(int i = 0; i < dtt.Rows[0]["totalQuantity"].ToString(); i++)
                {

                }
                
            }*/
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
