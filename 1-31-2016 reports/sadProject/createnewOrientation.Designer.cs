namespace sadProject
{
    partial class createnewOrientation
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.middlename = new MetroFramework.Controls.MetroTextBox();
            this.firstname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timeend = new System.Windows.Forms.TextBox();
            this.timestart = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveOrient = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.delete_list = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lastname = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(294, 45);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.Text = "Participant\'s List";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 539);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 47);
            this.button2.TabIndex = 55;
            this.button2.Text = "select all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // middlename
            // 
            // 
            // 
            // 
            this.middlename.CustomButton.Image = null;
            this.middlename.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.middlename.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middlename.CustomButton.Name = "";
            this.middlename.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.middlename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.middlename.CustomButton.TabIndex = 1;
            this.middlename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.middlename.CustomButton.UseSelectable = true;
            this.middlename.CustomButton.Visible = false;
            this.middlename.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.middlename.Lines = new string[0];
            this.middlename.Location = new System.Drawing.Point(47, 400);
            this.middlename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middlename.MaxLength = 32767;
            this.middlename.Name = "middlename";
            this.middlename.PasswordChar = '\0';
            this.middlename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.middlename.SelectedText = "";
            this.middlename.SelectionLength = 0;
            this.middlename.SelectionStart = 0;
            this.middlename.Size = new System.Drawing.Size(202, 30);
            this.middlename.TabIndex = 54;
            this.middlename.UseSelectable = true;
            this.middlename.WaterMark = "MiddleName";
            this.middlename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.middlename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstname
            // 
            // 
            // 
            // 
            this.firstname.CustomButton.Image = null;
            this.firstname.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.firstname.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.CustomButton.Name = "";
            this.firstname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.firstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstname.CustomButton.TabIndex = 1;
            this.firstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstname.CustomButton.UseSelectable = true;
            this.firstname.CustomButton.Visible = false;
            this.firstname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstname.Lines = new string[0];
            this.firstname.Location = new System.Drawing.Point(47, 362);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.MaxLength = 32767;
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstname.SelectedText = "";
            this.firstname.SelectionLength = 0;
            this.firstname.SelectionStart = 0;
            this.firstname.Size = new System.Drawing.Size(202, 30);
            this.firstname.TabIndex = 53;
            this.firstname.UseSelectable = true;
            this.firstname.WaterMark = "FirstName";
            this.firstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(146, 234);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 52;
            this.metroLabel2.Text = "Time End";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 234);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Time Start";
            // 
            // timeend
            // 
            this.timeend.Location = new System.Drawing.Point(146, 257);
            this.timeend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeend.Name = "timeend";
            this.timeend.Size = new System.Drawing.Size(116, 20);
            this.timeend.TabIndex = 50;
            // 
            // timestart
            // 
            this.timestart.Location = new System.Drawing.Point(24, 257);
            this.timestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timestart.Name = "timestart";
            this.timestart.Size = new System.Drawing.Size(116, 20);
            this.timestart.TabIndex = 49;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(251, 594);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(87, 56);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // saveOrient
            // 
            this.saveOrient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOrient.Location = new System.Drawing.Point(47, 548);
            this.saveOrient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveOrient.Name = "saveOrient";
            this.saveOrient.Size = new System.Drawing.Size(202, 82);
            this.saveOrient.TabIndex = 47;
            this.saveOrient.Text = "SAVE ORIENTATION";
            this.saveOrient.UseVisualStyleBackColor = true;
            this.saveOrient.Click += new System.EventHandler(this.saveOrient_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(294, 73);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(269, 562);
            this.listBox1.TabIndex = 46;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 484);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 47);
            this.button5.TabIndex = 45;
            this.button5.Text = "Save all participants";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // delete_list
            // 
            this.delete_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_list.Location = new System.Drawing.Point(47, 493);
            this.delete_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_list.Name = "delete_list";
            this.delete_list.Size = new System.Drawing.Size(202, 47);
            this.delete_list.TabIndex = 44;
            this.delete_list.Text = "Delete Selected Participants";
            this.delete_list.UseVisualStyleBackColor = true;
            this.delete_list.Click += new System.EventHandler(this.delete_list_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 47);
            this.button1.TabIndex = 43;
            this.button1.Text = "Add Participants";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(75, 296);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Participant\'s Name";
            // 
            // lastname
            // 
            // 
            // 
            // 
            this.lastname.CustomButton.Image = null;
            this.lastname.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.lastname.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname.CustomButton.Name = "";
            this.lastname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.lastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastname.CustomButton.TabIndex = 1;
            this.lastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastname.CustomButton.UseSelectable = true;
            this.lastname.CustomButton.Visible = false;
            this.lastname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastname.Lines = new string[0];
            this.lastname.Location = new System.Drawing.Point(47, 324);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname.MaxLength = 32767;
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastname.SelectedText = "";
            this.lastname.SelectionLength = 0;
            this.lastname.SelectionStart = 0;
            this.lastname.Size = new System.Drawing.Size(202, 30);
            this.lastname.TabIndex = 41;
            this.lastname.UseSelectable = true;
            this.lastname.WaterMark = "LastName";
            this.lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(571, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(560, 598);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orientation Details";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.monthCalendar1.Location = new System.Drawing.Point(23, 60);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 39;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Maroon;
            // 
            // createnewOrientation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 672);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.timeend);
            this.Controls.Add(this.timestart);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.saveOrient);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.delete_list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "createnewOrientation";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Mother\'s Class Orientation";
            this.Load += new System.EventHandler(this.createnewOrientation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTextBox middlename;
        private MetroFramework.Controls.MetroTextBox firstname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox timeend;
        private System.Windows.Forms.TextBox timestart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveOrient;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button delete_list;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox lastname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

    }
}