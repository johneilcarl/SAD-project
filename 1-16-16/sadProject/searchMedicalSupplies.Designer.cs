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
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.receivefullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dateReceive = new MetroFramework.Controls.MetroDateTime();
            this.expireDate = new MetroFramework.Controls.MetroDateTime();
            this.receivedQuantity = new MetroFramework.Controls.MetroTextBox();
            this.receiveMed = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.reqButton = new System.Windows.Forms.Button();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateRequest = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.delete_list = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.med_supplies = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fullName = new MetroFramework.Controls.MetroTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.quantity = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(39, 287);
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
            this.receivefullName.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.receivefullName.CustomButton.Name = "";
            this.receivefullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.receivefullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.receivefullName.CustomButton.TabIndex = 1;
            this.receivefullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.receivefullName.CustomButton.UseSelectable = true;
            this.receivefullName.CustomButton.Visible = false;
            this.receivefullName.Lines = new string[0];
            this.receivefullName.Location = new System.Drawing.Point(242, 287);
            this.receivefullName.MaxLength = 32767;
            this.receivefullName.Name = "receivefullName";
            this.receivefullName.PasswordChar = '\0';
            this.receivefullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.receivefullName.SelectedText = "";
            this.receivefullName.SelectionLength = 0;
            this.receivefullName.SelectionStart = 0;
            this.receivefullName.Size = new System.Drawing.Size(234, 23);
            this.receivefullName.TabIndex = 22;
            this.receivefullName.UseSelectable = true;
            this.receivefullName.WaterMark = "LastName, FirstName MiddleName";
            this.receivefullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.receivefullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.receivefullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.receivefullName_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(76, 200);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(108, 19);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Date of Received";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(86, 245);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Expiration Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(126, 164);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Quantity";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(37, 123);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(147, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Medical Supplies Name";
            // 
            // dateReceive
            // 
            this.dateReceive.Location = new System.Drawing.Point(242, 200);
            this.dateReceive.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateReceive.Name = "dateReceive";
            this.dateReceive.Size = new System.Drawing.Size(232, 29);
            this.dateReceive.TabIndex = 17;
            // 
            // expireDate
            // 
            this.expireDate.Location = new System.Drawing.Point(242, 245);
            this.expireDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(232, 29);
            this.expireDate.TabIndex = 16;
            // 
            // receivedQuantity
            // 
            // 
            // 
            // 
            this.receivedQuantity.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedQuantity.CustomButton.Image = null;
            this.receivedQuantity.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.receivedQuantity.CustomButton.Name = "";
            this.receivedQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.receivedQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.receivedQuantity.CustomButton.TabIndex = 1;
            this.receivedQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.receivedQuantity.CustomButton.UseSelectable = true;
            this.receivedQuantity.CustomButton.Visible = false;
            this.receivedQuantity.Lines = new string[0];
            this.receivedQuantity.Location = new System.Drawing.Point(242, 164);
            this.receivedQuantity.MaxLength = 32767;
            this.receivedQuantity.Name = "receivedQuantity";
            this.receivedQuantity.PasswordChar = '\0';
            this.receivedQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.receivedQuantity.SelectedText = "";
            this.receivedQuantity.SelectionLength = 0;
            this.receivedQuantity.SelectionStart = 0;
            this.receivedQuantity.Size = new System.Drawing.Size(232, 23);
            this.receivedQuantity.TabIndex = 15;
            this.receivedQuantity.UseSelectable = true;
            this.receivedQuantity.WaterMark = "Quantity";
            this.receivedQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.receivedQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.receivedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.receivedQuantity_KeyPress);
            // 
            // receiveMed
            // 
            this.receiveMed.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiveMed.FormattingEnabled = true;
            this.receiveMed.Location = new System.Drawing.Point(242, 123);
            this.receiveMed.Name = "receiveMed";
            this.receiveMed.Size = new System.Drawing.Size(232, 29);
            this.receiveMed.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "RESTOCK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(505, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 265);
            this.dataGridView1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1289, 580);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroLabel9);
            this.tabPage1.Controls.Add(this.receivefullName);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.metroLabel8);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.metroLabel7);
            this.tabPage1.Controls.Add(this.receiveMed);
            this.tabPage1.Controls.Add(this.metroLabel6);
            this.tabPage1.Controls.Add(this.receivedQuantity);
            this.tabPage1.Controls.Add(this.metroLabel5);
            this.tabPage1.Controls.Add(this.expireDate);
            this.tabPage1.Controls.Add(this.dateReceive);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1281, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RECEIVING LINE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel11);
            this.tabPage2.Controls.Add(this.reqButton);
            this.tabPage2.Controls.Add(this.metroLabel10);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.dateRequest);
            this.tabPage2.Controls.Add(this.metroLabel2);
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.delete_list);
            this.tabPage2.Controls.Add(this.metroLabel4);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.med_supplies);
            this.tabPage2.Controls.Add(this.metroLabel1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.fullName);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.quantity);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1281, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REQUISITION LINE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(977, 10);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(105, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Done Supply List";
            // 
            // reqButton
            // 
            this.reqButton.Location = new System.Drawing.Point(226, 188);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(234, 64);
            this.reqButton.TabIndex = 1;
            this.reqButton.Text = "SEND REQUEST";
            this.reqButton.UseVisualStyleBackColor = true;
            this.reqButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(673, 10);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(74, 19);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = " Supply List";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(494, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 36);
            this.button6.TabIndex = 23;
            this.button6.Text = "Clear Done Supply List";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(673, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(298, 257);
            this.listBox1.TabIndex = 16;
            // 
            // dateRequest
            // 
            this.dateRequest.Location = new System.Drawing.Point(226, 34);
            this.dateRequest.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateRequest.Name = "dateRequest";
            this.dateRequest.Size = new System.Drawing.Size(234, 29);
            this.dateRequest.TabIndex = 14;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(117, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Quantity";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Date of Request";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(494, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 36);
            this.button5.TabIndex = 22;
            this.button5.Text = "Save All Supply List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // delete_list
            // 
            this.delete_list.Location = new System.Drawing.Point(494, 74);
            this.delete_list.Name = "delete_list";
            this.delete_list.Size = new System.Drawing.Size(173, 36);
            this.delete_list.TabIndex = 18;
            this.delete_list.Text = "Delete Selected Supply List";
            this.delete_list.UseVisualStyleBackColor = true;
            this.delete_list.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Request By (full name)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(977, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(298, 257);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // med_supplies
            // 
            this.med_supplies.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_supplies.FormattingEnabled = true;
            this.med_supplies.Location = new System.Drawing.Point(226, 110);
            this.med_supplies.Name = "med_supplies";
            this.med_supplies.Size = new System.Drawing.Size(234, 29);
            this.med_supplies.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Medical Supplies Name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 36);
            this.button4.TabIndex = 21;
            this.button4.Text = "Clear Supply List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Supply List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fullName
            // 
            // 
            // 
            // 
            this.fullName.CustomButton.Image = null;
            this.fullName.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.fullName.CustomButton.Name = "";
            this.fullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullName.CustomButton.TabIndex = 1;
            this.fullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullName.CustomButton.UseSelectable = true;
            this.fullName.CustomButton.Visible = false;
            this.fullName.Lines = new string[0];
            this.fullName.Location = new System.Drawing.Point(226, 74);
            this.fullName.MaxLength = 32767;
            this.fullName.Name = "fullName";
            this.fullName.PasswordChar = '\0';
            this.fullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullName.SelectedText = "";
            this.fullName.SelectionLength = 0;
            this.fullName.SelectionStart = 0;
            this.fullName.Size = new System.Drawing.Size(234, 23);
            this.fullName.TabIndex = 12;
            this.fullName.UseSelectable = true;
            this.fullName.WaterMark = "LastName, FirstName MiddleName";
            this.fullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.fullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullName_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Select All Supply List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1272, 257);
            this.dataGridView2.TabIndex = 0;
            // 
            // quantity
            // 
            // 
            // 
            // 
            this.quantity.CustomButton.Image = null;
            this.quantity.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.quantity.CustomButton.Name = "";
            this.quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantity.CustomButton.TabIndex = 1;
            this.quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantity.CustomButton.UseSelectable = true;
            this.quantity.CustomButton.Visible = false;
            this.quantity.Lines = new string[0];
            this.quantity.Location = new System.Drawing.Point(226, 145);
            this.quantity.MaxLength = 32767;
            this.quantity.Name = "quantity";
            this.quantity.PasswordChar = '\0';
            this.quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantity.SelectedText = "";
            this.quantity.SelectionLength = 0;
            this.quantity.SelectionStart = 0;
            this.quantity.Size = new System.Drawing.Size(234, 23);
            this.quantity.TabIndex = 8;
            this.quantity.UseSelectable = true;
            this.quantity.WaterMark = "Quantity";
            this.quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            // 
            // searchMedicalSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 679);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "searchMedicalSupplies";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Requisition and Receiving";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.searchMedicalSupplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox receiveMed;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox receivefullName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dateReceive;
        private MetroFramework.Controls.MetroDateTime expireDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroDateTime dateRequest;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button delete_list;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox med_supplies;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox fullName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroTextBox quantity;
        public MetroFramework.Controls.MetroTextBox receivedQuantity;
    }
}