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
            string medicineDisplay = "SELECT * FROM medicine_name";
            MySqlCommand mycommand = new MySqlCommand(medicineDisplay, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void medicalSuppliesInventory_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
