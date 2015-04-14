using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Helpers;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Accounts
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Account:IAccount
    {
        private long _id;
        /// <summary>
        /// 
        /// </summary>
        public long Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        [FormatRestriction(FormatString = "XXXX-XXXX-XXXX-XXXX", MaxLength = 16)]
        private string _number;
        /// <summary>
        /// 
        /// </summary>
        public string Number
        {
            get { return _number; }
            private set { _number = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Currency
        {
            get;
            private set;
        }
        private CurrencyAmount _balance;
        /// <summary>
        /// 
        /// </summary>
        public CurrencyAmount Balance
        {
            get { return _balance; }
            ///Checks if the new value for the balance is different from the old and if this is the case calls the OnBalanceChanged event.
            private set 
            {
                if (this._balance.Amount != value.Amount)
                {
                    this.OnBalanceChanged(this, new BalanceChangedEventArguments(this, value));
                }
                _balance = value; 
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="currency"></param>
        public Account(long id, string number, string currency)
        {
            this.Id = id;
            this.Number = number;
            this.Currency = currency;
            CurrencyAmount tempBalance = this.Balance;
            tempBalance.Amount = 0;
            tempBalance.Currency = currency;
            this.Balance = tempBalance;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        public Account(string currency):this(-1,"X",currency)
        {
            this.Id = AccountHelper.GenerateAccountId();
            this.Number = this.GenerateAccountNumber();
        }
        #region PublicMethods
        /// <summary>
        /// Decreases the balance of the account. Returns Completed TransactionStatus.
        /// If the amount provided has not the same currency as the account currency the transaction will not be executed 
        /// and an ApplicationException will be thrown with message that shows the difference.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (!sameCurrencies(amount))
            {
                throw new CurrencyMismatchException("Different currencies! AccountCurrency: " + 
                    this.Currency + " vs amountCurrency: " + amount.Currency);
            }
            else
            {
                CurrencyAmount tempAmount = this.Balance;
                tempAmount.Amount -= amount.Amount;
                this.Balance = tempAmount;
                return TransactionStatus.Completed;
            }
        }
        /// <summary>
        /// Increases the balance of the account. Returns Completed TransactionStatus.
        /// If the amount provided has not the same currency as the account currency the transaction will not be executed 
        /// and an ApplicationException will be thrown with message that shows the difference.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (!sameCurrencies(amount))
            {
                throw new CurrencyMismatchException("Different currencies! AccountCurrency: " +
                    this.Currency + " vs amountCurrency: " + amount.Currency);
            }
            else
            {
                CurrencyAmount tempAmount = this.Balance;
                tempAmount.Amount += amount.Amount;
                this.Balance = tempAmount;
                return TransactionStatus.Completed;
            }
        }
        #endregion
        #region PrivateMethods
        /// <summary>
        /// Checks if the provided amount has the same currency as the account currency.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>true - if two currencies are same.</returns>
        private bool sameCurrencies(CurrencyAmount amount)
        {
            return this.Currency.Equals(amount.Currency);
        }
        #endregion
        protected abstract string GenerateAccountNumber();


        public event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;
    }
}
