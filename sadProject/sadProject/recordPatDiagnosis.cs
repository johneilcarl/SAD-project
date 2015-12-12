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
    public partial class recordPatDiagnosis : MetroForm
    {
        private Referral_Form frm;

        string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
        public recordPatDiagnosis()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            MySqlConnection myconn = new MySqlConnection(MyConnection2);

            string DisplayPatient = "SELECT CONCAT(LastName , ', ' , FirstName) AS Name, PatientID FROM client";
            //string DisplayPatient = "SELECT ";
            MySqlCommand cmdPatient = new MySqlCommand(DisplayPatient, myconn);
            MySqlDataAdapter daDisPat = new MySqlDataAdapter(cmdPatient);
            DataTable dtDisPat = new DataTable();
            daDisPat.Fill(dtDisPat);

            patientName_combobox.DataSource = dtDisPat;
            patientName_combobox.DisplayMember = "Name";
            patientName_combobox.ValueMember = "PatientID";

            patientName_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            patientName_combobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patientName_combobox.AutoCompleteSource = AutoCompleteSource.ListItems;

                DataTable dt2 = new DataTable();
                string PatientReference = "SELECT CONCAT(MedicineName , ', ' , UnitType) AS Medicine, idMedicineName FROM medicine_name";
                MySqlCommand mycommand2 = new MySqlCommand(PatientReference, myconn);
                MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
                da2.Fill(dt2);

                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "Medicine";
                comboBox2.ValueMember = "idMedicineName";
                comboBox2.Text = "None";

                comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems; 




        }

        private void recordPatDiagnosis_Load(object sender, EventArgs e)
        {
            LoadData();
        }

   

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "INSERT INTO checkup (Complaint, Treatment, Medication, DateOfCheckUp, PatientID, CheckUpType, Weight, Height, BloodPressure) VALUES ('"
                    + this.richTextBox1.Text + "','"
                    + this.richTextBox2.Text + "','"
                    + this.comboBox2.Text + "','"
                    + this.metroDateTime1.Value.ToString("yyyy/MM/dd") + "','"
                    + this.patientName_combobox.SelectedValue + "','"
                    + this.CheckuptypeCB.SelectedItem + "','"
                    + this.weight.Text + "','"
                    + this.height.Text + "','"
                    + this.bloodPressure1.Text + "/" + this.bloodPressure2.Text + 
                    "');";

                string QuerySaCombobox2 = "INSERT INTO checkup (Medication) VALUES ('None');";

                if (richTextBox1.Text == "" || richTextBox2.Text == "")
                {
                    MessageBox.Show("Diagnosis is not complete.", "Warning");
                }
                else if (weight.Text == "" || height.Text == "" || bloodPressure1.Text == "" || bloodPressure2.Text == "")
                    {
                        MessageBox.Show("Patient physical status is not complete", "Warning");
                    }
                else if (CheckuptypeCB.Text == "")
                {
                    MessageBox.Show("Check up type is not inputted", "Warning");
                }
                else
                {
                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
    // Here our query will be executed and data saved into the database.

                    if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MyReader2 = MyCommand2.ExecuteReader(); 
                        MessageBox.Show("SUCCESSFULLY DIAGNOSED");
                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        weight.Text = "";
                        CheckuptypeCB.Text = "";
                        height.Text = "";
                        bloodPressure1.Text = "";
                        bloodPressure2.Text = "";
                    }
                    else
                    {

                    }
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Please check carefully the input fields...", "Warning!");
            }



        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8 && e.KeyChar != (char)39;
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void bloodPressure1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Referral_Form frm = new Referral_Form();
            frm.Pass_ID = patientName_combobox.SelectedValue.ToString();
            frm.Pass_Name = patientName_combobox.Text;
            frm.ShowDialog();

           
            
        }
    }
}
