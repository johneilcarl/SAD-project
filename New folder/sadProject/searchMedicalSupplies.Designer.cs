namespace sadProject
{
    partial class searchMedicalSupplies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receivedQuantity = new MetroFramework.Controls.MetroTextBox();
            this.receiveMed = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quantity = new MetroFramework.Controls.MetroTextBox();
            this.med_supplies = new System.Windows.Forms.ComboBox();
            this.reqButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.fullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dateRequest = new MetroFramework.Controls.MetroDateTime();
            this.expireDate = new MetroFramework.Controls.MetroDateTime();
            this.dateReceive = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.receivefullName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.receivefullName);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.dateReceive);
            this.groupBox1.Controls.Add(this.expireDate);
            this.groupBox1.Controls.Add(this.receivedQuantity);
            this.groupBox1.Controls.Add(this.receiveMed);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(23, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECEIVING DETAILS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // receivedQuantity
            // 
            // 
            // 
            // 
            this.receivedQuantity.CustomButton.Image = null;
            this.receivedQuantity.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.receivedQuantity.CustomButton.Name = "";
            this.receivedQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.receivedQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.receivedQuantity.CustomButton.TabIndex = 1;
            this.receivedQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.receivedQuantity.CustomButton.UseSelectable = true;
            this.receivedQuantity.CustomButton.Visible = false;
            this.receivedQuantity.Lines = new string[0];
            this.receivedQuantity.Location = new System.Drawing.Point(288, 67);
            this.receivedQuantity.MaxLength = 32767;
            this.receivedQuantity.Name = "receivedQuantity";
            this.receivedQuantity.PasswordChar = '\0';
            this.receivedQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.receivedQuantity.SelectedText = "";
            this.receivedQuantity.SelectionLength = 0;
            this.receivedQuantity.SelectionStart = 0;
            this.receivedQuantity.Size = new System.Drawing.Size(234, 23);
            this.receivedQuantity.TabIndex = 15;
            this.receivedQuantity.UseSelectable = true;
            this.receivedQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.receivedQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // receiveMed
            // 
            this.receiveMed.FormattingEnabled = true;
            this.receiveMed.Location = new System.Drawing.Point(288, 32);
            this.receiveMed.Name = "receiveMed";
            this.receiveMed.Size = new System.Drawing.Size(234, 21);
            this.receiveMed.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "RESTOCK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(590, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 249);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateRequest);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.fullName);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.med_supplies);
            this.groupBox2.Controls.Add(this.reqButton);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(23, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1215, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REQUISITION DETAILS";
            // 
            // quantity
            // 
            // 
            // 
            // 
            this.quantity.CustomButton.Image = null;
            this.quantity.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.quantity.CustomButton.Name = "";
            this.quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantity.CustomButton.TabIndex = 1;
            this.quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantity.CustomButton.UseSelectable = true;
            this.quantity.CustomButton.Visible = false;
            this.quantity.Lines = new string[0];
            this.quantity.Location = new System.Drawing.Point(288, 72);
            this.quantity.MaxLength = 32767;
            this.quantity.Name = "quantity";
            this.quantity.PasswordChar = '\0';
            this.quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantity.SelectedText = "";
            this.quantity.SelectionLength = 0;
            this.quantity.SelectionStart = 0;
            this.quantity.Size = new System.Drawing.Size(236, 23);
            this.quantity.TabIndex = 8;
            this.quantity.UseSelectable = true;
            this.quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // med_supplies
            // 
            this.med_supplies.FormattingEnabled = true;
            this.med_supplies.Location = new System.Drawing.Point(288, 35);
            this.med_supplies.Name = "med_supplies";
            this.med_supplies.Size = new System.Drawing.Size(236, 21);
            this.med_supplies.TabIndex = 3;
            // 
            // reqButton
            // 
            this.reqButton.Location = new System.Drawing.Point(342, 201);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(102, 48);
            this.reqButton.TabIndex = 1;
            this.reqButton.Text = "REQUEST";
            this.reqButton.UseVisualStyleBackColor = true;
            this.reqButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(590, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(619, 257);
            this.dataGridView2.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Medical Supplies Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Quantity";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Date of Request";
            // 
            // fullName
            // 
            // 
            // 
            // 
            this.fullName.CustomButton.Image = null;
            this.fullName.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.fullName.CustomButton.Name = "";
            this.fullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullName.CustomButton.TabIndex = 1;
            this.fullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullName.CustomButton.UseSelectable = true;
            this.fullName.CustomButton.Visible = false;
            this.fullName.Lines = new string[0];
            this.fullName.Location = new System.Drawing.Point(288, 154);
            this.fullName.MaxLength = 32767;
            this.fullName.Name = "fullName";
            this.fullName.PasswordChar = '\0';
            this.fullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullName.SelectedText = "";
            this.fullName.SelectionLength = 0;
            this.fullName.SelectionStart = 0;
            this.fullName.Size = new System.Drawing.Size(236, 23);
            this.fullName.TabIndex = 12;
            this.fullName.UseSelectable = true;
            this.fullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Request By (full name)";
            // 
            // dateRequest
            // 
            this.dateRequest.Location = new System.Drawing.Point(288, 110);
            this.dateRequest.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateRequest.Name = "dateRequest";
            this.dateRequest.Size = new System.Drawing.Size(234, 29);
            this.dateRequest.TabIndex = 14;
            // 
            // expireDate
            // 
            this.expireDate.Location = new System.Drawing.Point(288, 134);
            this.expireDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(234, 29);
            this.expireDate.TabIndex = 16;
            // 
            // dateReceive
            // 
            this.dateReceive.Location = new System.Drawing.Point(288, 99);
            this.dateReceive.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateReceive.Name = "dateReceive";
            this.dateReceive.Size = new System.Drawing.Size(234, 29);
            this.dateReceive.TabIndex = 17;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 32);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(147, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Medical Supplies Name";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 67);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Quantity";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 99);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Expiration Date";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(38, 134);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(108, 19);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Date of Received";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(38, 182);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(145, 19);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Received By (full name)";
            // 
            // receivefullName
            // 
            // 
            // 
            // 
            this.receivefullName.CustomButton.Image = null;
            this.receivefullName.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.receivefullName.CustomButton.Name = "";
            this.receivefullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.receivefullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.receivefullName.CustomButton.TabIndex = 1;
            this.receivefullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.receivefullName.CustomButton.UseSelectable = true;
            this.receivefullName.CustomButton.Visible = false;
            this.receivefullName.Lines = new string[0];
            this.receivefullName.Location = new System.Drawing.Point(288, 182);
            this.receivefullName.MaxLength = 32767;
            this.receivefullName.Name = "receivefullName";
            this.receivefullName.PasswordChar = '\0';
            this.receivefullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.receivefullName.SelectedText = "";
            this.receivefullName.SelectionLength = 0;
            this.receivefullName.SelectionStart = 0;
            this.receivefullName.Size = new System.Drawing.Size(236, 23);
            this.receivefullName.TabIndex = 22;
            this.receivefullName.UseSelectable = true;
            this.receivefullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.receivefullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchMedicalSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "searchMedicalSupplies";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Requisition and Receiving";
            this.Load += new System.EventHandler(this.searchMedicalSupplies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox med_supplies;
        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox receiveMed;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTextBox receivedQuantity;
        private MetroFramework.Controls.MetroTextBox quantity;
        private MetroFramework.Controls.MetroDateTime dateRequest;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox fullName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox receivefullName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dateReceive;
        private MetroFramework.Controls.MetroDateTime expireDate;
    }
}