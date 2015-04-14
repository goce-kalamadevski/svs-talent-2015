using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITransactionProcessor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accountFrom"></param>
        /// <param name="accountTo"></param>
        /// <returns></returns>
        TransactionStatus ProcessTransaction(TransactionType transactionType, 
            CurrencyAmount amount, IAccount accountFrom, IAccount accountTo);
        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);
        TransactionLogEntry LastTransaction
        {
            get;
        }
        int TransactionCount
        {
            get;
        }
        TransactionLogEntry this[int index]
        {
            get;
        }
        TransactionLogger ExternalLogger
        {
            get;
            set;
        }
        //TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);
    }
}
