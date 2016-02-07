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

namespace sadProject
{
    public partial class PMSboxes : MetroForm
    {
        private static PMSboxes _instance;
        public PMSboxes()
        {
            InitializeComponent();
        }
        public PMSboxes instance
        {
            get
            {
                if (PMSboxes._instance == null)
                {
                    PMSboxes._instance = new PMSboxes();
                }
                return PMSboxes._instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            createpatientform cpf = new createpatientform();
            //cpf.instance.Show();
            cpf.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchpatientform spf = new searchpatientform();
            spf.ShowDialog(this);
        }


        private void PMSboxes_closed(object sender, FormClosedEventArgs e)
        {
            //PMSboxes._instance = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recordPatDiagnosis rpd = new recordPatDiagnosis();
            rpd.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            distributeMeds dm = new distributeMeds();
            dm.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayList cs = new displayList();
            cs.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            monthlyReport mr = new monthlyReport();
            mr.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void PMSboxes_Load(object sender, EventArgs e)
        {

        }

    }
}
