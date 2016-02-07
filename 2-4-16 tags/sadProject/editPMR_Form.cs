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
    public partial class editPMR_Form : MetroForm
    {

        MySqlConnection mcon = new MySqlConnection("server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root");
        MySqlCommand mcd;
        public editPMR_Form()
        {
            InitializeComponent();
        }

        private string PassName;

        public string Pass_Name
        {
            get { return PassName; }
            set { PassName = value; }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {

            string Query = "UPDATE checkup c set Complaint= '" + this.complaint.Text + "', Treatment= '" + this.treatment.Text + "' WHERE CheckupID='" + this.getID.Text + "';";
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
                    MessageBox.Show("saved!","");
                        this.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally{
                closeCon();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void editPMR_Form_Load(object sender, EventArgs e)
        {
            fullName.Text = PassName;

        }

        private void prescriptionDetails_Click(object sender, EventArgs e)
        {

        }

        private void fullName_Click(object sender, EventArgs e)
        {

        }

        private void referralDate_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionDate_Click(object sender, EventArgs e)
        {

        }

        private void weight_Click(object sender, EventArgs e)
        {

        }

        private void bloodPressure_Click(object sender, EventArgs e)
        {

        }

        private void referralDetails_Click(object sender, EventArgs e)
        {

        }

    }
    
}
