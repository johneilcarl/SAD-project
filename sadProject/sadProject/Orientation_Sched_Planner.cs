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
            string displayclass = "select  mc.OrientationID AS id, mc.OrientationDescription AS Description, mc.OrientationDate AS Orientation_Date, mc.OrientationTimeStart AS Time_Start," +
                                  "mc.OrientationTimeEnd AS Time_End, count(*) AS Number_of_Participants from participants p " +
                                    "LEFT JOIN mothers_class mc ON mc.OrientationID = p.OrientationID GROUP BY p.OrientationID;";
            MySqlCommand motherCom = new MySqlCommand(displayclass, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(motherCom);
            da1.Fill(mothersclass);
            dataGridView1.DataSource = mothersclass;

            DataTable participants = new DataTable();
            string displayParti = "SELECT firstName, lastName, middleName, birthDate, gender FROM participants;";
            MySqlCommand partCom = new MySqlCommand(displayParti, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(partCom);
            da2.Fill(participants);
            dataGridView2.DataSource = participants;

        }

        private void loadSchedule()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable mothersclass = new DataTable();
            string displayclass = "select  mc.OrientationID AS id, mc.OrientationDescription AS Description, mc.OrientationDate AS Orientation_Date, mc.OrientationTimeStart AS Time_Start," +
                                  "mc.OrientationTimeEnd AS Time_End, count(*) AS Number_of_Participants from participants p " +
                                    "LEFT JOIN mothers_class mc ON mc.OrientationID = p.OrientationID GROUP BY p.OrientationID;";
            MySqlCommand motherCom = new MySqlCommand(displayclass, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(motherCom);
            da1.Fill(mothersclass);
            dataGridView1.DataSource = mothersclass;
        }

        private void Orientation_Sched_Planner_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                        string createOrient = "INSERT INTO mothers_class (OrientationDate, OrientationTimeStart, OrientationTimeEnd,OrientationDescription) VALUES ('"
                       + this.monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd") + "','"
                       + this.maskedTextBox1.Text + " " + this.metroComboBox1.Text + "','"
                       + this.maskedTextBox2.Text + " " + this.metroComboBox2.Text + "','"
                       + this.richTextBox1.Text + 
                       "');";

                        MySqlConnection myConn2 = new MySqlConnection(myConnection);
                        MySqlCommand orientCom = new MySqlCommand(createOrient, myConn2);
                        myConn2.Open();

                        orientCom.ExecuteReader();
                        MessageBox.Show("Created Orientation");
                        loadSchedule();
                        myConn2.Close();
                        
                        //button1.Visible = false;
                        button2.Visible = true;
                        button5.Visible = true;

                        


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
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
                addtolist();

                myConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addtolist()
        {
            if (this.textBox3.Text != "" && this.textBox4.Text != "" && this.textBox5.Text != "")
            {
                listBox1.Items.Add(this.textBox4.Text.ToString() + ", " + this.textBox3.Text.ToString() + " " + this.textBox5.Text.ToString());
            }
            else
            {
                MessageBox.Show("Check the field names", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("You want to create new schedule?", "new schedule?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            metroComboBox1.Text = "";
            metroComboBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value.ToString("");
            listBox1.Items.Clear();
            button4_Click(sender, e);
            button1.Visible = true;
            button2.Visible = false;
            button5.Visible = false;

            }
            else
            {

            }

        }
        void viewSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
            loadData();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewSchedule vs = new viewSchedule();
            vs.FormClosed += new FormClosedEventHandler(viewSchedule_FormClosed); //refresh the mother form when close the child form
            vs.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vs.richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //convert to shortdate ex. 00/00/0000
            string orientDate = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTime orientationDate = Convert.ToDateTime(orientDate);
            string shortDate = orientationDate.ToShortDateString();
            //
            vs.date.Text = shortDate;

            vs.timestart.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            vs.timeend.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            vs.totalparticipants.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

            vs.editDate2.Text = shortDate;
            vs.editTime1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            vs.editTime2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            vs.ShowDialog(this);
        }
    }
}
