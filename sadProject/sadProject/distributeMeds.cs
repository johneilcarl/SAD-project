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
    public partial class distributeMeds : Form
    {
        public distributeMeds()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable dt1 = new DataTable();
            string PatientReference = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            MySqlCommand medCom = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(medCom);
            da2.Fill(dt1);

            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Medicine";
            comboBox1.ValueMember = "idMedicineName";

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dispensetb = new DataTable();
            string dispenseDisplay = "SELECT * from issuance_line";
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

                string issuanceQuery = "INSERT INTO issuance (DateOfIssuance) VALUES ('"
                       + this.issuanceDate.Value.ToString("yyyy/MM/dd") +
                       "');";

                string issuance_line = "INSERT INTO issuance_line (Medical_Supplies_Inventory_SupplyID, Quantity) VALUES ('"
                        + this.comboBox1.SelectedValue + "','"
                        + this.comboBox2.SelectedItem + 
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand issCom = new MySqlCommand(issuanceQuery, myConn);
                myConn.Open();

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand isslineCom = new MySqlCommand(issuance_line, myConn2);
                myConn2.Open();

                issCom.ExecuteReader();
                isslineCom.ExecuteReader();
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
    }
}
