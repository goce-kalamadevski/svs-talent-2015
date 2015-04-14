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
    [AccountMetadata(AccountDescription = "DepositAccountDescription", AccountLimitations = "DepositAccountLimitations")]
    public class DepositAccount:Account, IDepositAccount
    {
        private TimePeriod _period;
        /// <summary>
        /// 
        /// </summary>
        public TimePeriod Period
        {
            get { return _period; }
            private set { _period = value; }
        }
        private InterestRate _interest;
        /// <summary>
        /// 
        /// </summary>
        public InterestRate Interest
        {
            get { return _interest; }
            private set { _interest = value; }
        }
        private DateTime _startDate;
        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDate
        {
            get { return _startDate; }
            private set { _startDate = value; }
        }
        private DateTime _endDate;
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate
        {
            get { return _endDate; }
            private set { _endDate = value; }
        }
        private ITransactionAccount _transactionAccount;
        /// <summary>
        /// 
        /// </summary>
        public ITransactionAccount TransactionAccount
        {
            get { return _transactionAccount; }
            private set { _transactionAccount = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="depositPeriod"></param>
        /// <param name="interestRate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="transactionAccount"></param>
        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount):base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<DepositAccount>(this.Id);
        }
    }
}
