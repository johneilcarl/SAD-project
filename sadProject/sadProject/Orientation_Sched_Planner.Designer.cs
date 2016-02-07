namespace sadProject
{
    partial class Orientation_Sched_Planner
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.birthDate = new MetroFramework.Controls.MetroDateTime();
            this.gender = new MetroFramework.Controls.MetroComboBox();
            this.middleName = new MetroFramework.Controls.MetroTextBox();
            this.lastName = new MetroFramework.Controls.MetroTextBox();
            this.firstName = new MetroFramework.Controls.MetroTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.patient_name = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 70);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "create schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 207);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(268, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 335);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(301, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 264);
            this.listBox1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(773, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 20);
            this.button4.TabIndex = 8;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "add participant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(467, 411);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(460, 207);
            this.dataGridView2.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 269);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 74);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "create new schedule";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(29, 234);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(48, 29);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(154, 234);
            this.maskedTextBox2.Mask = "90:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(48, 29);
            this.maskedTextBox2.TabIndex = 11;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.metroComboBox1.Location = new System.Drawing.Point(208, 234);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(48, 29);
            this.metroComboBox1.TabIndex = 12;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.metroComboBox2.Location = new System.Drawing.Point(83, 234);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(48, 29);
            this.metroComboBox2.TabIndex = 13;
            this.metroComboBox2.UseSelectable = true;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(6, 202);
            this.birthDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(289, 29);
            this.birthDate.TabIndex = 67;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.ItemHeight = 23;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(6, 157);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(289, 29);
            this.gender.TabIndex = 66;
            this.gender.UseSelectable = true;
            // 
            // middleName
            // 
            // 
            // 
            // 
            this.middleName.CustomButton.Image = null;
            this.middleName.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.middleName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middleName.CustomButton.Name = "";
            this.middleName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.middleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.middleName.CustomButton.TabIndex = 1;
            this.middleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.middleName.CustomButton.UseSelectable = true;
            this.middleName.CustomButton.Visible = false;
            this.middleName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.middleName.Lines = new string[0];
            this.middleName.Location = new System.Drawing.Point(6, 66);
            this.middleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middleName.MaxLength = 32767;
            this.middleName.Name = "middleName";
            this.middleName.PasswordChar = '\0';
            this.middleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.middleName.SelectedText = "";
            this.middleName.SelectionLength = 0;
            this.middleName.SelectionStart = 0;
            this.middleName.Size = new System.Drawing.Size(289, 30);
            this.middleName.TabIndex = 65;
            this.middleName.UseSelectable = true;
            this.middleName.WaterMark = "MiddleName";
            this.middleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.middleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastName
            // 
            // 
            // 
            // 
            this.lastName.CustomButton.Image = null;
            this.lastName.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.lastName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName.CustomButton.Name = "";
            this.lastName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.lastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastName.CustomButton.TabIndex = 1;
            this.lastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastName.CustomButton.UseSelectable = true;
            this.lastName.CustomButton.Visible = false;
            this.lastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastName.Lines = new string[0];
            this.lastName.Location = new System.Drawing.Point(6, 110);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName.MaxLength = 32767;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastName.SelectedText = "";
            this.lastName.SelectionLength = 0;
            this.lastName.SelectionStart = 0;
            this.lastName.Size = new System.Drawing.Size(289, 30);
            this.lastName.TabIndex = 64;
            this.lastName.UseSelectable = true;
            this.lastName.WaterMark = "LastName";
            this.lastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstName
            // 
            // 
            // 
            // 
            this.firstName.CustomButton.Image = null;
            this.firstName.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.firstName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName.CustomButton.Name = "";
            this.firstName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.firstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstName.CustomButton.TabIndex = 1;
            this.firstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstName.CustomButton.UseSelectable = true;
            this.firstName.CustomButton.Visible = false;
            this.firstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstName.Lines = new string[0];
            this.firstName.Location = new System.Drawing.Point(6, 19);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName.MaxLength = 32767;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstName.SelectedText = "";
            this.firstName.SelectionLength = 0;
            this.firstName.SelectionStart = 0;
            this.firstName.Size = new System.Drawing.Size(289, 30);
            this.firstName.TabIndex = 63;
            this.firstName.UseSelectable = true;
            this.firstName.WaterMark = "FirstName";
            this.firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 329);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.birthDate);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.firstName);
            this.tabPage1.Controls.Add(this.lastName);
            this.tabPage1.Controls.Add(this.gender);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.middleName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Participants";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.patient_name);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient as Participants";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(628, 231);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(414, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 29);
            this.button6.TabIndex = 68;
            this.button6.Text = "search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // patient_name
            // 
            this.patient_name.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_name.FormattingEnabled = true;
            this.patient_name.Location = new System.Drawing.Point(179, 15);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(229, 29);
            this.patient_name.TabIndex = 69;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(831, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "refresh all";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Orientation_Sched_Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 641);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Orientation_Sched_Planner";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Orientation Schedule Planner";
            this.Load += new System.EventHandler(this.Orientation_Sched_Planner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroDateTime birthDate;
        private MetroFramework.Controls.MetroComboBox gender;
        private MetroFramework.Controls.MetroTextBox middleName;
        private MetroFramework.Controls.MetroTextBox lastName;
        private MetroFramework.Controls.MetroTextBox firstName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox patient_name;
        private System.Windows.Forms.Button button7;
    }
}