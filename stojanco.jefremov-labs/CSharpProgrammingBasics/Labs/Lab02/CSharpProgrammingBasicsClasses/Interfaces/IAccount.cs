using CSharpProgrammingBasics.Classes.Common;
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
    public interface IAccount
    {
        /// <summary>
        /// 
        /// </summary>
        long Id
        {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        string Number
        {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        string Currency
        {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        CurrencyAmount Balance
        {
            get;
        }
        /// <summary>
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        TransactionStatus DebitAmount(CurrencyAmount amount);
        /// <summary>
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        TransactionStatus CreditAmount(CurrencyAmount amount);
        event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;
    }
}
