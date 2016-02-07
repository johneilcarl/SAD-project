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

            //all participants
            DataTable listofParticipants = new DataTable();
            string displayParti = "SELECT p.firstName AS FirstName, p.lastName AS LastName, p.middleName AS MiddleName, p.birthDate AS Birthdate,p.gender AS Gender FROM participants p LEFT JOIN mothers_class mc ON mc.OrientationID = p.OrientationID WHERE p.OrientationID =" + this.id.Text +";";
            MySqlCommand partCom = new MySqlCommand(displayParti, myconn);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(partCom);
            dataAdapter1.Fill(listofParticipants);
            dataGridView1.DataSource = listofParticipants;


            int totalpart = dataGridView1.Rows.Count - 1;
            this.totalparticipants.Text = totalpart.ToString();


            //display
            DataTable displayAllPat = new DataTable();
            string displaySearchPatient = "SELECT FirstName,MiddleName,Lastname,Birthdate,Gender,LotNumber,Street,City,BarangayName FROM client;";
            MySqlCommand mycommand = new MySqlCommand(displaySearchPatient, myconn);
            MySqlDataAdapter dp1 = new MySqlDataAdapter(mycommand);
            dp1.Fill(displayAllPat);
            dataGridView3.DataSource = displayAllPat;

            //search patient
            DataTable dt3 = new DataTable();
            string PatientReference = "SELECT CONCAT(lastname , ', ' , firstname,' ',middlename) AS Name, PatientID FROM client";
            MySqlCommand mycommand3 = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da3 = new MySqlDataAdapter(mycommand3);
            da3.Fill(dt3);

            patient_name.DataSource = dt3;
            patient_name.DisplayMember = "Name";
            patient_name.ValueMember = "PatientID";

            patient_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            patient_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patient_name.AutoCompleteSource = AutoCompleteSource.ListItems;


            button8.Visible = false;
        }

        private void loadParticipants()
        {
            MySqlConnection myconn = new MySqlConnection(MyConnection);

            //all participants
            DataTable listofParticipants = new DataTable();
            string displayParti = "SELECT p.firstName AS FirstName, p.lastName AS LastName, p.middleName AS MiddleName, p.birthDate AS Birthdate,p.gender AS Gender FROM participants p LEFT JOIN mothers_class mc ON mc.OrientationID = p.OrientationID WHERE p.OrientationID =" + this.id.Text + ";";
            MySqlCommand partCom = new MySqlCommand(displayParti, myconn);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(partCom);
            dataAdapter1.Fill(listofParticipants);
            dataGridView1.DataSource = listofParticipants;

            int totalpart = dataGridView1.Rows.Count - 1;
            this.totalparticipants.Text = totalpart.ToString();

        }
        private void viewSchedule_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = !tabControl1.Visible;
            loadParticipants();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            loadData();
        }


        private void addtolist()
        {
            if (this.firstName.Text != "" && this.lastName.Text != "" && this.middleName.Text != "")
            {
                listBox1.Items.Add(this.lastName.Text.ToString() + ", " + this.firstName.Text.ToString() + " " + this.middleName.Text.ToString() + ", " + this.gender.SelectedItem.ToString() + ", " + this.birthDate.Value.ToString("yyyy/MM/dd"));
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


        //update schedule button, this will show the textbox
        private void button7_Click(object sender, EventArgs e)
        {
            editDate2.Visible = !editDate2.Visible;
            editTime1.Visible = !editTime1.Visible;
            editTime2.Visible = !editTime2.Visible;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                string Query = "UPDATE mothers_class mc set OrientationDate = '" + this.editDate2.Value.ToString("yyyy/MM/dd") + "', OrientationTimeStart='" + this.editTime1.Text + "', OrientationTimeEnd ='" + this.editTime2.Text + "' WHERE OrientationID ='" + this.id.Text + "';";
                MySqlConnection myConn = new MySqlConnection(MyConnection);
                MySqlCommand updateCom = new MySqlCommand(Query, myConn);


                if (MessageBox.Show("You want to save the changes?", "new orientation schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    myConn.Open();
                    updateCom.ExecuteReader();
                    MessageBox.Show("saved!");

                    date.Text = this.editDate2.Value.ToString("MM/dd/yyyy");
                    timestart.Text = this.editTime1.Text;
                    timeend.Text = this.editTime2.Text;
                    button8.Visible = false;
                    editDate2.Visible = false;
                    editTime1.Visible = false;
                    editTime2.Visible = false;

                }
                else
                {

                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

            
        }


        private void editTime1_TextChanged(object sender, EventArgs e)
        {
            button8.Visible = true;
        }

        private void editDate2_ValueChanged(object sender, EventArgs e)
        {
            button8.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
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

                if (firstName.Text == "" || lastName.Text == "" || middleName.Text == "")
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (patient_name.Text == "")
            {
                loadData();
            }
            else
            {

                MySqlConnection myconn = new MySqlConnection(MyConnection);

                DataTable dt1 = new DataTable();
                string displaySearchPatient = "SELECT FirstName,MiddleName,Lastname,Birthdate,Gender,LotNumber,Street,City,BarangayName FROM client WHERE PatientID = '" + patient_name.SelectedValue + "'";// OR FirstName LIKE '%" + comboBox1.SelectedValue + "%' OR MiddleName LIKE '%" + comboBox1.SelectedValue + "%' OR LastName LIKE '%" + comboBox1.SelectedValue + "%' OR BarangayName LIKE '%" + comboBox1.SelectedValue + "%' ;";
                MySqlCommand mycommand = new MySqlCommand(displaySearchPatient, myconn);
                MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
                da1.Fill(dt1);
                dataGridView3.DataSource = dt1;

            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string fname = this.dataGridView3.CurrentRow.Cells[0].Value.ToString();
                string mname = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
                string lname = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
                string gender = this.dataGridView3.CurrentRow.Cells[4].Value.ToString();

                string orientDate = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
                DateTime orientationDate = Convert.ToDateTime(this.dataGridView3.CurrentRow.Cells[3].Value.ToString());
                string shortDate = orientationDate.ToString("yyyy/MM/dd");
                /*
                string birthDate = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
                DateTime convertdate = Convert.ToDateTime(birthDate);
                string bdate = orientationDate.ToShortDateString();*/



                string add_participants = "INSERT INTO participants (OrientationID, firstName, middleName, lastName, gender, birthDate) VALUES ('"
               + this.id.Text + "','"
               + fname + "','"
               + mname + "','"
               + lname + "','"
               + gender + "','"
               + shortDate +
               "');";

                MySqlConnection myconn8 = new MySqlConnection(MyConnection);
                MySqlCommand addCommand = new MySqlCommand(add_participants, myconn8);
                if (MessageBox.Show("You want to add " + lname + "," + fname + " " + mname + " as participants?", "patient to participants", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    myconn8.Open();
                    addCommand.ExecuteReader();
                    MessageBox.Show("patient added as new participants");
                    loadParticipants();
                }
                else
                {

                }

                myconn8.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
