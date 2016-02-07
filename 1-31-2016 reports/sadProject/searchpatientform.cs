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


        string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
        private void loadData()
        {
            
            MySqlConnection myconn = new MySqlConnection(MyConnection2);
          
            // patient information
            DataTable dt1 = new DataTable();
            string patientprofileDisplay = "SELECT FirstName,MiddleName,Lastname,Birthdate,Gender,LotNumber,Street,City,BarangayName FROM client;";
            MySqlCommand mycommand = new MySqlCommand(patientprofileDisplay, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();


            /*
            //past medical records
            DataTable dt2 = new DataTable();
            string checkupDisplay = "SELECT CheckupID, DateOfCheckUp,Complaint,Treatment,Medication,CheckUpType,Weight,Height,BloodPressure FROM checkup";
            MySqlCommand mycommand2 = new MySqlCommand(checkupDisplay, myconn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //patient referral
            DataTable dt4 = new DataTable();
            string referraldisplay = "SELECT RefferalDate, RefferalDescription FROM patient_refferal";
            MySqlCommand mycommand4 = new MySqlCommand(referraldisplay, myconn);
            MySqlDataAdapter da4 = new MySqlDataAdapter(mycommand4);
            da4.Fill(dt4);
            dataGridView3.DataSource = dt4;

            //prescription
            DataTable dt5 = new DataTable();
            string prescriptiondisplay = "SELECT PrescriptionDate, PrescriptionDetails FROM prescription";
            MySqlCommand mycommand5 = new MySqlCommand(prescriptiondisplay, myconn);
            MySqlDataAdapter da5 = new MySqlDataAdapter(mycommand5);
            da5.Fill(dt5);
            dataGridView4.DataSource = dt5;
            */

            //patient combobox
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



        }
        private void refresh_checkupGridView()
        {
            MySqlConnection myconn = new MySqlConnection(MyConnection2);
            DataTable dt2 = new DataTable();
            string checkupDisplay = "SELECT c.CheckupID, DateOfCheckUp AS Date_of_Checkup,Complaint,Treatment,Medication,CheckUpType AS Checkup_Type,Weight,Height,BloodPressure AS Blood_Pressure, pr.RefferalDate AS Referral_Date, pr.RefferalDescription AS Referral_Description, p.PrescriptionDate AS Prescription_Date, p.PrescriptionDetails AS Prescription_Details FROM checkup c LEFT JOIN patient_refferal pr ON pr.checkupID = c.CheckupID LEFT JOIN prescription p ON p.checkupID = c.CheckupID WHERE c.PatientID = '" + patient_name.SelectedValue + "'";
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
           
                if (patient_name.Text == "")
                {
                    loadData();
                }
       
                else
                {
                   
                    MySqlConnection myconn = new MySqlConnection(MyConnection2);

                    DataTable dt1 = new DataTable();
                    string displaySearchPatient = "SELECT FirstName,MiddleName,Lastname,Birthdate,Gender,LotNumber,Street,City,BarangayName FROM client WHERE PatientID = '" + patient_name.SelectedValue + "'";// OR FirstName LIKE '%" + comboBox1.SelectedValue + "%' OR MiddleName LIKE '%" + comboBox1.SelectedValue + "%' OR LastName LIKE '%" + comboBox1.SelectedValue + "%' OR BarangayName LIKE '%" + comboBox1.SelectedValue + "%' ;";
                    MySqlCommand mycommand = new MySqlCommand(displaySearchPatient, myconn);
                    MySqlDataAdapter da1 = new MySqlDataAdapter(mycommand);
                    da1.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                    
                    //patient checkup profile
                    DataTable dt2 = new DataTable();
                    string checkupDisplay = "SELECT c.CheckupID, DateOfCheckUp AS Date_of_Checkup,Complaint,Treatment,Medication,CheckUpType AS Checkup_Type,Weight,Height,BloodPressure AS Blood_Pressure, pr.RefferalDate AS Referral_Date, pr.RefferalDescription AS Referral_Description, p.PrescriptionDate AS Prescription_Date, p.PrescriptionDetails AS Prescription_Details FROM checkup c LEFT JOIN patient_refferal pr ON pr.checkupID = c.CheckupID LEFT JOIN prescription p ON p.checkupID = c.CheckupID WHERE c.PatientID = '" + patient_name.SelectedValue + "'";
                    MySqlCommand mycommand2 = new MySqlCommand(checkupDisplay, myconn);
                    MySqlDataAdapter da2 = new MySqlDataAdapter(mycommand2);
                    da2.Fill(dt2);
                    dataGridView2.DataSource = dt2;



                }
            }


        void editPMR_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
             refresh_checkupGridView();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editPMR_Form frm = new editPMR_Form();
            frm.FormClosed += new FormClosedEventHandler(editPMR_Form_FormClosed);
            frm.Pass_Name = patient_name.Text;
            frm.getID.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frm.dateCheckup.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            frm.complaint.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            frm.treatment.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            frm.medication.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            frm.checkupType.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            frm.weight.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
            frm.height.Text = this.dataGridView2.CurrentRow.Cells[7].Value.ToString();
            frm.bloodPressure.Text = this.dataGridView2.CurrentRow.Cells[8].Value.ToString();
            frm.referralDate.Text = this.dataGridView2.CurrentRow.Cells[9].Value.ToString();
            frm.refDetails.Text = this.dataGridView2.CurrentRow.Cells[10].Value.ToString();
            frm.prescriptionDate.Text = this.dataGridView2.CurrentRow.Cells[11].Value.ToString();
            frm.presDetails.Text = this.dataGridView2.CurrentRow.Cells[12].Value.ToString();
            frm.ShowDialog(this);

        }

        private void patient_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

            
    


    }
}
