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
    public partial class medicalSuppliesInventory : MetroForm
    {
        public medicalSuppliesInventory()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            DataTable dt1 = new DataTable();
            string medicineDisplay = "SELECT msi.idMedicineName AS ID_Medicine, mn.MedicineName AS Medicine_Name, mn.UnitType AS Unit_Type, msi.totalQuantity AS Total_Quantity FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";
            MySqlCommand mycommand = new MySqlCommand(medicineDisplay, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            string PatientReference = "SELECT CONCAT(mn.MedicineName , ', ' , mn.UnitType) AS Medicine, mn.idMedicineName FROM medicine_name mn LEFT JOIN medical_supplies_inventory msi ON msi.idMedicineName = mn.idMedicineName WHERE msi.idMedicineName = mn.idMedicineName;";
            MySqlCommand mycommand2 = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);

            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Medicine";
            comboBox1.ValueMember = "mn.idMedicineName";

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void medicalSuppliesInventory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {

                string medical_supplies = "INSERT INTO medical_supplies_inventory (idMedicineName) VALUES ('"
                       + this.metroTextBox3.Text +
                       "');";

                string medicine_name = "INSERT INTO medicine_name (idMedicineName, MedicineName, UnitType) VALUES ('"
                        + this.metroTextBox3.Text + "','"
                        + this.metroTextBox1.Text + "','"
                        + this.metroTextBox2.Text +
                        "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand supCom = new MySqlCommand(medical_supplies, myConn);
                myConn.Open();

                MySqlConnection myConn2 = new MySqlConnection(myConnection);
                MySqlCommand mednameCom = new MySqlCommand(medicine_name, myConn2);
                myConn2.Open();

                supCom.ExecuteReader();
                mednameCom.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY ADD");
                loadData();
                myConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
