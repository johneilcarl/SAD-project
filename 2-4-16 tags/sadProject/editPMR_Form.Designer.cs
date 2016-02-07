namespace sadProject
{
    partial class editPMR_Form
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
            this.complaint = new System.Windows.Forms.RichTextBox();
            this.treatment = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.getID = new MetroFramework.Controls.MetroTextBox();
            this.fullName = new MetroFramework.Controls.MetroLabel();
            this.dateCheckup = new MetroFramework.Controls.MetroLabel();
            this.checkupType = new MetroFramework.Controls.MetroLabel();
            this.weight = new MetroFramework.Controls.MetroLabel();
            this.height = new MetroFramework.Controls.MetroLabel();
            this.bloodPressure = new MetroFramework.Controls.MetroLabel();
            this.referralDate = new MetroFramework.Controls.MetroLabel();
            this.prescriptionDate = new MetroFramework.Controls.MetroLabel();
            this.medication = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.refDetails = new System.Windows.Forms.RichTextBox();
            this.presDetails = new System.Windows.Forms.RichTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // complaint
            // 
            this.complaint.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaint.Location = new System.Drawing.Point(23, 158);
            this.complaint.Name = "complaint";
            this.complaint.Size = new System.Drawing.Size(362, 100);
            this.complaint.TabIndex = 0;
            this.complaint.Text = "";
            this.complaint.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // treatment
            // 
            this.treatment.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatment.Location = new System.Drawing.Point(23, 295);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(362, 100);
            this.treatment.TabIndex = 1;
            this.treatment.Text = "";
            this.treatment.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 136);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Complaint";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 273);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Treatment";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(131, 401);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 51);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Save Edit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // getID
            // 
            // 
            // 
            // 
            this.getID.CustomButton.Image = null;
            this.getID.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.getID.CustomButton.Name = "";
            this.getID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.getID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.getID.CustomButton.TabIndex = 1;
            this.getID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.getID.CustomButton.UseSelectable = true;
            this.getID.CustomButton.Visible = false;
            this.getID.Lines = new string[] {
        "metroTextBox1"};
            this.getID.Location = new System.Drawing.Point(739, 7);
            this.getID.MaxLength = 32767;
            this.getID.Name = "getID";
            this.getID.PasswordChar = '\0';
            this.getID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.getID.SelectedText = "";
            this.getID.SelectionLength = 0;
            this.getID.SelectionStart = 0;
            this.getID.Size = new System.Drawing.Size(75, 23);
            this.getID.TabIndex = 5;
            this.getID.Text = "metroTextBox1";
            this.getID.UseSelectable = true;
            this.getID.Visible = false;
            this.getID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.getID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.fullName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.fullName.Location = new System.Drawing.Point(310, 26);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(80, 25);
            this.fullName.TabIndex = 6;
            this.fullName.Text = "fullname";
            this.fullName.Click += new System.EventHandler(this.fullName_Click);
            // 
            // dateCheckup
            // 
            this.dateCheckup.AutoSize = true;
            this.dateCheckup.Location = new System.Drawing.Point(23, 88);
            this.dateCheckup.Name = "dateCheckup";
            this.dateCheckup.Size = new System.Drawing.Size(82, 19);
            this.dateCheckup.TabIndex = 7;
            this.dateCheckup.Text = "datecheckup";
            // 
            // checkupType
            // 
            this.checkupType.AutoSize = true;
            this.checkupType.Location = new System.Drawing.Point(310, 69);
            this.checkupType.Name = "checkupType";
            this.checkupType.Size = new System.Drawing.Size(81, 19);
            this.checkupType.TabIndex = 8;
            this.checkupType.Text = "checkuptype";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(335, 98);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(47, 19);
            this.weight.TabIndex = 9;
            this.weight.Text = "weight";
            this.weight.Click += new System.EventHandler(this.weight_Click);
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(443, 98);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(45, 19);
            this.height.TabIndex = 10;
            this.height.Text = "height";
            // 
            // bloodPressure
            // 
            this.bloodPressure.AutoSize = true;
            this.bloodPressure.Location = new System.Drawing.Point(544, 98);
            this.bloodPressure.Name = "bloodPressure";
            this.bloodPressure.Size = new System.Drawing.Size(86, 19);
            this.bloodPressure.TabIndex = 11;
            this.bloodPressure.Text = "bloodpressur";
            this.bloodPressure.Click += new System.EventHandler(this.bloodPressure_Click);
            // 
            // referralDate
            // 
            this.referralDate.AutoSize = true;
            this.referralDate.Location = new System.Drawing.Point(614, 136);
            this.referralDate.Name = "referralDate";
            this.referralDate.Size = new System.Drawing.Size(52, 19);
            this.referralDate.TabIndex = 12;
            this.referralDate.Text = "refDate";
            this.referralDate.Click += new System.EventHandler(this.referralDate_Click);
            // 
            // prescriptionDate
            // 
            this.prescriptionDate.AutoSize = true;
            this.prescriptionDate.Location = new System.Drawing.Point(614, 273);
            this.prescriptionDate.Name = "prescriptionDate";
            this.prescriptionDate.Size = new System.Drawing.Size(61, 19);
            this.prescriptionDate.TabIndex = 14;
            this.prescriptionDate.Text = "presDate";
            this.prescriptionDate.Click += new System.EventHandler(this.prescriptionDate_Click);
            // 
            // medication
            // 
            this.medication.AutoSize = true;
            this.medication.Location = new System.Drawing.Point(416, 69);
            this.medication.Name = "medication";
            this.medication.Size = new System.Drawing.Size(74, 19);
            this.medication.TabIndex = 16;
            this.medication.Text = "medication";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(310, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(25, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "W:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(416, 98);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(21, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "H:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(510, 98);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(28, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "BP:";
            // 
            // refDetails
            // 
            this.refDetails.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refDetails.Location = new System.Drawing.Point(430, 158);
            this.refDetails.Name = "refDetails";
            this.refDetails.ReadOnly = true;
            this.refDetails.Size = new System.Drawing.Size(362, 100);
            this.refDetails.TabIndex = 20;
            this.refDetails.Text = "";
            // 
            // presDetails
            // 
            this.presDetails.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presDetails.Location = new System.Drawing.Point(430, 295);
            this.presDetails.Name = "presDetails";
            this.presDetails.ReadOnly = true;
            this.presDetails.Size = new System.Drawing.Size(362, 100);
            this.presDetails.TabIndex = 21;
            this.presDetails.Text = "";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(430, 273);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(120, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Prescription Details";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(430, 136);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Referral Details";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 69);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(114, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Date of Check-Up";
            // 
            // editPMR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.presDetails);
            this.Controls.Add(this.refDetails);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.medication);
            this.Controls.Add(this.prescriptionDate);
            this.Controls.Add(this.referralDate);
            this.Controls.Add(this.bloodPressure);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.checkupType);
            this.Controls.Add(this.dateCheckup);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.treatment);
            this.Controls.Add(this.complaint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editPMR_Form";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Past Medical Records";
            this.Load += new System.EventHandler(this.editPMR_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        public System.Windows.Forms.RichTextBox complaint;
        public System.Windows.Forms.RichTextBox treatment;
        public MetroFramework.Controls.MetroTextBox getID;
        public MetroFramework.Controls.MetroLabel fullName;
        public MetroFramework.Controls.MetroLabel dateCheckup;
        public MetroFramework.Controls.MetroLabel checkupType;
        public MetroFramework.Controls.MetroLabel weight;
        public MetroFramework.Controls.MetroLabel height;
        public MetroFramework.Controls.MetroLabel bloodPressure;
        public MetroFramework.Controls.MetroLabel referralDate;
        public MetroFramework.Controls.MetroLabel prescriptionDate;
        public MetroFramework.Controls.MetroLabel medication;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public System.Windows.Forms.RichTextBox refDetails;
        public System.Windows.Forms.RichTextBox presDetails;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;

    }
}