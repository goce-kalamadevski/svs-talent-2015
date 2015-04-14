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
    [AccountMetadata(AccountDescription = "LoanAccountDescription", AccountLimitations = "LoanAccountLimitations")]
    public sealed class LoanAccount:DepositAccount, ILoanAccount
    {
        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount)
        {

        }
        /// <summary>
        /// Increase the balance since more money are taken from this loan account. Returns Completed TransactionStatus.
        /// If the amount provided has not the same currency as the account currency the transaction will not be executed and the Failed TransactionStatus will be returned.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
           
            return base.CreditAmount(amount);
        }
        /// <summary>
        /// Decrease the balance since money are returned to the laon account. Returns Completed TransactionStatus.
        /// If the amount provided has not the same currency as the account currency the transaction will not be executed and the Failed TransactionStatus will be returned.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            return base.DebitAmount(amount);
        }
        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<LoanAccount>(this.Id);
        }
    }
}
