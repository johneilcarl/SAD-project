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
    public partial class createpatientform : MetroForm
    {
        public createpatientform()
        {
            InitializeComponent();
        }

        string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                string Query = "INSERT INTO client (FirstName, MiddleName, LastName, Birthdate, Gender, LotNumber, Street, City, BarangayName) VALUES ('"
                    + this.fNameTB.Text + "','"
                    + this.mNameTB.Text + "','"
                    + this.lNameTB.Text + "','"
                    + this.birthDT.Value.ToString("yyyy/MM/dd") + "','"
                    + this.genderCB.SelectedItem + "','"
                    + this.lotNumberTB.Text + "','"
                    + this.streetTB.Text + "','"
                    + this.cityTB.Text + "','"
                    + this.barangayNameTB.Text +
                    "');";

                if (fNameTB.Text == "" || mNameTB.Text == "" || lNameTB.Text == "" )
                {
                  MessageBox.Show("Full Name is not complete, Please complete");
                }
                else if (lotNumberTB.Text == "" || streetTB.Text == "" || cityTB.Text == "" || barangayNameTB.Text == "")
                {
                    MessageBox.Show("No lot number OR street OR city OR barangay name inputted");
                }
                else if (genderCB.Text == "")
                {
                    MessageBox.Show("No gender is inputted");
                }
                else
                {

                    
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                    MyConn2.Open();
                    if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MyCommand2.ExecuteReader();
                        MessageBox.Show("Successfully created new patient profile!");

                       
                        MyConn2.Close();
                        fNameTB.Text = "";
                        mNameTB.Text = "";
                        lNameTB.Text = "";
                        birthDT.Value.ToString("");
                        lotNumberTB.Text = "";
                        streetTB.Text = "";
                        cityTB.Text = "";
                        barangayNameTB.Text = "";
                    }
                }
                

                
            }

            catch(Exception)
            {
                MessageBox.Show("Please check carefully the input fields...","Warning!!");
            }

        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void createpatientform_Load(object sender, EventArgs e)
        {
            birthDT.MaxDate = DateTime.Now;
        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void fNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;

        }

        private void lotNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void mNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void lNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void cityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void barangayNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8 && e.KeyChar != (char)45;
        }

        private void streetTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8;
        }

        private void lotNumberTB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
