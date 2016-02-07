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
    public partial class viewSchedule : MetroForm
    {
        public viewSchedule()
        {
            InitializeComponent();
        }
        string MyConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
        private void loadData()
        {

            MySqlConnection myconn = new MySqlConnection(MyConnection);

            DataTable listofParticipants = new DataTable();
            string displayParti = "SELECT p.firstName AS FirstName, p.lastName AS LastName, p.middleName AS MiddleName, p.birthDate AS Birthdate,p.gender AS Gender FROM participants p LEFT JOIN mothers_class mc ON mc.OrientationID = p.OrientationID WHERE p.OrientationID =" + this.id.Text +";";
            MySqlCommand partCom = new MySqlCommand(displayParti, myconn);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(partCom);
            dataAdapter1.Fill(listofParticipants);
            dataGridView1.DataSource = listofParticipants;


            int totalpart = dataGridView1.Rows.Count - 1;
            this.totalparticipants.Text = totalpart.ToString();


            button8.Visible = false;
        }
        private void viewSchedule_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string add_participants = "INSERT INTO participants (OrientationID, firstName, lastName, middleName, gender, birthDate) VALUES ('"
               + this.id.Text + "','"
               + this.firstName.Text + "','"
               + this.lastName.Text + "','"
               + this.middleName.Text + "','"
               + this.gender.SelectedItem + "','"
               + this.birthDate.Value.ToString("yyyy/MM/dd") +
               "');";

                MySqlConnection myConn = new MySqlConnection(MyConnection);
                MySqlCommand addCom = new MySqlCommand(add_participants, myConn);

                if(firstName.Text =="" || lastName.Text == "" || middleName.Text =="")
                {
                    MessageBox.Show("check the input fields!");
                }
                else
                {
                    myConn.Open();
                    addCom.ExecuteReader();
                    addtolist();
                    MessageBox.Show("added new patient");
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addtolist()
        {
            if (this.firstName.Text != "" && this.lastName.Text != "" && this.middleName.Text != "")
            {
                listBox1.Items.Add(this.lastName.Text.ToString() + ", " + this.firstName.Text.ToString() + " " + this.middleName.Text.ToString());
            }
            else
            {
                MessageBox.Show("Check the field names", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true; //save changes
            button5.Visible = false; //close button
            button6.Visible = true; //save changes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE mothers_class mc set OrientationDescription = '" + this.richTextBox1.Text + "' WHERE OrientationID ='" + this.id.Text + "';";
            MySqlConnection myConn = new MySqlConnection(MyConnection);
            MySqlCommand updateCom = new MySqlCommand(Query, myConn);
            

            if (MessageBox.Show("You want to save the changes?", "description", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                myConn.Open();
                updateCom.ExecuteReader();
                MessageBox.Show("saved!");
                button2.Visible = false;//save changes
                button6.Visible = false;//save changes
                button5.Visible = true; //close button
            }
            else
            {

            }

            myConn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            editDate.Visible = true;
            editTime1.Visible = true;
            editTime2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE mothers_class mc set OrientationDescription = '" + this.richTextBox1.Text + "' WHERE OrientationID ='" + this.id.Text + "';";
            MySqlConnection myConn = new MySqlConnection(MyConnection);
            MySqlCommand updateCom = new MySqlCommand(Query, myConn);


            if (MessageBox.Show("You want to save the changes?", "description", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                myConn.Open();
                updateCom.ExecuteReader();
                MessageBox.Show("saved!");
                button2.Visible = false;//save changes
                button6.Visible = false;//save changes
                button5.Visible = true; //close button
            }
            else
            {

            }

            myConn.Close();
        }

        private void editDate_TextChanged(object sender, EventArgs e)
        {
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {


            button8.Visible = false;
        }
    }
}
