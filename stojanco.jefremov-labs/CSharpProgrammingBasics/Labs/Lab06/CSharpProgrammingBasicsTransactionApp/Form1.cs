using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Processors;
using CSharpProgrammingBasics.Classes.Extensions;

namespace CSharpProgrammingBasicsTransactionApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            TransactionAccount transactionAccount = this.CreateTransactionAccount();
            this.PopulateAccountLabels(transactionAccount);
        }
        /// <summary>
        /// Returns new instance of the TransactionAccount class created from the values entered from the user in the TextBox controls.
        /// </summary>
        /// <returns></returns>
        private TransactionAccount CreateTransactionAccount()
        {
            TransactionAccount transactionAccount = new TransactionAccount(txtAccountCurrency.Text, Decimal.Parse(txtAccountLimit.Text));
            transactionAccount.OnBalanceChanged += Account_OnBalanceChanged;
            return transactionAccount;
        }
        /// <summary>
        /// Receives a parameter of type Account and populates the Account common labels.
        /// </summary>
        /// <param name="account"></param>
        private void PopulateAccountLabels(IAccount account)
        {
            lblAccountIdValue.Text = account.Id.ToString();
            lblAccountNumberValue.Text = account.Number;
            lblAccountCurrencyValue.Text = account.Currency;
            lblAccountBalanceValue.Text = account.Balance.Amount.ToString();
            this.PopulateDepositAccountLabels(account);
            this.PopulateTransactionAccountLabels(account);
        }
        /// <summary>
        /// Receives a parameter of type Account and populates the Account_To common labels.
        /// </summary>
        /// <param name="account"></param>
        private void PopulateAccount_ToLabels(IAccount account)
        {
            lbl_ToAccountIdValue.Text = account.Id.ToString();
            lbl_ToAccountNumberValue.Text = account.Number;
            lbl_ToAccountCurrencyValue.Text = account.Currency;
            lbl_ToAccountBalanceValue.Text = account.Balance.Amount.ToString();
        }
        /// <summary>
        /// Checks if the account parameter is a TransactionAccount and if this is true will populate the TransactionAccount specific labels.
        /// Otherwise it will clear the TransactionAccount specific labels.
        /// </summary>
        /// <param name="account"></param>
        private void PopulateTransactionAccountLabels(IAccount account)
        {
            if (account.GetType() == typeof(TransactionAccount))
            {
                ITransactionAccount transactionAccount = (TransactionAccount)account;
                lblTransactionAccountLimitValue.Text = transactionAccount.Limit.Amount.ToString();
                lblTransactionAccountLimitCurrencyValue.Text = transactionAccount.Limit.Currency;
                //this.PopulateAccountLabels(account);
            }
            else
            {
                lblTransactionAccountLimitValue.Text = "";
                lblTransactionAccountLimitCurrencyValue.Text = "";
            }            
        }

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            DepositAccount depositAccount = this.CreateDepositAccount();
            this.PopulateAccountLabels(depositAccount);
        }
        /// <summary>
        /// Returns new instance of the DepositAccount class created from the values entered from the user in the TextBox controls.
        /// </summary>
        /// <returns></returns>
        private DepositAccount CreateDepositAccount()
        {
            TransactionAccount transactionAccount = this.CreateTransactionAccount();
            DepositAccount depositAccount = this.CreateAccount<DepositAccount>(transactionAccount);
            return depositAccount;
        }

        /// <summary>
        /// Returns new instance of the LoanAccount class created from the values entered from the user  in the TextBox controls.
        /// </summary>
        /// <returns></returns>
        private LoanAccount CreateLoanAccount()
        {
            TransactionAccount transactionAccount = this.CreateTransactionAccount();
            LoanAccount loanAccount = this.CreateAccount<LoanAccount>(transactionAccount);
            return loanAccount;
        }
        /// <summary>
        /// If the passed type is not DepositAccount or LoanAccount it will return the default value for that type.
        /// </summary>
        /// <typeparam name="AccountType"></typeparam>
        /// <param name="transactionAccount"></param>
        /// <returns></returns>
        private AccountType CreateAccount<AccountType>(ITransactionAccount transactionAccount) where AccountType:DepositAccount
        {
            AccountType createdAccount = default(AccountType);
            TimePeriod depositPeriod = new TimePeriod();
            //TODO Should not we calculate the period from difference between startDate and endDate instead of entering it.
            depositPeriod.Period = Int32.Parse(txtDepositAccountPeriodAmount.Text);
            depositPeriod.Unit = (UnitOfTime)cmbDepositAccountPeriodUnit.SelectedItem;
            InterestRate interestRate = new InterestRate();
            interestRate.Percent = Decimal.Parse(txtDepositAccountInterestPercent.Text);
            interestRate.Unit = (UnitOfTime)cmbDepositAccountInterestUnit.SelectedItem;
            if (typeof(AccountType) == typeof(DepositAccount))
            {
                createdAccount = new DepositAccount(txtAccountCurrency.Text,
                depositPeriod, interestRate, dtpDepositAccountStartDate.Value, dtpDepositAccountEndDate.Value,
                    transactionAccount) as AccountType;
            }
            else if (typeof(AccountType) == typeof(LoanAccount))
            {
                createdAccount = new LoanAccount(txtAccountCurrency.Text,
                depositPeriod, interestRate, dtpDepositAccountStartDate.Value, dtpDepositAccountEndDate.Value,
                    transactionAccount) as AccountType;
            }
            createdAccount.OnBalanceChanged += this.Account_OnBalanceChanged;
            return createdAccount;
        }
        /// <summary>
        /// Checks if the account parameter is a DepositAccount and if this is true will populate the DepositAccount specific labels.
        /// Otherwise it will clear the DepositAccount specific labels.
        /// </summary>
        /// <param name="account"></param>
        private void PopulateDepositAccountLabels(IAccount account)
        {
            if (account.GetType() == typeof(DepositAccount))
            {
                IDepositAccount depositAccount = (DepositAccount)account;
                lblDepositAccountEndDateValue.Text = depositAccount.EndDate.ToShortDateString();
                lblDepositAccountInterestPercentValue.Text = depositAccount.Interest.Percent.ToString();
                lblDepositAccountInterestUnitValue.Text = depositAccount.Interest.Unit.ToString();
                lblDepositAccountPeriodAmountValue.Text = depositAccount.Period.Period.ToString();
                lblDepositAccountPeriodUnitValue.Text = depositAccount.Period.Unit.ToString();
                lblDepositAccountStartDateValue.Text = depositAccount.StartDate.ToShortDateString();
                //this.PopulateAccountLabels(depositAccount);
            }
            else
            {
                lblDepositAccountEndDateValue.Text = "";
                lblDepositAccountInterestPercentValue.Text = "";
                lblDepositAccountInterestUnitValue.Text = "";
                lblDepositAccountPeriodAmountValue.Text = "";
                lblDepositAccountPeriodUnitValue.Text = "";
                lblDepositAccountStartDateValue.Text = "";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (UnitOfTime unit in Enum.GetValues(typeof(UnitOfTime)))
            {
                cmbDepositAccountInterestUnit.Items.Add(unit);
                cmbDepositAccountPeriodUnit.Items.Add(unit);
            }
            cmbDepositAccountInterestUnit.SelectedIndex = 0;
            this.DisplayTimePeriod();
        }
        /// <summary>
        /// Calculates difference between values of the two DateTimePickers and 
        /// displays the values in the appropriate controls.
        /// </summary>
        private void DisplayTimePeriod()
        {
            TimeSpan dateDifference = dtpDepositAccountEndDate.Value - dtpDepositAccountStartDate.Value;
            int daysDifference = Int32.Parse(Math.Round(dateDifference.TotalDays).ToString());
            if (daysDifference >= 365)
            {
                txtDepositAccountPeriodAmount.Text = (daysDifference / 365).ToString();
                cmbDepositAccountPeriodUnit.SelectedIndex = 2;
            }
            else if (daysDifference >= 31)
            {
                txtDepositAccountPeriodAmount.Text = (daysDifference / 31).ToString();
                cmbDepositAccountPeriodUnit.SelectedIndex = 1;
            }
            else
            {              
                txtDepositAccountPeriodAmount.Text = (daysDifference).ToString();
                cmbDepositAccountPeriodUnit.SelectedIndex = 0;
            }
        }

        private CurrencyAmount CreateTransactionAmount()
        {
            CurrencyAmount currencyAmmount = new CurrencyAmount();
            currencyAmmount.Amount = Decimal.Parse(txtTransactionAmount.Text);
            currencyAmmount.Currency = txtTransactionCurrency.Text;
            return currencyAmmount;
        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            ILoanAccount loanAccount = CreateLoanAccount();
            IDepositAccount depositAccount = CreateDepositAccount();
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            CurrencyAmount currencyAmmount = this.CreateTransactionAmount();
            TransactionStatus transactionStatus = TransactionStatus.InProcess;
            bool _errorOccurred = false;
            string _errorMsg = null;
            try
            {
                transactionStatus = transactionProcessor.ProcessTransaction
                    (TransactionType.Transfer, currencyAmmount, loanAccount, depositAccount);
            }
            catch (CurrencyMismatchException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
                transactionStatus = TransactionStatus.Failed;
            }
            catch (ApplicationException)
            {
                throw;
            }
            finally
            {
                if (_errorOccurred)
                {
                    MessageBox.Show(_errorMsg);
                }
            }
            
            if (transactionStatus == TransactionStatus.Completed)
            {
                this.DisplayLastTransactionDetails();
                //this.PopulateDepositAccountLabels(depositAccount);
            }
            else
            {
                MessageBox.Show("Transaction was not completed because of transaction status = " + transactionStatus);
            }
        }

        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            IAccount[] accounts = new IAccount[2];
            Dictionary<CreateAccountType, IAccount> dictionary =
                this.CreateAccounts(CreateAccountType.TransactionAccount, null);
            IAccount transactionAccount;
            dictionary.TryGetValue(CreateAccountType.TransactionAccount, out transactionAccount);
             dictionary =
                this.CreateAccounts(CreateAccountType.DepositAccount | CreateAccountType.LoanAccount, 
                transactionAccount as ITransactionAccount);
            dictionary.TryGetValue(CreateAccountType.DepositAccount, out accounts[0]);
            dictionary.TryGetValue(CreateAccountType.LoanAccount, out accounts[1]);
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            CurrencyAmount currencyAmount = this.CreateTransactionAmount();
            //Testing cases
            //accounts = null;
            //accounts = new IAccount[2];
            //accounts[0] = null;
            //accounts[1] = null;
            
            TransactionStatus transactionStatus = TransactionStatus.InProcess;
            bool _errorOccurred = false;
            string _errorMsg = null;
            try
            {
                transactionStatus = transactionProcessor.ProcessGroupTransaction
                    (TransactionType.Debit, currencyAmount, accounts);
            }
            catch (CurrencyMismatchException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
                transactionStatus = TransactionStatus.Failed;
            }
            catch (ApplicationException)
            {
                throw;
            }
            finally
            {
                if (_errorOccurred)
                {
                    MessageBox.Show(_errorMsg);
                }
            }
            if (transactionStatus == TransactionStatus.Completed)
            {
                this.DisplayLastTransactionDetails();
            }
            else if (transactionStatus == TransactionStatus.Failed)
            {
                MessageBox.Show("Group Transaction was not completed because of transaction status = " + transactionStatus);
            }
            else
            {
                MessageBox.Show("Group Transaction was not fully completed because of transaction status = " + transactionStatus);
            }
        }
        /// <summary>
        /// Gets the last TransactionLogEntry from the transaction processor using the LastTransaction property and 
        /// displays the details in the appropriate labels as well as the transaction count.
        /// </summary>
        private void DisplayLastTransactionDetails()
        {
            TransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            int count = transactionProcessor.TransactionCount;
            TransactionLogEntry transactionLogEntry = transactionProcessor[count - 1];           
            lblTotalTransactionCountValue.Text = count.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("transactionType = " + transactionLogEntry.TransactionType.ToString());
            stringBuilder.Append("\namountCurrency = " + transactionLogEntry.Amount.Currency);
            stringBuilder.Append("\namountValue = " + transactionLogEntry.Amount.Amount.ToString());
            stringBuilder.Append("\nstatus = " + transactionLogEntry.Status.ToString());
            stringBuilder.Append("\nAccounts:");
            foreach (IAccount account in transactionLogEntry.Accounts)
            {
                stringBuilder.Append("\nId = " + account.Id + " Number = " + account.Number + " Balance = " + account.Balance.Amount + " Currency = " + account.Currency);
            }
            lblTransactionLogEntryDetailsValue.Text = stringBuilder.ToString();
        }
        /// <summary>
        /// Handler for the OnBalanceChanged event that prints a message with the event arguments details to the console output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void Account_OnBalanceChanged(Object sender, BalanceChangedEventArguments eventArgs)
        {
            StringBuilder outputMessage = new StringBuilder();
            outputMessage.Append("\n\nBalance changed:\n");
            outputMessage.Append("AccountId: " + eventArgs.Account.Id);
            outputMessage.Append("\nAccountNumber: " + eventArgs.Account.Number);
            outputMessage.Append("\nAccountCurrency: " + eventArgs.Account.Currency);
            outputMessage.Append("\nAccountBalance.Amount: " + eventArgs.Account.Balance.Amount);
            outputMessage.Append("\nChange.Amount: " + eventArgs.Change.Amount);
            outputMessage.Append("\nChange.Currency: " + eventArgs.Change.Currency + "\n");
            Console.WriteLine(outputMessage.ToString());
        }
        /// <summary>
        /// Checks which flags are set in the provided parameter and creates the appropriate accounts 
        /// by calling the Create methods.
        /// </summary>
        /// <param name="accountTypesToCreate"></param>
        /// <param name="transactionAccount"></param>
        /// <returns></returns>
        private Dictionary<CreateAccountType, IAccount> 
            CreateAccounts(CreateAccountType accountTypesToCreate, ITransactionAccount transactionAccount)
        {
            Dictionary<CreateAccountType, IAccount> dictionary = new Dictionary<CreateAccountType, IAccount>();
            if ((accountTypesToCreate & CreateAccountType.DepositAccount) == CreateAccountType.DepositAccount)
            {
                dictionary.Add(CreateAccountType.DepositAccount, this.CreateAccount<DepositAccount>(transactionAccount));
            }
            if ((accountTypesToCreate & CreateAccountType.LoanAccount) == CreateAccountType.LoanAccount)
            {
                dictionary.Add(CreateAccountType.LoanAccount, this.CreateAccount<LoanAccount>(transactionAccount));
            }
            if ((accountTypesToCreate & CreateAccountType.TransactionAccount) == CreateAccountType.TransactionAccount)
            {
                dictionary.Add(CreateAccountType.TransactionAccount, this.CreateTransactionAccount());
            }
            return dictionary;
        }

        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            CurrencyAmount amount = new CurrencyAmount();
            amount.Amount = 15;
            amount.Currency = "MKD";
            IAccount[] accounts = new IAccount[2];
            accounts[0] = this.CreateDepositAccount();
            accounts[1] = this.CreateLoanAccount();
            transactionProcessor.ChargeProcessingFee(amount, accounts);
            this.DisplayLastTransactionDetails();
        }

        private void dtpDepositAccountStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDepositAccountEndDate.Value >= dtpDepositAccountStartDate.Value)
            {
                this.DisplayTimePeriod();
            }
            else
            {
                dtpDepositAccountStartDate.Value = dtpDepositAccountEndDate.Value;
                MessageBox.Show("Start Date can not be greater than end date! Change first End Date.");
            }
        }

        private void dtpDepositAccountEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDepositAccountEndDate.Value >= dtpDepositAccountStartDate.Value)
            {
                this.DisplayTimePeriod();
            }
            else
            {
                dtpDepositAccountEndDate.Value = dtpDepositAccountStartDate.Value;
                MessageBox.Show("Start Date can not be greater than end date! Change first Start Date.");
            }
        }

        private void txtDepositAccountPeriodAmount_Leave(object sender, EventArgs e)
        {
            this.RefreshDates();
        }
        /// <summary>
        /// Refreshes the end date of the deposit account depending of the entered time period.
        /// </summary>
        private void RefreshDates()
        {
            DateTime endDepositDate = dtpDepositAccountEndDate.Value;
            DateTime startDepositDate = dtpDepositAccountStartDate.Value;
            UnitOfTime timeUnit = (UnitOfTime)cmbDepositAccountPeriodUnit.SelectedItem;
            switch (timeUnit)
            {
                case UnitOfTime.Day:
                    double amount = Double.Parse(txtDepositAccountPeriodAmount.Text);
                    endDepositDate = startDepositDate.AddDays(amount);
                    break;
                case UnitOfTime.Month:
                    endDepositDate = startDepositDate.AddMonths(Int32.Parse(txtDepositAccountPeriodAmount.Text));
                    break;
                case UnitOfTime.Year:
                    endDepositDate = startDepositDate.AddYears(Int32.Parse(txtDepositAccountPeriodAmount.Text));
                    break;
                default:
                    break;
            }
            dtpDepositAccountEndDate.Value = endDepositDate;
            dtpDepositAccountEndDate.Update();
        }

        private void cmbDepositAccountPeriodUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshDates();
        }
    }
}
