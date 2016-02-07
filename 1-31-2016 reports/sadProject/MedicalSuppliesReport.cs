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
    public partial class MedicalSuppliesReport : MetroForm
    {
        public MedicalSuppliesReport()
        {
            InitializeComponent();
        }

        private void MedicalSuppliesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthcenterDataSet6.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.healthcenterDataSet6.DataTable3, dateTimePicker1.Value, dateTimePicker2.Value);


        // TODO: This line of code loads data into the 'healthcenterDataSet6.DataTable2' table. You can move, or remove it, as needed.
        this.DataTable2TableAdapter.Fill(this.healthcenterDataSet6.DataTable2, dateTimePicker3.Value);

        // TODO: This line of code loads data into the 'RECIEVINGREPORT.DataTable1' table. You can move, or remove it, as needed.
        this.DataTable1TableAdapter.Fill(this.RECIEVINGREPORT.DataTable1, dateTimePicker1.Value, dateTimePicker2.Value);
            





           
            // TODO: This line of code loads data into the 'healthcenterDataSet3.medicine_name' table. You can move, or remove it, as needed.
          this.medicine_nameTableAdapter.Fill(this.healthcenterDataSet3.medicine_name);
            // TODO: This line of code loads data into the 'DiagnosisReport.checkup' table. You can move, or remove it, as needed.
         this.checkupTableAdapter.Fill(this.DiagnosisReport.checkup);
            // TODO: This line of code loads data into the 'healthcenterDataSet.medical_supplies_inventory' table. You can move, or remove it, as needed.
          this.medical_supplies_inventoryTableAdapter.Fill(this.healthcenterDataSet.medical_supplies_inventory);
            // TODO: This line of code loads data into the 'healthcenterDataSet2.client' table. You can move, or remove it, as needed.
          this.clientTableAdapter.Fill(this.healthcenterDataSet2.client);

            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer2.Visible = false;
            reportViewer3.Visible = false;
            reportViewer4.Visible = false; 
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer2.Visible = true;
            reportViewer3.Visible = false;
            reportViewer4.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            dateTimePicker3.Visible = false;
            label3.Visible = false;
            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
            reportViewer3.Visible = true;
            reportViewer4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = true;
            label3.Visible = true;
            button5.Visible = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
            reportViewer3.Visible = false;
            reportViewer4.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            dateTimePicker3.Visible = false;
            label3.Visible = false;
            button5.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'healthcenterDataSet6.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.healthcenterDataSet6.DataTable3, dateTimePicker1.Value, dateTimePicker2.Value);

            // TODO: This line of code loads data into the 'healthcenterDataSet6.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.healthcenterDataSet6.DataTable2, dateTimePicker3.Value);

            // TODO: This line of code loads data into the 'RECIEVINGREPORT.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.RECIEVINGREPORT.DataTable1, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {

        }
    }
}
