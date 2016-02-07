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
    public partial class ViewForm : MetroForm
    {

        MySqlConnection mcon = new MySqlConnection("server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root");
        MySqlCommand mcd;

        private string PassName;

        public string Pass_Name
        {
            get { return PassName; }
            set { PassName = value; }
        }

        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            metroLabel3.Text = PassName;
        }
    }
}
