namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_AccountName = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_AccountNumber = new System.Windows.Forms.TextBox();
            this.textBox_AccountDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DrawingPower = new System.Windows.Forms.TextBox();
            this.textBox_Branch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_InterestRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_MODBalance = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_CIFNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1_IFSCCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_MICRCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox_NominationRegistered = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1_Balance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dateTimePicker_FromDate
            // 
            this.dateTimePicker_FromDate.Location = new System.Drawing.Point(112, 309);
            this.dateTimePicker_FromDate.Name = "dateTimePicker_FromDate";
            this.dateTimePicker_FromDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FromDate.TabIndex = 2;
            // 
            // dateTimePicker_ToDate
            // 
            this.dateTimePicker_ToDate.Location = new System.Drawing.Point(462, 305);
            this.dateTimePicker_ToDate.Name = "dateTimePicker_ToDate";
            this.dateTimePicker_ToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ToDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From Date";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Statement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox_AccountName
            // 
            this.textBox_AccountName.Location = new System.Drawing.Point(129, 31);
            this.textBox_AccountName.Name = "textBox_AccountName";
            this.textBox_AccountName.Size = new System.Drawing.Size(190, 20);
            this.textBox_AccountName.TabIndex = 7;
            this.textBox_AccountName.Text = "Mr.Chaithanya";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(448, 31);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(171, 60);
            this.textBox_Address.TabIndex = 8;
            this.textBox_Address.Text = "Hitech City,Madhapur,500032";
            this.textBox_Address.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account Number";
            // 
            // textBox_AccountNumber
            // 
            this.textBox_AccountNumber.Location = new System.Drawing.Point(130, 61);
            this.textBox_AccountNumber.Name = "textBox_AccountNumber";
            this.textBox_AccountNumber.Size = new System.Drawing.Size(189, 20);
            this.textBox_AccountNumber.TabIndex = 11;
            this.textBox_AccountNumber.Text = "05610042225999";
            this.textBox_AccountNumber.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox_AccountDescription
            // 
            this.textBox_AccountDescription.Location = new System.Drawing.Point(130, 89);
            this.textBox_AccountDescription.Name = "textBox_AccountDescription";
            this.textBox_AccountDescription.Size = new System.Drawing.Size(189, 20);
            this.textBox_AccountDescription.TabIndex = 13;
            this.textBox_AccountDescription.Text = "HDFC Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Account Descriptin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Drawing Power";
            // 
            // textBox_DrawingPower
            // 
            this.textBox_DrawingPower.Location = new System.Drawing.Point(448, 105);
            this.textBox_DrawingPower.Name = "textBox_DrawingPower";
            this.textBox_DrawingPower.Size = new System.Drawing.Size(171, 20);
            this.textBox_DrawingPower.TabIndex = 16;
            this.textBox_DrawingPower.Text = "Power1";
            // 
            // textBox_Branch
            // 
            this.textBox_Branch.Location = new System.Drawing.Point(130, 121);
            this.textBox_Branch.Name = "textBox_Branch";
            this.textBox_Branch.Size = new System.Drawing.Size(189, 20);
            this.textBox_Branch.TabIndex = 19;
            this.textBox_Branch.Text = "Madhapur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Branch";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Interest Rate(%p.a)";
            // 
            // textBox_InterestRate
            // 
            this.textBox_InterestRate.Location = new System.Drawing.Point(449, 135);
            this.textBox_InterestRate.Name = "textBox_InterestRate";
            this.textBox_InterestRate.Size = new System.Drawing.Size(171, 20);
            this.textBox_InterestRate.TabIndex = 20;
            this.textBox_InterestRate.Text = "3.5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(130, 151);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker_Date.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "MOD Balance";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // textBox_MODBalance
            // 
            this.textBox_MODBalance.Location = new System.Drawing.Point(130, 186);
            this.textBox_MODBalance.Name = "textBox_MODBalance";
            this.textBox_MODBalance.Size = new System.Drawing.Size(189, 20);
            this.textBox_MODBalance.TabIndex = 25;
            this.textBox_MODBalance.Text = "45855";
            this.textBox_MODBalance.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "CIF Number";
            // 
            // textBox_CIFNumber
            // 
            this.textBox_CIFNumber.Location = new System.Drawing.Point(448, 168);
            this.textBox_CIFNumber.Name = "textBox_CIFNumber";
            this.textBox_CIFNumber.Size = new System.Drawing.Size(171, 20);
            this.textBox_CIFNumber.TabIndex = 27;
            this.textBox_CIFNumber.Text = "589785";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "IFSC Code";
            // 
            // textBox1_IFSCCode
            // 
            this.textBox1_IFSCCode.Location = new System.Drawing.Point(449, 201);
            this.textBox1_IFSCCode.Name = "textBox1_IFSCCode";
            this.textBox1_IFSCCode.Size = new System.Drawing.Size(171, 20);
            this.textBox1_IFSCCode.TabIndex = 29;
            this.textBox1_IFSCCode.Text = "HDFC0001";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(372, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "MICR Code";
            // 
            // textBox_MICRCode
            // 
            this.textBox_MICRCode.Location = new System.Drawing.Point(450, 235);
            this.textBox_MICRCode.Name = "textBox_MICRCode";
            this.textBox_MICRCode.Size = new System.Drawing.Size(171, 20);
            this.textBox_MICRCode.TabIndex = 31;
            this.textBox_MICRCode.Text = "12545";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nomination Tegistered";
            // 
            // comboBox_NominationRegistered
            // 
            this.comboBox_NominationRegistered.FormattingEnabled = true;
            this.comboBox_NominationRegistered.Location = new System.Drawing.Point(130, 222);
            this.comboBox_NominationRegistered.Name = "comboBox_NominationRegistered";
            this.comboBox_NominationRegistered.Size = new System.Drawing.Size(121, 21);
            this.comboBox_NominationRegistered.TabIndex = 35;
            this.comboBox_NominationRegistered.Text = "No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(50, 259);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Balance";
            // 
            // textBox1_Balance
            // 
            this.textBox1_Balance.Location = new System.Drawing.Point(128, 256);
            this.textBox1_Balance.Name = "textBox1_Balance";
            this.textBox1_Balance.Size = new System.Drawing.Size(171, 20);
            this.textBox1_Balance.TabIndex = 36;
            this.textBox1_Balance.Text = "450000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 414);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox1_Balance);
            this.Controls.Add(this.comboBox_NominationRegistered);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_MICRCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1_IFSCCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_CIFNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_MODBalance);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_InterestRate);
            this.Controls.Add(this.textBox_Branch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_DrawingPower);
            this.Controls.Add(this.textBox_AccountDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_AccountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_AccountName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_ToDate);
            this.Controls.Add(this.dateTimePicker_FromDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StatementGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_AccountName;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_AccountNumber;
        private System.Windows.Forms.TextBox textBox_AccountDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DrawingPower;
        private System.Windows.Forms.TextBox textBox_Branch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_InterestRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_MODBalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_CIFNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1_IFSCCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_MICRCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_NominationRegistered;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1_Balance;
    }
}

