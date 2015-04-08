namespace BankingApplication
{
    partial class frmMain
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
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodAmount = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPeriodUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInterestUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblPeriodUnit = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblInterestUnit = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblEndDateTo = new System.Windows.Forms.Label();
            this.lblStartDateTo = new System.Windows.Forms.Label();
            this.lblInterestUnitTo = new System.Windows.Forms.Label();
            this.lblPercentTo = new System.Windows.Forms.Label();
            this.lblPeriodUnitTo = new System.Windows.Forms.Label();
            this.lblPeriodTo = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lblLimitTo = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lblBalanceTo = new System.Windows.Forms.Label();
            this.lblCurrencyTo = new System.Windows.Forms.Label();
            this.lblNumberTo = new System.Windows.Forms.Label();
            this.lblIdTo = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.chkSmall = new System.Windows.Forms.CheckBox();
            this.btnMagic = new System.Windows.Forms.Button();
            this.txtMagicStringInput = new System.Windows.Forms.TextBox();
            this.txtMagicStringResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(12, 379);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(153, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(12, 408);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(153, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account.";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(110, 13);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(206, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(110, 39);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(206, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Period";
            // 
            // txtPeriodAmount
            // 
            this.txtPeriodAmount.Location = new System.Drawing.Point(110, 127);
            this.txtPeriodAmount.Name = "txtPeriodAmount";
            this.txtPeriodAmount.Size = new System.Drawing.Size(206, 20);
            this.txtPeriodAmount.TabIndex = 7;
            this.txtPeriodAmount.Text = "12";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(110, 205);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(206, 20);
            this.txtPercent.TabIndex = 8;
            this.txtPercent.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Interest rate";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(110, 273);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(206, 20);
            this.dtpStartDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "End date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(110, 299);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(206, 20);
            this.dtpEndDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "The below are required for a deposit account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Period";
            // 
            // txtPeriodUnit
            // 
            this.txtPeriodUnit.Location = new System.Drawing.Point(110, 153);
            this.txtPeriodUnit.Name = "txtPeriodUnit";
            this.txtPeriodUnit.Size = new System.Drawing.Size(206, 20);
            this.txtPeriodUnit.TabIndex = 16;
            this.txtPeriodUnit.Text = "12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Unit of time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Percent";
            // 
            // txtInterestUnit
            // 
            this.txtInterestUnit.Location = new System.Drawing.Point(110, 231);
            this.txtInterestUnit.Name = "txtInterestUnit";
            this.txtInterestUnit.Size = new System.Drawing.Size(206, 20);
            this.txtInterestUnit.TabIndex = 19;
            this.txtInterestUnit.Text = "12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Unit of time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Common";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(362, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "The FROM account";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(362, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(362, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Balance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(362, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Currency";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(464, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 29;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(464, 82);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 30;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(464, 99);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency.TabIndex = 31;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(464, 127);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(362, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Transaction specific";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(362, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Limit";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(464, 186);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(0, 13);
            this.lblLimit.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(362, 221);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Deposit specific";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(362, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Period";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(362, 273);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "Period";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(362, 286);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "Unit of time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(362, 320);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Interest rate";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(362, 345);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 41;
            this.label25.Text = "Percent";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(362, 358);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 42;
            this.label26.Text = "Unit of time";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(362, 389);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 43;
            this.label27.Text = "Start date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(362, 413);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 44;
            this.label28.Text = "End date";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(464, 273);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(0, 13);
            this.lblPeriod.TabIndex = 45;
            // 
            // lblPeriodUnit
            // 
            this.lblPeriodUnit.AutoSize = true;
            this.lblPeriodUnit.Location = new System.Drawing.Point(464, 286);
            this.lblPeriodUnit.Name = "lblPeriodUnit";
            this.lblPeriodUnit.Size = new System.Drawing.Size(0, 13);
            this.lblPeriodUnit.TabIndex = 46;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(464, 345);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 13);
            this.lblPercent.TabIndex = 47;
            // 
            // lblInterestUnit
            // 
            this.lblInterestUnit.AutoSize = true;
            this.lblInterestUnit.Location = new System.Drawing.Point(464, 358);
            this.lblInterestUnit.Name = "lblInterestUnit";
            this.lblInterestUnit.Size = new System.Drawing.Size(0, 13);
            this.lblInterestUnit.TabIndex = 48;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(464, 389);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblStartDate.TabIndex = 49;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(464, 413);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate.TabIndex = 50;
            // 
            // lblEndDateTo
            // 
            this.lblEndDateTo.AutoSize = true;
            this.lblEndDateTo.Location = new System.Drawing.Point(726, 413);
            this.lblEndDateTo.Name = "lblEndDateTo";
            this.lblEndDateTo.Size = new System.Drawing.Size(0, 13);
            this.lblEndDateTo.TabIndex = 78;
            // 
            // lblStartDateTo
            // 
            this.lblStartDateTo.AutoSize = true;
            this.lblStartDateTo.Location = new System.Drawing.Point(726, 389);
            this.lblStartDateTo.Name = "lblStartDateTo";
            this.lblStartDateTo.Size = new System.Drawing.Size(0, 13);
            this.lblStartDateTo.TabIndex = 77;
            // 
            // lblInterestUnitTo
            // 
            this.lblInterestUnitTo.AutoSize = true;
            this.lblInterestUnitTo.Location = new System.Drawing.Point(726, 358);
            this.lblInterestUnitTo.Name = "lblInterestUnitTo";
            this.lblInterestUnitTo.Size = new System.Drawing.Size(0, 13);
            this.lblInterestUnitTo.TabIndex = 76;
            // 
            // lblPercentTo
            // 
            this.lblPercentTo.AutoSize = true;
            this.lblPercentTo.Location = new System.Drawing.Point(726, 345);
            this.lblPercentTo.Name = "lblPercentTo";
            this.lblPercentTo.Size = new System.Drawing.Size(0, 13);
            this.lblPercentTo.TabIndex = 75;
            // 
            // lblPeriodUnitTo
            // 
            this.lblPeriodUnitTo.AutoSize = true;
            this.lblPeriodUnitTo.Location = new System.Drawing.Point(726, 285);
            this.lblPeriodUnitTo.Name = "lblPeriodUnitTo";
            this.lblPeriodUnitTo.Size = new System.Drawing.Size(0, 13);
            this.lblPeriodUnitTo.TabIndex = 74;
            // 
            // lblPeriodTo
            // 
            this.lblPeriodTo.AutoSize = true;
            this.lblPeriodTo.Location = new System.Drawing.Point(726, 272);
            this.lblPeriodTo.Name = "lblPeriodTo";
            this.lblPeriodTo.Size = new System.Drawing.Size(0, 13);
            this.lblPeriodTo.TabIndex = 73;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(624, 413);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 13);
            this.label35.TabIndex = 72;
            this.label35.Text = "End date";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(624, 389);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 13);
            this.label36.TabIndex = 71;
            this.label36.Text = "Start date";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(624, 358);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 13);
            this.label37.TabIndex = 70;
            this.label37.Text = "Unit of time";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(624, 345);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 13);
            this.label38.TabIndex = 69;
            this.label38.Text = "Percent";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(624, 320);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(63, 13);
            this.label39.TabIndex = 68;
            this.label39.Text = "Interest rate";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(624, 286);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 13);
            this.label40.TabIndex = 67;
            this.label40.Text = "Unit of time";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(624, 273);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 13);
            this.label41.TabIndex = 66;
            this.label41.Text = "Period";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(624, 252);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 13);
            this.label42.TabIndex = 65;
            this.label42.Text = "Period";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(624, 221);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 13);
            this.label43.TabIndex = 64;
            this.label43.Text = "Deposit specific";
            // 
            // lblLimitTo
            // 
            this.lblLimitTo.AutoSize = true;
            this.lblLimitTo.Location = new System.Drawing.Point(726, 186);
            this.lblLimitTo.Name = "lblLimitTo";
            this.lblLimitTo.Size = new System.Drawing.Size(0, 13);
            this.lblLimitTo.TabIndex = 63;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(624, 186);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 13);
            this.label45.TabIndex = 62;
            this.label45.Text = "Limit";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(624, 160);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(102, 13);
            this.label46.TabIndex = 61;
            this.label46.Text = "Transaction specific";
            // 
            // lblBalanceTo
            // 
            this.lblBalanceTo.AutoSize = true;
            this.lblBalanceTo.Location = new System.Drawing.Point(726, 127);
            this.lblBalanceTo.Name = "lblBalanceTo";
            this.lblBalanceTo.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceTo.TabIndex = 60;
            // 
            // lblCurrencyTo
            // 
            this.lblCurrencyTo.AutoSize = true;
            this.lblCurrencyTo.Location = new System.Drawing.Point(726, 99);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(0, 13);
            this.lblCurrencyTo.TabIndex = 59;
            // 
            // lblNumberTo
            // 
            this.lblNumberTo.AutoSize = true;
            this.lblNumberTo.Location = new System.Drawing.Point(726, 82);
            this.lblNumberTo.Name = "lblNumberTo";
            this.lblNumberTo.Size = new System.Drawing.Size(0, 13);
            this.lblNumberTo.TabIndex = 58;
            // 
            // lblIdTo
            // 
            this.lblIdTo.AutoSize = true;
            this.lblIdTo.Location = new System.Drawing.Point(726, 65);
            this.lblIdTo.Name = "lblIdTo";
            this.lblIdTo.Size = new System.Drawing.Size(0, 13);
            this.lblIdTo.TabIndex = 57;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(624, 99);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(49, 13);
            this.label51.TabIndex = 56;
            this.label51.Text = "Currency";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(624, 127);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(46, 13);
            this.label52.TabIndex = 55;
            this.label52.Text = "Balance";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(624, 82);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(44, 13);
            this.label53.TabIndex = 54;
            this.label53.Text = "Number";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(624, 65);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(16, 13);
            this.label54.TabIndex = 53;
            this.label54.Text = "Id";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(624, 14);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(86, 13);
            this.label55.TabIndex = 52;
            this.label55.Text = "The TO account";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(624, 42);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(48, 13);
            this.label56.TabIndex = 51;
            this.label56.Text = "Common";
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(171, 379);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(90, 52);
            this.btnMakeTransaction.TabIndex = 79;
            this.btnMakeTransaction.Text = "Make transfer";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Enabled = false;
            this.btnGetBalance.Location = new System.Drawing.Point(12, 449);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(249, 23);
            this.btnGetBalance.TabIndex = 80;
            this.btnGetBalance.Text = "Get Account Balance";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Location = new System.Drawing.Point(365, 451);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(145, 20);
            this.txtAccountNum.TabIndex = 81;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(627, 451);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(145, 20);
            this.txtBalance.TabIndex = 82;
            // 
            // chkSmall
            // 
            this.chkSmall.AutoSize = true;
            this.chkSmall.Location = new System.Drawing.Point(516, 479);
            this.chkSmall.Name = "chkSmall";
            this.chkSmall.Size = new System.Drawing.Size(57, 17);
            this.chkSmall.TabIndex = 83;
            this.chkSmall.Text = "Small?";
            this.chkSmall.UseVisualStyleBackColor = true;
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(12, 478);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(249, 23);
            this.btnMagic.TabIndex = 84;
            this.btnMagic.Text = "Do magic to string";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // txtMagicStringInput
            // 
            this.txtMagicStringInput.Location = new System.Drawing.Point(365, 477);
            this.txtMagicStringInput.Name = "txtMagicStringInput";
            this.txtMagicStringInput.Size = new System.Drawing.Size(145, 20);
            this.txtMagicStringInput.TabIndex = 85;
            // 
            // txtMagicStringResult
            // 
            this.txtMagicStringResult.Location = new System.Drawing.Point(627, 477);
            this.txtMagicStringResult.Name = "txtMagicStringResult";
            this.txtMagicStringResult.ReadOnly = true;
            this.txtMagicStringResult.Size = new System.Drawing.Size(145, 20);
            this.txtMagicStringResult.TabIndex = 86;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 502);
            this.Controls.Add(this.txtMagicStringResult);
            this.Controls.Add(this.txtMagicStringInput);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.chkSmall);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAccountNum);
            this.Controls.Add(this.btnGetBalance);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.lblEndDateTo);
            this.Controls.Add(this.lblStartDateTo);
            this.Controls.Add(this.lblInterestUnitTo);
            this.Controls.Add(this.lblPercentTo);
            this.Controls.Add(this.lblPeriodUnitTo);
            this.Controls.Add(this.lblPeriodTo);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.lblLimitTo);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.lblBalanceTo);
            this.Controls.Add(this.lblCurrencyTo);
            this.Controls.Add(this.lblNumberTo);
            this.Controls.Add(this.lblIdTo);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblInterestUnit);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblPeriodUnit);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInterestUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPeriodUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtPeriodAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeriodAmount;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPeriodUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInterestUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblPeriodUnit;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblInterestUnit;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEndDateTo;
        private System.Windows.Forms.Label lblStartDateTo;
        private System.Windows.Forms.Label lblInterestUnitTo;
        private System.Windows.Forms.Label lblPercentTo;
        private System.Windows.Forms.Label lblPeriodUnitTo;
        private System.Windows.Forms.Label lblPeriodTo;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lblLimitTo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label lblBalanceTo;
        private System.Windows.Forms.Label lblCurrencyTo;
        private System.Windows.Forms.Label lblNumberTo;
        private System.Windows.Forms.Label lblIdTo;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.CheckBox chkSmall;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.TextBox txtMagicStringInput;
        private System.Windows.Forms.TextBox txtMagicStringResult;
    }
}

