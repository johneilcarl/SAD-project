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
    public partial class searchpatientform : MetroForm
    {
        public searchpatientform()
        {
            InitializeComponent();
        }

       

        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);
          
            DataTable dt1 = new DataTable();
            string patientprofileDisplay = "SELECT FirstName,MiddleName,Lastname,Birthdate,Gender,LotNumber,Street,City,BarangayName FROM client";
            MySqlCommand mycommand = new MySqlCommand(patientprofileDisplay, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            

            DataTable dt2 = new DataTable();
            string checkupDisplay = "SELECT CheckupID, DateOfCheckUp,Complaint,Treatment,Medication,CheckUpType,Weight,Height,BloodPressure FROM checkup";
            MySqlCommand mycommand2 = new MySqlCommand(checkupDisplay, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            string PatientReference = "SELECT CONCAT(lastname , ', ' , firstname,' ',middlename) AS Name, PatientID FROM client";
            MySqlCommand mycommand3 = new MySqlCommand(PatientReference, myconn);
            MySqlDataAdapter da3 = new MySqlDataAdapter(mycommand3);
            da3.Fill(dt3);

            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "PatientID";

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;



        }
        private void refresh_gridviewdata2()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);
            DataTable dt2 = new DataTable();
            string checkupDisplay = "SELECT CheckupID, DateOfCheckUp,Complaint,Treatment,Medication,CheckUpType,Weight,Height,BloodPressure FROM checkup";
            MySqlCommand mycommand2 = new MySqlCommand(checkupDisplay, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void searchpatientform_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
           
                if (comboBox1.Text == "")
                {
                    loadData();
                }
       
                else
                {
                    string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
                    MySqlConnection myconn = new MySqlConnection(MyConnection2);
                    DataTable dt1 = new DataTable();
                    string displaySearchPatient = "SELECT FirstName,MiddleName,Lastname,Birthdate,Gender,LotNumber,Street,City,BarangayName FROM client WHERE PatientID = '" + comboBox1.SelectedValue + "'";// OR FirstName LIKE '%" + comboBox1.SelectedValue + "%' OR MiddleName LIKE '%" + comboBox1.SelectedValue + "%' OR LastName LIKE '%" + comboBox1.SelectedValue + "%' OR BarangayName LIKE '%" + comboBox1.SelectedValue + "%' ;";
                    MySqlCommand mycommand = new MySqlCommand(displaySearchPatient, myconn);
                    MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
                    da1.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                    

                    DataTable dt2 = new DataTable();
                    string checkupDisplay = "SELECT CheckupID, DateOfCheckUp,Complaint,Treatment,Medication,CheckUpType,Weight,Height,BloodPressure FROM checkup WHERE PatientID = '" + comboBox1.SelectedValue + "'";
                    MySqlCommand mycommand2 = new MySqlCommand(checkupDisplay, myconn);
                    MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
                    da2.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                }
            }
        void metroButton2_Click(object sender, EventArgs e)
        {
            editPMR_Form frm = new editPMR_Form();
            frm.FormClosed += new FormClosedEventHandler(editPMR_Form_FormClosed);
            frm.metroTextBox1.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frm.richTextBox1.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            frm.richTextBox2.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog(this);
        }

        void editPMR_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
            refresh_gridviewdata2();
        }
            
       


    }
}
