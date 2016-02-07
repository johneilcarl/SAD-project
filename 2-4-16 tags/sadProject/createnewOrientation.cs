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
    public partial class createnewOrientation : MetroForm
    {
        public createnewOrientation()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            string MyConnection2 = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";
            MySqlConnection myconn = new MySqlConnection(MyConnection2);


            DataTable mothersclass = new DataTable();
            string displayclass = "SELECT * FROM mothers_class;";
            MySqlCommand motherCom = new MySqlCommand(displayclass, myconn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(motherCom);
            da1.Fill(mothersclass);
            dataGridView1.DataSource = mothersclass;

        }
        private void createnewOrientation_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void saveOrient_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=healthcenter;Persist Security Info = True; User Id=root; password=root";

            try
            {



                button5_Click(sender, e);


                if (this.listBox1.Items.Count == 0)
                {
                    MessageBox.Show("no list cannot create");
                }
                else if (this.timestart.Text == "" || this.timeend.Text == "")
                {
                    MessageBox.Show("time is required!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to save?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string createOrient = "INSERT INTO mothers_class (OrientationDate, OrientationTimeStart, OrientationTimeEnd, Participants) VALUES ('"
                       + this.monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd") + "','"
                       + this.timestart.Text + "','"
                       + this.timeend.Text + "','"
                       + this.richTextBox1.Text +
                       "');";

                        MySqlConnection myConn = new MySqlConnection(myConnection);
                        MySqlCommand orientCom = new MySqlCommand(createOrient, myConn);
                        myConn.Open();

                        orientCom.ExecuteReader();
                        MessageBox.Show("Created Orientation");
                        myConn.Close();

                        lastname.Text = "";
                        firstname.Text = "";
                        middlename.Text = "";
                        richTextBox1.Text = "";
                        timestart.Text = "";
                        timeend.Text = "";
                        listBox1.Items.Clear();

                        loadData();
                    }
                    else
                    {

                    }


                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.lastname.Text != "" && this.firstname.Text != "" && this.middlename.Text != "")
            {
                listBox1.Items.Add(this.lastname.Text.ToString() + ", " + this.firstname.Text.ToString() + " " + this.firstname.Text.ToString());
                lastname.Text = "";
                firstname.Text = "";
                middlename.Text = "";

            }
            else
            {
                MessageBox.Show("Check the field names", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delete_list_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //selectAll();
                button2_Click(sender, e);
                StringBuilder sb = new StringBuilder();
                foreach (object row in listBox1.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                richTextBox1.SelectedText = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No list");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedItems.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            displayList dl = new displayList();
            dl.metroLabel1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dl.metroLabel2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dl.metroLabel3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dl.metroLabel4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();


            dl.ShowDialog(this);
        }


    }
}
