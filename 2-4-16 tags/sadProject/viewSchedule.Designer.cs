﻿namespace sadProject
{
    partial class viewSchedule
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
            this.date = new MetroFramework.Controls.MetroLabel();
            this.timestart = new MetroFramework.Controls.MetroLabel();
            this.timeend = new MetroFramework.Controls.MetroLabel();
            this.totalparticipants = new MetroFramework.Controls.MetroLabel();
            this.id = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthDate = new MetroFramework.Controls.MetroDateTime();
            this.gender = new MetroFramework.Controls.MetroComboBox();
            this.middleName = new MetroFramework.Controls.MetroTextBox();
            this.lastName = new MetroFramework.Controls.MetroTextBox();
            this.firstName = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.editDate = new MetroFramework.Controls.MetroTextBox();
            this.editTime2 = new MetroFramework.Controls.MetroTextBox();
            this.editTime1 = new MetroFramework.Controls.MetroTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.date.Location = new System.Drawing.Point(86, 80);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(83, 19);
            this.date.TabIndex = 0;
            this.date.Text = "00/00/0000";
            // 
            // timestart
            // 
            this.timestart.AutoSize = true;
            this.timestart.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.timestart.Location = new System.Drawing.Point(364, 80);
            this.timestart.Name = "timestart";
            this.timestart.Size = new System.Drawing.Size(39, 19);
            this.timestart.TabIndex = 1;
            this.timestart.Text = "8AM";
            // 
            // timeend
            // 
            this.timeend.AutoSize = true;
            this.timeend.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.timeend.Location = new System.Drawing.Point(434, 80);
            this.timeend.Name = "timeend";
            this.timeend.Size = new System.Drawing.Size(46, 19);
            this.timeend.TabIndex = 2;
            this.timeend.Text = "12PM";
            // 
            // totalparticipants
            // 
            this.totalparticipants.AutoSize = true;
            this.totalparticipants.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalparticipants.Location = new System.Drawing.Point(273, 115);
            this.totalparticipants.Name = "totalparticipants";
            this.totalparticipants.Size = new System.Drawing.Size(25, 19);
            this.totalparticipants.TabIndex = 3;
            this.totalparticipants.Text = "00";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(175, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(83, 19);
            this.id.TabIndex = 4;
            this.id.Text = "metroLabel5";
            this.id.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 305);
            this.dataGridView1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(690, 92);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "add new participants";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.middleName);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(27, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 305);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(55, 172);
            this.birthDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(289, 29);
            this.birthDate.TabIndex = 62;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.ItemHeight = 23;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(55, 137);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(289, 29);
            this.gender.TabIndex = 61;
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
            this.middleName.Location = new System.Drawing.Point(55, 100);
            this.middleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middleName.MaxLength = 32767;
            this.middleName.Name = "middleName";
            this.middleName.PasswordChar = '\0';
            this.middleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.middleName.SelectedText = "";
            this.middleName.SelectionLength = 0;
            this.middleName.SelectionStart = 0;
            this.middleName.Size = new System.Drawing.Size(289, 30);
            this.middleName.TabIndex = 60;
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
            this.lastName.Location = new System.Drawing.Point(55, 62);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName.MaxLength = 32767;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastName.SelectedText = "";
            this.lastName.SelectionLength = 0;
            this.lastName.SelectionStart = 0;
            this.lastName.Size = new System.Drawing.Size(289, 30);
            this.lastName.TabIndex = 59;
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
            this.firstName.Location = new System.Drawing.Point(55, 24);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName.MaxLength = 32767;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstName.SelectedText = "";
            this.firstName.SelectionLength = 0;
            this.firstName.SelectionStart = 0;
            this.firstName.Size = new System.Drawing.Size(289, 30);
            this.firstName.TabIndex = 58;
            this.firstName.UseSelectable = true;
            this.firstName.WaterMark = "FirstName";
            this.firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(406, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 277);
            this.listBox1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 52);
            this.button4.TabIndex = 8;
            this.button4.Text = "cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xx";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(27, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Date:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(225, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Time Start-End:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(27, 109);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(240, 25);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Total number of Participants:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(409, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "to";
            // 
            // editDate
            // 
            // 
            // 
            // 
            this.editDate.CustomButton.Image = null;
            this.editDate.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.editDate.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editDate.CustomButton.Name = "";
            this.editDate.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.editDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editDate.CustomButton.TabIndex = 1;
            this.editDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editDate.CustomButton.UseSelectable = true;
            this.editDate.CustomButton.Visible = false;
            this.editDate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editDate.Lines = new string[0];
            this.editDate.Location = new System.Drawing.Point(81, 69);
            this.editDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editDate.MaxLength = 32767;
            this.editDate.Name = "editDate";
            this.editDate.PasswordChar = '\0';
            this.editDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editDate.SelectedText = "";
            this.editDate.SelectionLength = 0;
            this.editDate.SelectionStart = 0;
            this.editDate.Size = new System.Drawing.Size(138, 30);
            this.editDate.TabIndex = 63;
            this.editDate.UseSelectable = true;
            this.editDate.Visible = false;
            this.editDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.editDate.TextChanged += new System.EventHandler(this.editDate_TextChanged);
            // 
            // editTime2
            // 
            // 
            // 
            // 
            this.editTime2.CustomButton.Image = null;
            this.editTime2.CustomButton.Location = new System.Drawing.Point(10, 2);
            this.editTime2.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editTime2.CustomButton.Name = "";
            this.editTime2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.editTime2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editTime2.CustomButton.TabIndex = 1;
            this.editTime2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTime2.CustomButton.UseSelectable = true;
            this.editTime2.CustomButton.Visible = false;
            this.editTime2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editTime2.Lines = new string[0];
            this.editTime2.Location = new System.Drawing.Point(437, 74);
            this.editTime2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editTime2.MaxLength = 32767;
            this.editTime2.Name = "editTime2";
            this.editTime2.PasswordChar = '\0';
            this.editTime2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editTime2.SelectedText = "";
            this.editTime2.SelectionLength = 0;
            this.editTime2.SelectionStart = 0;
            this.editTime2.Size = new System.Drawing.Size(38, 30);
            this.editTime2.TabIndex = 64;
            this.editTime2.UseSelectable = true;
            this.editTime2.Visible = false;
            this.editTime2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editTime2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.editTime2.TextChanged += new System.EventHandler(this.editDate_TextChanged);
            // 
            // editTime1
            // 
            // 
            // 
            // 
            this.editTime1.CustomButton.Image = null;
            this.editTime1.CustomButton.Location = new System.Drawing.Point(10, 2);
            this.editTime1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editTime1.CustomButton.Name = "";
            this.editTime1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.editTime1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editTime1.CustomButton.TabIndex = 1;
            this.editTime1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTime1.CustomButton.UseSelectable = true;
            this.editTime1.CustomButton.Visible = false;
            this.editTime1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.editTime1.Lines = new string[0];
            this.editTime1.Location = new System.Drawing.Point(364, 74);
            this.editTime1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editTime1.MaxLength = 32767;
            this.editTime1.Name = "editTime1";
            this.editTime1.PasswordChar = '\0';
            this.editTime1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editTime1.SelectedText = "";
            this.editTime1.SelectionLength = 0;
            this.editTime1.SelectionStart = 0;
            this.editTime1.Size = new System.Drawing.Size(39, 30);
            this.editTime1.TabIndex = 65;
            this.editTime1.UseSelectable = true;
            this.editTime1.Visible = false;
            this.editTime1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editTime1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.editTime1.TextChanged += new System.EventHandler(this.editDate_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(708, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 66;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 31);
            this.button6.TabIndex = 67;
            this.button6.Text = "save changes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(579, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 31);
            this.button7.TabIndex = 68;
            this.button7.Text = "update schedule";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(579, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 31);
            this.button8.TabIndex = 69;
            this.button8.Text = "save new schedule";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // viewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 571);
            this.ControlBox = false;
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.editTime1);
            this.Controls.Add(this.editTime2);
            this.Controls.Add(this.editDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.totalparticipants);
            this.Controls.Add(this.timeend);
            this.Controls.Add(this.timestart);
            this.Controls.Add(this.date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewSchedule";
            this.ShowInTaskbar = false;
            this.Text = "viewSchedule";
            this.Load += new System.EventHandler(this.viewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel date;
        public MetroFramework.Controls.MetroLabel timestart;
        public MetroFramework.Controls.MetroLabel timeend;
        public MetroFramework.Controls.MetroLabel totalparticipants;
        public MetroFramework.Controls.MetroLabel id;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime birthDate;
        private MetroFramework.Controls.MetroComboBox gender;
        private MetroFramework.Controls.MetroTextBox middleName;
        private MetroFramework.Controls.MetroTextBox lastName;
        private MetroFramework.Controls.MetroTextBox firstName;
        public MetroFramework.Controls.MetroTextBox editDate;
        public MetroFramework.Controls.MetroTextBox editTime2;
        public MetroFramework.Controls.MetroTextBox editTime1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;

    }
}