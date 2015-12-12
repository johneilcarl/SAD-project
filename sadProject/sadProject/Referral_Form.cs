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
    public partial class Referral_Form : MetroForm
    {
        MySqlConnection mcon = new MySqlConnection("server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root");
        MySqlCommand mcd;

        private string PassID;
        private string PassName;

        public string Pass_ID
        {
            get { return PassID; }
            set { PassID = value; }
        }
        public string Pass_Name
        {
            get { return PassName; }
            set { PassName = value; }
        }
        public Referral_Form()
        {
            InitializeComponent();
        }


        private void Referral_Form_Load(object sender, EventArgs e)
        {
            metroLabel2.Text = PassID;
            metroLabel3.Text = PassName;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO patient_refferal (CheckUp_PatientID, RefferalDate, RefferalDescription) VALUES ('"
                    + this.metroLabel2.Text + "','"
                    + this.metroDateTime1.Value.ToString("yyyy/MM/dd") + "','"
                    + this.richTextBox1.Text +
                    "');";
            ExecuteQuery(Query);

        }
        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }


        //function to Close connection
        public void closeCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }


        //function to execute the insert update and delete query
        public void ExecuteQuery(string q)
        {
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);

                if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        mcd.ExecuteNonQuery();
                        MessageBox.Show("Referral description created", "success");
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

    }
}
