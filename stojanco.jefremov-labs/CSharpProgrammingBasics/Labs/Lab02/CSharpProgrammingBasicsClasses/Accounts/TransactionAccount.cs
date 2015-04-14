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
    [AccountMetadata(AccountDescription = "TransactionAccountDescription", AccountLimitations = "TransactionAccountLimitations")]
    public class TransactionAccount:Account, ITransactionAccount
    {
        private CurrencyAmount _limit;
        /// <summary>
        /// 
        /// </summary>
        public CurrencyAmount Limit
        {
            get { return _limit; }
            private set { _limit = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount):base(currency)
        {
            CurrencyAmount tempAmount = this.Limit;
            tempAmount.Amount = limitAmount;
            tempAmount.Currency = currency;
            this.Limit = tempAmount;
            this.OnBalanceChanged += TransactionAccount_OnBalanceChanged;
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<TransactionAccount>(this.Id);
        }
        /// <summary>
        /// Checks if the limit is reached. When a transaction is initiated that will overflow the limit throws an exception.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void TransactionAccount_OnBalanceChanged(Object sender, BalanceChangedEventArguments eventArgs)
        {
            //TODO When is limit reached. When balance is bigger or smaller than limit????
            if (this.Balance.Amount <= this.Limit.Amount)
            {
                throw new LimitOverflowException("Limit overflowed!!! Limit: " + this.Limit.Amount +
                " Balance: " + this.Balance.Amount);
            }
        }
    }
}
