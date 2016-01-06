namespace sadProject
{
    partial class distributeMeds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.medicineName = new System.Windows.Forms.ComboBox();
            this.dispenseDate = new MetroFramework.Controls.MetroDateTime();
            this.expirationDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.quantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "DISPENSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicineName
            // 
            this.medicineName.FormattingEnabled = true;
            this.medicineName.Location = new System.Drawing.Point(550, 90);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(213, 21);
            this.medicineName.TabIndex = 2;
            // 
            // dispenseDate
            // 
            this.dispenseDate.Location = new System.Drawing.Point(550, 212);
            this.dispenseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dispenseDate.Name = "dispenseDate";
            this.dispenseDate.Size = new System.Drawing.Size(213, 29);
            this.dispenseDate.TabIndex = 8;
            // 
            // expirationDate
            // 
            this.expirationDate.Location = new System.Drawing.Point(550, 261);
            this.expirationDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(213, 29);
            this.expirationDate.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(442, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Medicine Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(442, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Quantity";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(442, 212);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Date of Dispense";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(442, 261);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Expiration Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(550, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(442, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Total Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(550, 155);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(210, 20);
            this.quantity.TabIndex = 16;
            // 
            // distributeMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 379);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.dispenseDate);
            this.Controls.Add(this.medicineName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "distributeMeds";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Distribute Medical Supplies";
            this.Load += new System.EventHandler(this.distributeMeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox medicineName;
        private MetroFramework.Controls.MetroDateTime dispenseDate;
        private MetroFramework.Controls.MetroDateTime expirationDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox quantity;
    }
}