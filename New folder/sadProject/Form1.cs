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
using MetroFramework.Forms;


namespace sadProject
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string x = textBox1.Text.ToString();
            string y = textBox2.Text.ToString();
            if (x == "" && y == "")
            {
                this.Hide();
                main ma = new main();
                ma.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password", "Incorrect!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
