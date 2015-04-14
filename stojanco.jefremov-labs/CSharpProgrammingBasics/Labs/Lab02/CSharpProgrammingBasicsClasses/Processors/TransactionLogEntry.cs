using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Processors
{
    /// <summary>
    /// 
    /// </summary>
    public class TransactionLogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public TransactionType TransactionType
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public CurrencyAmount Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public IAccount[] Accounts
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public TransactionStatus Status
        {
            get;
            set;
        }
    }
}
