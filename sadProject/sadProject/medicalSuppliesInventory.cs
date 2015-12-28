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
            string medicineDisplay = "SELECT MedicineName, UnitType FROM medicine_name";
            MySqlCommand mycommand = new MySqlCommand(medicineDisplay, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            string PatientReference = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
            MySqlCommand mycommand2 = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);

            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Medicine";
            comboBox1.ValueMember = "idMedicineName";

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
    }
}
