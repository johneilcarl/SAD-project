namespace sadProject
{
    partial class main
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
            this.patientButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientButton
            // 
            this.patientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patientButton.Location = new System.Drawing.Point(43, 164);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(188, 154);
            this.patientButton.TabIndex = 0;
            this.patientButton.Text = "PATIENT";
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(281, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 154);
            this.button2.TabIndex = 1;
            this.button2.Text = "MOTHER\'S CLASS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(517, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 154);
            this.button3.TabIndex = 2;
            this.button3.Text = "INVENTORY";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(734, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 464);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 41);
            this.button6.TabIndex = 2;
            this.button6.Text = "HELP";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 42);
            this.button5.TabIndex = 1;
            this.button5.Text = "ABOUT";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(14, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 76);
            this.button4.TabIndex = 0;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.patientButton);
            this.Name = "main";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Barangay 12-B Health Center";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}