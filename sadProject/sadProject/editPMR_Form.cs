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

  

        private void metroButton1_Click(object sender, EventArgs e)
        {

            string Query = "UPDATE checkup set Complaint= '" + this.richTextBox1.Text + "', Treatment= '" + this.richTextBox2.Text + "' WHERE CheckupID='" + this.metroTextBox1.Text + "';";
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
                if (mcd.ExecuteNonQuery() == 1)
                {
                    if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally{
                closeCon();
            }
        }

    }
    
}
