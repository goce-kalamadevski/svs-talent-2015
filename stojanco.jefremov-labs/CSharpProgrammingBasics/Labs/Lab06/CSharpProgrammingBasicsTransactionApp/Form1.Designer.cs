namespace CSharpProgrammingBasicsTransactionApp
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
            this.txtAccountCurrency = new System.Windows.Forms.TextBox();
            this.txtAccountLimit = new System.Windows.Forms.TextBox();
            this.lblAccountCurrency = new System.Windows.Forms.Label();
            this.lblAccountLimit = new System.Windows.Forms.Label();
            this.dtpDepositAccountStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDepositAccountStartDate1 = new System.Windows.Forms.Label();
            this.lblDepositAccountEndDate1 = new System.Windows.Forms.Label();
            this.dtpDepositAccountEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtDepositAccountPeriodAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAccountPeriod1 = new System.Windows.Forms.Label();
            this.lblDepositAccountPeriodAmount = new System.Windows.Forms.Label();
            this.lblDepositAccountPeriodUnit = new System.Windows.Forms.Label();
            this.lblInterestUnit = new System.Windows.Forms.Label();
            this.lblInterestPercent = new System.Windows.Forms.Label();
            this.lblDepositAccountInterest1 = new System.Windows.Forms.Label();
            this.txtDepositAccountInterestPercent = new System.Windows.Forms.TextBox();
            this.lblAccountIdValue = new System.Windows.Forms.Label();
            this.lblAccountNumberValue = new System.Windows.Forms.Label();
            this.lblAccountCurrencyValue = new System.Windows.Forms.Label();
            this.lblAccountBalanceValue = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTransactionAccount = new System.Windows.Forms.Label();
            this.lblTransactionAccountLimit = new System.Windows.Forms.Label();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.lblAccountCurrency1 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblTransactionAccountLimitCurrency = new System.Windows.Forms.Label();
            this.lblTransactionAccountLimitValue = new System.Windows.Forms.Label();
            this.lblTransactionAccountLimitCurrencyValue = new System.Windows.Forms.Label();
            this.lblDepositAccount = new System.Windows.Forms.Label();
            this.lblDepositAccountPeriod = new System.Windows.Forms.Label();
            this.lblDepositAccountPeriodAmountValue = new System.Windows.Forms.Label();
            this.lblDepositAccountInterest = new System.Windows.Forms.Label();
            this.lblDepositAccountInterestPercentValue = new System.Windows.Forms.Label();
            this.lblDepositAccountEndDateValue = new System.Windows.Forms.Label();
            this.lblDepositAccountEndDate = new System.Windows.Forms.Label();
            this.lblDepositAccountStartDateValue = new System.Windows.Forms.Label();
            this.lblDepositAccountStartDate = new System.Windows.Forms.Label();
            this.cmbDepositAccountPeriodUnit = new System.Windows.Forms.ComboBox();
            this.cmbDepositAccountInterestUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDepositAccountPeriodUnitValue = new System.Windows.Forms.Label();
            this.lblDepositAccountInterestUnitValue = new System.Windows.Forms.Label();
            this.lbl_ToAccountBalance = new System.Windows.Forms.Label();
            this.lbl_ToAccountNumber = new System.Windows.Forms.Label();
            this.lbl_ToAccountCurrency1 = new System.Windows.Forms.Label();
            this.lbl_ToAccountId = new System.Windows.Forms.Label();
            this.lbl_ToAccount = new System.Windows.Forms.Label();
            this.lbl_ToAccountBalanceValue = new System.Windows.Forms.Label();
            this.lbl_ToAccountCurrencyValue = new System.Windows.Forms.Label();
            this.lbl_ToAccountNumberValue = new System.Windows.Forms.Label();
            this.lbl_ToAccountIdValue = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.lblTotalTransactionCount = new System.Windows.Forms.Label();
            this.lblTotalTransactionCountValue = new System.Windows.Forms.Label();
            this.lblTransactionLogEntryDetails = new System.Windows.Forms.Label();
            this.lblTransactionLogEntryDetailsValue = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.txtTransactionCurrency = new System.Windows.Forms.TextBox();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.lblTransactionCurrency = new System.Windows.Forms.Label();
            this.btnChargeFee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(26, 78);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(200, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(29, 308);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(200, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtAccountCurrency
            // 
            this.txtAccountCurrency.Location = new System.Drawing.Point(119, 16);
            this.txtAccountCurrency.Name = "txtAccountCurrency";
            this.txtAccountCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtAccountCurrency.TabIndex = 2;
            this.txtAccountCurrency.Text = "MKD";
            // 
            // txtAccountLimit
            // 
            this.txtAccountLimit.Location = new System.Drawing.Point(119, 52);
            this.txtAccountLimit.Name = "txtAccountLimit";
            this.txtAccountLimit.Size = new System.Drawing.Size(100, 20);
            this.txtAccountLimit.TabIndex = 3;
            this.txtAccountLimit.Text = "10000";
            // 
            // lblAccountCurrency
            // 
            this.lblAccountCurrency.AutoSize = true;
            this.lblAccountCurrency.Location = new System.Drawing.Point(23, 22);
            this.lblAccountCurrency.Name = "lblAccountCurrency";
            this.lblAccountCurrency.Size = new System.Drawing.Size(91, 13);
            this.lblAccountCurrency.TabIndex = 4;
            this.lblAccountCurrency.Text = "Account currency";
            // 
            // lblAccountLimit
            // 
            this.lblAccountLimit.AutoSize = true;
            this.lblAccountLimit.Location = new System.Drawing.Point(26, 52);
            this.lblAccountLimit.Name = "lblAccountLimit";
            this.lblAccountLimit.Size = new System.Drawing.Size(67, 13);
            this.lblAccountLimit.TabIndex = 5;
            this.lblAccountLimit.Text = "Account limit";
            // 
            // dtpDepositAccountStartDate
            // 
            this.dtpDepositAccountStartDate.Location = new System.Drawing.Point(57, 132);
            this.dtpDepositAccountStartDate.Name = "dtpDepositAccountStartDate";
            this.dtpDepositAccountStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepositAccountStartDate.TabIndex = 6;
            // 
            // lblDepositAccountStartDate1
            // 
            this.lblDepositAccountStartDate1.AutoSize = true;
            this.lblDepositAccountStartDate1.Location = new System.Drawing.Point(0, 138);
            this.lblDepositAccountStartDate1.Name = "lblDepositAccountStartDate1";
            this.lblDepositAccountStartDate1.Size = new System.Drawing.Size(53, 13);
            this.lblDepositAccountStartDate1.TabIndex = 7;
            this.lblDepositAccountStartDate1.Text = "Start date";
            // 
            // lblDepositAccountEndDate1
            // 
            this.lblDepositAccountEndDate1.AutoSize = true;
            this.lblDepositAccountEndDate1.Location = new System.Drawing.Point(3, 166);
            this.lblDepositAccountEndDate1.Name = "lblDepositAccountEndDate1";
            this.lblDepositAccountEndDate1.Size = new System.Drawing.Size(50, 13);
            this.lblDepositAccountEndDate1.TabIndex = 8;
            this.lblDepositAccountEndDate1.Text = "End date";
            // 
            // dtpDepositAccountEndDate
            // 
            this.dtpDepositAccountEndDate.Location = new System.Drawing.Point(57, 166);
            this.dtpDepositAccountEndDate.Name = "dtpDepositAccountEndDate";
            this.dtpDepositAccountEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepositAccountEndDate.TabIndex = 9;
            // 
            // txtDepositAccountPeriodAmount
            // 
            this.txtDepositAccountPeriodAmount.Location = new System.Drawing.Point(62, 212);
            this.txtDepositAccountPeriodAmount.Name = "txtDepositAccountPeriodAmount";
            this.txtDepositAccountPeriodAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAccountPeriodAmount.TabIndex = 10;
            // 
            // lblDepositAccountPeriod1
            // 
            this.lblDepositAccountPeriod1.AutoSize = true;
            this.lblDepositAccountPeriod1.Location = new System.Drawing.Point(6, 221);
            this.lblDepositAccountPeriod1.Name = "lblDepositAccountPeriod1";
            this.lblDepositAccountPeriod1.Size = new System.Drawing.Size(37, 13);
            this.lblDepositAccountPeriod1.TabIndex = 12;
            this.lblDepositAccountPeriod1.Text = "Period";
            // 
            // lblDepositAccountPeriodAmount
            // 
            this.lblDepositAccountPeriodAmount.AutoSize = true;
            this.lblDepositAccountPeriodAmount.Location = new System.Drawing.Point(62, 196);
            this.lblDepositAccountPeriodAmount.Name = "lblDepositAccountPeriodAmount";
            this.lblDepositAccountPeriodAmount.Size = new System.Drawing.Size(43, 13);
            this.lblDepositAccountPeriodAmount.TabIndex = 13;
            this.lblDepositAccountPeriodAmount.Text = "Amount";
            // 
            // lblDepositAccountPeriodUnit
            // 
            this.lblDepositAccountPeriodUnit.AutoSize = true;
            this.lblDepositAccountPeriodUnit.Location = new System.Drawing.Point(182, 195);
            this.lblDepositAccountPeriodUnit.Name = "lblDepositAccountPeriodUnit";
            this.lblDepositAccountPeriodUnit.Size = new System.Drawing.Size(26, 13);
            this.lblDepositAccountPeriodUnit.TabIndex = 14;
            this.lblDepositAccountPeriodUnit.Text = "Unit";
            // 
            // lblInterestUnit
            // 
            this.lblInterestUnit.AutoSize = true;
            this.lblInterestUnit.Location = new System.Drawing.Point(180, 240);
            this.lblInterestUnit.Name = "lblInterestUnit";
            this.lblInterestUnit.Size = new System.Drawing.Size(26, 13);
            this.lblInterestUnit.TabIndex = 19;
            this.lblInterestUnit.Text = "Unit";
            // 
            // lblInterestPercent
            // 
            this.lblInterestPercent.AutoSize = true;
            this.lblInterestPercent.Location = new System.Drawing.Point(62, 241);
            this.lblInterestPercent.Name = "lblInterestPercent";
            this.lblInterestPercent.Size = new System.Drawing.Size(44, 13);
            this.lblInterestPercent.TabIndex = 18;
            this.lblInterestPercent.Text = "Percent";
            // 
            // lblDepositAccountInterest1
            // 
            this.lblDepositAccountInterest1.AutoSize = true;
            this.lblDepositAccountInterest1.Location = new System.Drawing.Point(11, 266);
            this.lblDepositAccountInterest1.Name = "lblDepositAccountInterest1";
            this.lblDepositAccountInterest1.Size = new System.Drawing.Size(42, 13);
            this.lblDepositAccountInterest1.TabIndex = 17;
            this.lblDepositAccountInterest1.Text = "Interest";
            // 
            // txtDepositAccountInterestPercent
            // 
            this.txtDepositAccountInterestPercent.Location = new System.Drawing.Point(62, 260);
            this.txtDepositAccountInterestPercent.Name = "txtDepositAccountInterestPercent";
            this.txtDepositAccountInterestPercent.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAccountInterestPercent.TabIndex = 15;
            // 
            // lblAccountIdValue
            // 
            this.lblAccountIdValue.AutoSize = true;
            this.lblAccountIdValue.Location = new System.Drawing.Point(380, 22);
            this.lblAccountIdValue.Name = "lblAccountIdValue";
            this.lblAccountIdValue.Size = new System.Drawing.Size(0, 13);
            this.lblAccountIdValue.TabIndex = 20;
            // 
            // lblAccountNumberValue
            // 
            this.lblAccountNumberValue.AutoSize = true;
            this.lblAccountNumberValue.Location = new System.Drawing.Point(484, 22);
            this.lblAccountNumberValue.Name = "lblAccountNumberValue";
            this.lblAccountNumberValue.Size = new System.Drawing.Size(0, 13);
            this.lblAccountNumberValue.TabIndex = 21;
            // 
            // lblAccountCurrencyValue
            // 
            this.lblAccountCurrencyValue.AutoSize = true;
            this.lblAccountCurrencyValue.Location = new System.Drawing.Point(379, 52);
            this.lblAccountCurrencyValue.Name = "lblAccountCurrencyValue";
            this.lblAccountCurrencyValue.Size = new System.Drawing.Size(0, 13);
            this.lblAccountCurrencyValue.TabIndex = 22;
            // 
            // lblAccountBalanceValue
            // 
            this.lblAccountBalanceValue.AutoSize = true;
            this.lblAccountBalanceValue.Location = new System.Drawing.Point(487, 52);
            this.lblAccountBalanceValue.Name = "lblAccountBalanceValue";
            this.lblAccountBalanceValue.Size = new System.Drawing.Size(0, 13);
            this.lblAccountBalanceValue.TabIndex = 23;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(277, 22);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 24;
            this.lblAccount.Text = "Account";
            // 
            // lblTransactionAccount
            // 
            this.lblTransactionAccount.AutoSize = true;
            this.lblTransactionAccount.Location = new System.Drawing.Point(280, 105);
            this.lblTransactionAccount.Name = "lblTransactionAccount";
            this.lblTransactionAccount.Size = new System.Drawing.Size(105, 13);
            this.lblTransactionAccount.TabIndex = 25;
            this.lblTransactionAccount.Text = "Transaction account";
            // 
            // lblTransactionAccountLimit
            // 
            this.lblTransactionAccountLimit.AutoSize = true;
            this.lblTransactionAccountLimit.Location = new System.Drawing.Point(392, 105);
            this.lblTransactionAccountLimit.Name = "lblTransactionAccountLimit";
            this.lblTransactionAccountLimit.Size = new System.Drawing.Size(28, 13);
            this.lblTransactionAccountLimit.TabIndex = 26;
            this.lblTransactionAccountLimit.Text = "Limit";
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Location = new System.Drawing.Point(326, 21);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(16, 13);
            this.lblAccountId.TabIndex = 27;
            this.lblAccountId.Text = "Id";
            // 
            // lblAccountCurrency1
            // 
            this.lblAccountCurrency1.AutoSize = true;
            this.lblAccountCurrency1.Location = new System.Drawing.Point(327, 51);
            this.lblAccountCurrency1.Name = "lblAccountCurrency1";
            this.lblAccountCurrency1.Size = new System.Drawing.Size(49, 13);
            this.lblAccountCurrency1.TabIndex = 28;
            this.lblAccountCurrency1.Text = "Currency";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(415, 22);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(44, 13);
            this.lblAccountNumber.TabIndex = 29;
            this.lblAccountNumber.Text = "Number";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(414, 50);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(46, 13);
            this.lblAccountBalance.TabIndex = 30;
            this.lblAccountBalance.Text = "Balance";
            // 
            // lblTransactionAccountLimitCurrency
            // 
            this.lblTransactionAccountLimitCurrency.AutoSize = true;
            this.lblTransactionAccountLimitCurrency.Location = new System.Drawing.Point(395, 134);
            this.lblTransactionAccountLimitCurrency.Name = "lblTransactionAccountLimitCurrency";
            this.lblTransactionAccountLimitCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblTransactionAccountLimitCurrency.TabIndex = 31;
            this.lblTransactionAccountLimitCurrency.Text = "Currency";
            // 
            // lblTransactionAccountLimitValue
            // 
            this.lblTransactionAccountLimitValue.AutoSize = true;
            this.lblTransactionAccountLimitValue.Location = new System.Drawing.Point(445, 105);
            this.lblTransactionAccountLimitValue.Name = "lblTransactionAccountLimitValue";
            this.lblTransactionAccountLimitValue.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionAccountLimitValue.TabIndex = 32;
            // 
            // lblTransactionAccountLimitCurrencyValue
            // 
            this.lblTransactionAccountLimitCurrencyValue.AutoSize = true;
            this.lblTransactionAccountLimitCurrencyValue.Location = new System.Drawing.Point(455, 134);
            this.lblTransactionAccountLimitCurrencyValue.Name = "lblTransactionAccountLimitCurrencyValue";
            this.lblTransactionAccountLimitCurrencyValue.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionAccountLimitCurrencyValue.TabIndex = 33;
            // 
            // lblDepositAccount
            // 
            this.lblDepositAccount.AutoSize = true;
            this.lblDepositAccount.Location = new System.Drawing.Point(283, 179);
            this.lblDepositAccount.Name = "lblDepositAccount";
            this.lblDepositAccount.Size = new System.Drawing.Size(85, 13);
            this.lblDepositAccount.TabIndex = 34;
            this.lblDepositAccount.Text = "Deposit account";
            // 
            // lblDepositAccountPeriod
            // 
            this.lblDepositAccountPeriod.AutoSize = true;
            this.lblDepositAccountPeriod.Location = new System.Drawing.Point(395, 180);
            this.lblDepositAccountPeriod.Name = "lblDepositAccountPeriod";
            this.lblDepositAccountPeriod.Size = new System.Drawing.Size(37, 13);
            this.lblDepositAccountPeriod.TabIndex = 35;
            this.lblDepositAccountPeriod.Text = "Period";
            // 
            // lblDepositAccountPeriodAmountValue
            // 
            this.lblDepositAccountPeriodAmountValue.AutoSize = true;
            this.lblDepositAccountPeriodAmountValue.Location = new System.Drawing.Point(441, 180);
            this.lblDepositAccountPeriodAmountValue.Name = "lblDepositAccountPeriodAmountValue";
            this.lblDepositAccountPeriodAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblDepositAccountPeriodAmountValue.TabIndex = 36;
            // 
            // lblDepositAccountInterest
            // 
            this.lblDepositAccountInterest.AutoSize = true;
            this.lblDepositAccountInterest.Location = new System.Drawing.Point(397, 212);
            this.lblDepositAccountInterest.Name = "lblDepositAccountInterest";
            this.lblDepositAccountInterest.Size = new System.Drawing.Size(42, 13);
            this.lblDepositAccountInterest.TabIndex = 37;
            this.lblDepositAccountInterest.Text = "Interest";
            // 
            // lblDepositAccountInterestPercentValue
            // 
            this.lblDepositAccountInterestPercentValue.AutoSize = true;
            this.lblDepositAccountInterestPercentValue.Location = new System.Drawing.Point(448, 212);
            this.lblDepositAccountInterestPercentValue.Name = "lblDepositAccountInterestPercentValue";
            this.lblDepositAccountInterestPercentValue.Size = new System.Drawing.Size(0, 13);
            this.lblDepositAccountInterestPercentValue.TabIndex = 38;
            // 
            // lblDepositAccountEndDateValue
            // 
            this.lblDepositAccountEndDateValue.AutoSize = true;
            this.lblDepositAccountEndDateValue.Location = new System.Drawing.Point(459, 258);
            this.lblDepositAccountEndDateValue.Name = "lblDepositAccountEndDateValue";
            this.lblDepositAccountEndDateValue.Size = new System.Drawing.Size(0, 13);
            this.lblDepositAccountEndDateValue.TabIndex = 42;
            // 
            // lblDepositAccountEndDate
            // 
            this.lblDepositAccountEndDate.AutoSize = true;
            this.lblDepositAccountEndDate.Location = new System.Drawing.Point(398, 258);
            this.lblDepositAccountEndDate.Name = "lblDepositAccountEndDate";
            this.lblDepositAccountEndDate.Size = new System.Drawing.Size(50, 13);
            this.lblDepositAccountEndDate.TabIndex = 41;
            this.lblDepositAccountEndDate.Text = "End date";
            // 
            // lblDepositAccountStartDateValue
            // 
            this.lblDepositAccountStartDateValue.AutoSize = true;
            this.lblDepositAccountStartDateValue.Location = new System.Drawing.Point(458, 231);
            this.lblDepositAccountStartDateValue.Name = "lblDepositAccountStartDateValue";
            this.lblDepositAccountStartDateValue.Size = new System.Drawing.Size(0, 13);
            this.lblDepositAccountStartDateValue.TabIndex = 40;
            // 
            // lblDepositAccountStartDate
            // 
            this.lblDepositAccountStartDate.AutoSize = true;
            this.lblDepositAccountStartDate.Location = new System.Drawing.Point(396, 231);
            this.lblDepositAccountStartDate.Name = "lblDepositAccountStartDate";
            this.lblDepositAccountStartDate.Size = new System.Drawing.Size(53, 13);
            this.lblDepositAccountStartDate.TabIndex = 39;
            this.lblDepositAccountStartDate.Text = "Start date";
            // 
            // cmbDepositAccountPeriodUnit
            // 
            this.cmbDepositAccountPeriodUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepositAccountPeriodUnit.FormattingEnabled = true;
            this.cmbDepositAccountPeriodUnit.Location = new System.Drawing.Point(178, 212);
            this.cmbDepositAccountPeriodUnit.Name = "cmbDepositAccountPeriodUnit";
            this.cmbDepositAccountPeriodUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbDepositAccountPeriodUnit.TabIndex = 43;
            // 
            // cmbDepositAccountInterestUnit
            // 
            this.cmbDepositAccountInterestUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepositAccountInterestUnit.FormattingEnabled = true;
            this.cmbDepositAccountInterestUnit.Location = new System.Drawing.Point(178, 258);
            this.cmbDepositAccountInterestUnit.Name = "cmbDepositAccountInterestUnit";
            this.cmbDepositAccountInterestUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbDepositAccountInterestUnit.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Amount";
            // 
            // lblDepositAccountPeriodUnitValue
            // 
            this.lblDepositAccountPeriodUnitValue.AutoSize = true;
            this.lblDepositAccountPeriodUnitValue.Location = new System.Drawing.Point(493, 179);
            this.lblDepositAccountPeriodUnitValue.Name = "lblDepositAccountPeriodUnitValue";
            this.lblDepositAccountPeriodUnitValue.Size = new System.Drawing.Size(0, 13);
            this.lblDepositAccountPeriodUnitValue.TabIndex = 51;
            // 
            // lblDepositAccountInterestUnitValue
            // 
            this.lblDepositAccountInterestUnitValue.AutoSize = true;
            this.lblDepositAccountInterestUnitValue.Location = new System.Drawing.Point(491, 212);
            this.lblDepositAccountInterestUnitValue.Name = "lblDepositAccountInterestUnitValue";
            this.lblDepositAccountInterestUnitValue.Size = new System.Drawing.Size(0, 13);
            this.lblDepositAccountInterestUnitValue.TabIndex = 52;
            // 
            // lbl_ToAccountBalance
            // 
            this.lbl_ToAccountBalance.AutoSize = true;
            this.lbl_ToAccountBalance.Location = new System.Drawing.Point(413, 329);
            this.lbl_ToAccountBalance.Name = "lbl_ToAccountBalance";
            this.lbl_ToAccountBalance.Size = new System.Drawing.Size(46, 13);
            this.lbl_ToAccountBalance.TabIndex = 61;
            this.lbl_ToAccountBalance.Text = "Balance";
            // 
            // lbl_ToAccountNumber
            // 
            this.lbl_ToAccountNumber.AutoSize = true;
            this.lbl_ToAccountNumber.Location = new System.Drawing.Point(414, 301);
            this.lbl_ToAccountNumber.Name = "lbl_ToAccountNumber";
            this.lbl_ToAccountNumber.Size = new System.Drawing.Size(44, 13);
            this.lbl_ToAccountNumber.TabIndex = 60;
            this.lbl_ToAccountNumber.Text = "Number";
            // 
            // lbl_ToAccountCurrency1
            // 
            this.lbl_ToAccountCurrency1.AutoSize = true;
            this.lbl_ToAccountCurrency1.Location = new System.Drawing.Point(326, 330);
            this.lbl_ToAccountCurrency1.Name = "lbl_ToAccountCurrency1";
            this.lbl_ToAccountCurrency1.Size = new System.Drawing.Size(49, 13);
            this.lbl_ToAccountCurrency1.TabIndex = 59;
            this.lbl_ToAccountCurrency1.Text = "Currency";
            // 
            // lbl_ToAccountId
            // 
            this.lbl_ToAccountId.AutoSize = true;
            this.lbl_ToAccountId.Location = new System.Drawing.Point(325, 300);
            this.lbl_ToAccountId.Name = "lbl_ToAccountId";
            this.lbl_ToAccountId.Size = new System.Drawing.Size(16, 13);
            this.lbl_ToAccountId.TabIndex = 58;
            this.lbl_ToAccountId.Text = "Id";
            // 
            // lbl_ToAccount
            // 
            this.lbl_ToAccount.AutoSize = true;
            this.lbl_ToAccount.Location = new System.Drawing.Point(258, 301);
            this.lbl_ToAccount.Name = "lbl_ToAccount";
            this.lbl_ToAccount.Size = new System.Drawing.Size(66, 13);
            this.lbl_ToAccount.TabIndex = 57;
            this.lbl_ToAccount.Text = "Account_To";
            // 
            // lbl_ToAccountBalanceValue
            // 
            this.lbl_ToAccountBalanceValue.AutoSize = true;
            this.lbl_ToAccountBalanceValue.Location = new System.Drawing.Point(486, 331);
            this.lbl_ToAccountBalanceValue.Name = "lbl_ToAccountBalanceValue";
            this.lbl_ToAccountBalanceValue.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToAccountBalanceValue.TabIndex = 56;
            // 
            // lbl_ToAccountCurrencyValue
            // 
            this.lbl_ToAccountCurrencyValue.AutoSize = true;
            this.lbl_ToAccountCurrencyValue.Location = new System.Drawing.Point(378, 331);
            this.lbl_ToAccountCurrencyValue.Name = "lbl_ToAccountCurrencyValue";
            this.lbl_ToAccountCurrencyValue.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToAccountCurrencyValue.TabIndex = 55;
            // 
            // lbl_ToAccountNumberValue
            // 
            this.lbl_ToAccountNumberValue.AutoSize = true;
            this.lbl_ToAccountNumberValue.Location = new System.Drawing.Point(483, 301);
            this.lbl_ToAccountNumberValue.Name = "lbl_ToAccountNumberValue";
            this.lbl_ToAccountNumberValue.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToAccountNumberValue.TabIndex = 54;
            // 
            // lbl_ToAccountIdValue
            // 
            this.lbl_ToAccountIdValue.AutoSize = true;
            this.lbl_ToAccountIdValue.Location = new System.Drawing.Point(379, 301);
            this.lbl_ToAccountIdValue.Name = "lbl_ToAccountIdValue";
            this.lbl_ToAccountIdValue.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToAccountIdValue.TabIndex = 53;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(29, 347);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(146, 23);
            this.btnMakeTransaction.TabIndex = 62;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // btnMakeGroupTransaction
            // 
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(29, 389);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(165, 23);
            this.btnMakeGroupTransaction.TabIndex = 63;
            this.btnMakeGroupTransaction.Text = "Make Group Transaction";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // lblTotalTransactionCount
            // 
            this.lblTotalTransactionCount.AutoSize = true;
            this.lblTotalTransactionCount.Location = new System.Drawing.Point(569, 21);
            this.lblTotalTransactionCount.Name = "lblTotalTransactionCount";
            this.lblTotalTransactionCount.Size = new System.Drawing.Size(121, 13);
            this.lblTotalTransactionCount.TabIndex = 64;
            this.lblTotalTransactionCount.Text = "Total Transaction Count";
            // 
            // lblTotalTransactionCountValue
            // 
            this.lblTotalTransactionCountValue.AutoSize = true;
            this.lblTotalTransactionCountValue.Location = new System.Drawing.Point(704, 21);
            this.lblTotalTransactionCountValue.Name = "lblTotalTransactionCountValue";
            this.lblTotalTransactionCountValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTransactionCountValue.TabIndex = 65;
            // 
            // lblTransactionLogEntryDetails
            // 
            this.lblTransactionLogEntryDetails.AutoSize = true;
            this.lblTransactionLogEntryDetails.Location = new System.Drawing.Point(572, 49);
            this.lblTransactionLogEntryDetails.Name = "lblTransactionLogEntryDetails";
            this.lblTransactionLogEntryDetails.Size = new System.Drawing.Size(146, 13);
            this.lblTransactionLogEntryDetails.TabIndex = 66;
            this.lblTransactionLogEntryDetails.Text = "Transaction Log Entry Details";
            // 
            // lblTransactionLogEntryDetailsValue
            // 
            this.lblTransactionLogEntryDetailsValue.AutoSize = true;
            this.lblTransactionLogEntryDetailsValue.Location = new System.Drawing.Point(581, 78);
            this.lblTransactionLogEntryDetailsValue.Name = "lblTransactionLogEntryDetailsValue";
            this.lblTransactionLogEntryDetailsValue.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionLogEntryDetailsValue.TabIndex = 67;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(129, 418);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionAmount.TabIndex = 68;
            // 
            // txtTransactionCurrency
            // 
            this.txtTransactionCurrency.Location = new System.Drawing.Point(129, 448);
            this.txtTransactionCurrency.Name = "txtTransactionCurrency";
            this.txtTransactionCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionCurrency.TabIndex = 69;
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.AutoSize = true;
            this.lblTransactionAmount.Location = new System.Drawing.Point(19, 424);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.Size = new System.Drawing.Size(102, 13);
            this.lblTransactionAmount.TabIndex = 70;
            this.lblTransactionAmount.Text = "Transaction Amount";
            // 
            // lblTransactionCurrency
            // 
            this.lblTransactionCurrency.AutoSize = true;
            this.lblTransactionCurrency.Location = new System.Drawing.Point(20, 451);
            this.lblTransactionCurrency.Name = "lblTransactionCurrency";
            this.lblTransactionCurrency.Size = new System.Drawing.Size(108, 13);
            this.lblTransactionCurrency.TabIndex = 71;
            this.lblTransactionCurrency.Text = "Transaction Currency";
            // 
            // btnChargeFee
            // 
            this.btnChargeFee.Location = new System.Drawing.Point(190, 346);
            this.btnChargeFee.Name = "btnChargeFee";
            this.btnChargeFee.Size = new System.Drawing.Size(75, 23);
            this.btnChargeFee.TabIndex = 72;
            this.btnChargeFee.Text = "Charge Fee";
            this.btnChargeFee.UseVisualStyleBackColor = true;
            this.btnChargeFee.Click += new System.EventHandler(this.btnChargeFee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 502);
            this.Controls.Add(this.btnChargeFee);
            this.Controls.Add(this.lblTransactionCurrency);
            this.Controls.Add(this.lblTransactionAmount);
            this.Controls.Add(this.txtTransactionCurrency);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.lblTransactionLogEntryDetailsValue);
            this.Controls.Add(this.lblTransactionLogEntryDetails);
            this.Controls.Add(this.lblTotalTransactionCountValue);
            this.Controls.Add(this.lblTotalTransactionCount);
            this.Controls.Add(this.btnMakeGroupTransaction);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.lbl_ToAccountBalance);
            this.Controls.Add(this.lbl_ToAccountNumber);
            this.Controls.Add(this.lbl_ToAccountCurrency1);
            this.Controls.Add(this.lbl_ToAccountId);
            this.Controls.Add(this.lbl_ToAccount);
            this.Controls.Add(this.lbl_ToAccountBalanceValue);
            this.Controls.Add(this.lbl_ToAccountCurrencyValue);
            this.Controls.Add(this.lbl_ToAccountNumberValue);
            this.Controls.Add(this.lbl_ToAccountIdValue);
            this.Controls.Add(this.lblDepositAccountInterestUnitValue);
            this.Controls.Add(this.lblDepositAccountPeriodUnitValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepositAccountInterestUnit);
            this.Controls.Add(this.cmbDepositAccountPeriodUnit);
            this.Controls.Add(this.lblDepositAccountEndDateValue);
            this.Controls.Add(this.lblDepositAccountEndDate);
            this.Controls.Add(this.lblDepositAccountStartDateValue);
            this.Controls.Add(this.lblDepositAccountStartDate);
            this.Controls.Add(this.lblDepositAccountInterestPercentValue);
            this.Controls.Add(this.lblDepositAccountInterest);
            this.Controls.Add(this.lblDepositAccountPeriodAmountValue);
            this.Controls.Add(this.lblDepositAccountPeriod);
            this.Controls.Add(this.lblDepositAccount);
            this.Controls.Add(this.lblTransactionAccountLimitCurrencyValue);
            this.Controls.Add(this.lblTransactionAccountLimitValue);
            this.Controls.Add(this.lblTransactionAccountLimitCurrency);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAccountCurrency1);
            this.Controls.Add(this.lblAccountId);
            this.Controls.Add(this.lblTransactionAccountLimit);
            this.Controls.Add(this.lblTransactionAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblAccountBalanceValue);
            this.Controls.Add(this.lblAccountCurrencyValue);
            this.Controls.Add(this.lblAccountNumberValue);
            this.Controls.Add(this.lblAccountIdValue);
            this.Controls.Add(this.lblInterestUnit);
            this.Controls.Add(this.lblInterestPercent);
            this.Controls.Add(this.lblDepositAccountInterest1);
            this.Controls.Add(this.txtDepositAccountInterestPercent);
            this.Controls.Add(this.lblDepositAccountPeriodUnit);
            this.Controls.Add(this.lblDepositAccountPeriodAmount);
            this.Controls.Add(this.lblDepositAccountPeriod1);
            this.Controls.Add(this.txtDepositAccountPeriodAmount);
            this.Controls.Add(this.dtpDepositAccountEndDate);
            this.Controls.Add(this.lblDepositAccountEndDate1);
            this.Controls.Add(this.lblDepositAccountStartDate1);
            this.Controls.Add(this.dtpDepositAccountStartDate);
            this.Controls.Add(this.lblAccountLimit);
            this.Controls.Add(this.lblAccountCurrency);
            this.Controls.Add(this.txtAccountLimit);
            this.Controls.Add(this.txtAccountCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtAccountCurrency;
        private System.Windows.Forms.TextBox txtAccountLimit;
        private System.Windows.Forms.Label lblAccountCurrency;
        private System.Windows.Forms.Label lblAccountLimit;
        private System.Windows.Forms.DateTimePicker dtpDepositAccountStartDate;
        private System.Windows.Forms.Label lblDepositAccountStartDate1;
        private System.Windows.Forms.Label lblDepositAccountEndDate1;
        private System.Windows.Forms.DateTimePicker dtpDepositAccountEndDate;
        private System.Windows.Forms.TextBox txtDepositAccountPeriodAmount;
        private System.Windows.Forms.Label lblDepositAccountPeriod1;
        private System.Windows.Forms.Label lblDepositAccountPeriodAmount;
        private System.Windows.Forms.Label lblDepositAccountPeriodUnit;
        private System.Windows.Forms.Label lblInterestUnit;
        private System.Windows.Forms.Label lblInterestPercent;
        private System.Windows.Forms.Label lblDepositAccountInterest1;
        private System.Windows.Forms.TextBox txtDepositAccountInterestPercent;
        private System.Windows.Forms.Label lblAccountIdValue;
        private System.Windows.Forms.Label lblAccountNumberValue;
        private System.Windows.Forms.Label lblAccountCurrencyValue;
        private System.Windows.Forms.Label lblAccountBalanceValue;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblTransactionAccount;
        private System.Windows.Forms.Label lblTransactionAccountLimit;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.Label lblAccountCurrency1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblTransactionAccountLimitCurrency;
        private System.Windows.Forms.Label lblTransactionAccountLimitValue;
        private System.Windows.Forms.Label lblTransactionAccountLimitCurrencyValue;
        private System.Windows.Forms.Label lblDepositAccount;
        private System.Windows.Forms.Label lblDepositAccountPeriod;
        private System.Windows.Forms.Label lblDepositAccountPeriodAmountValue;
        private System.Windows.Forms.Label lblDepositAccountInterest;
        private System.Windows.Forms.Label lblDepositAccountInterestPercentValue;
        private System.Windows.Forms.Label lblDepositAccountEndDateValue;
        private System.Windows.Forms.Label lblDepositAccountEndDate;
        private System.Windows.Forms.Label lblDepositAccountStartDateValue;
        private System.Windows.Forms.Label lblDepositAccountStartDate;
        private System.Windows.Forms.ComboBox cmbDepositAccountPeriodUnit;
        private System.Windows.Forms.ComboBox cmbDepositAccountInterestUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDepositAccountPeriodUnitValue;
        private System.Windows.Forms.Label lblDepositAccountInterestUnitValue;
        private System.Windows.Forms.Label lbl_ToAccountBalance;
        private System.Windows.Forms.Label lbl_ToAccountNumber;
        private System.Windows.Forms.Label lbl_ToAccountCurrency1;
        private System.Windows.Forms.Label lbl_ToAccountId;
        private System.Windows.Forms.Label lbl_ToAccount;
        private System.Windows.Forms.Label lbl_ToAccountBalanceValue;
        private System.Windows.Forms.Label lbl_ToAccountCurrencyValue;
        private System.Windows.Forms.Label lbl_ToAccountNumberValue;
        private System.Windows.Forms.Label lbl_ToAccountIdValue;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Button btnMakeGroupTransaction;
        private System.Windows.Forms.Label lblTotalTransactionCount;
        private System.Windows.Forms.Label lblTotalTransactionCountValue;
        private System.Windows.Forms.Label lblTransactionLogEntryDetails;
        private System.Windows.Forms.Label lblTransactionLogEntryDetailsValue;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.TextBox txtTransactionCurrency;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.Label lblTransactionCurrency;
        private System.Windows.Forms.Button btnChargeFee;
    }
}

