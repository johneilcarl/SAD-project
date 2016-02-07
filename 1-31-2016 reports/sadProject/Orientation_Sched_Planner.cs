using MetroFramework.Forms;
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
    public partial class Orientation_Sched_Planner : MetroForm
    {
        public Orientation_Sched_Planner()
        {
            InitializeComponent();
        }

        string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable mothersclass = new DataTable();
            string displayclass = "SELECT * FROM mothers_class;";
            MySqlCommand motherCom = new MySqlCommand(displayclass, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(motherCom);
            da1.Fill(mothersclass);
            dataGridView1.DataSource = mothersclass;

            DataTable participants = new DataTable();
            string displayParti = "SELECT * FROM participants;";
            MySqlCommand partCom = new MySqlCommand(displayParti, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(partCom);
            da2.Fill(participants);
            dataGridView2.DataSource = participants;

        }

        private void Orientation_Sched_Planner_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                        string createOrient = "INSERT INTO mothers_class (OrientationDate, OrientationTimeStart, OrientationTimeEnd) VALUES ('"
                       + this.monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd") + "','"
                       + this.textBox1.Text + "','"
                       + this.textBox2.Text +
                       "');";

                        MySqlConnection myConn = new MySqlConnection(myConnection);
                        MySqlCommand orientCom = new MySqlCommand(createOrient, myConn);
                        myConn.Open();

                        orientCom.ExecuteReader();
                        MessageBox.Show("Created Orientation");
                        loadData();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string add_participants = "INSERT INTO participants (OrientationID, firstName, middleName, lastName, gender, birthDate) VALUES ((SELECT OrientationID FROM mothers_class ORDER BY OrientationID Desc LIMIT 1), '"
               + this.textBox3.Text + "','"
               + this.textBox4.Text + "','"
               + this.textBox5.Text + "','"
               + this.comboBox1.SelectedItem + "','"
               + this.dateTimePicker1.Value.ToString("yyyy/MM/dd") +
               "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand addCom = new MySqlCommand(add_participants, myConn);
                myConn.Open();

                addCom.ExecuteReader();
                MessageBox.Show("added patient");

                loadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
