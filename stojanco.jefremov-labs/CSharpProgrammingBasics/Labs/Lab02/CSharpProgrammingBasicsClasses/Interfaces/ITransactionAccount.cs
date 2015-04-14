using CSharpProgrammingBasics.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface ITransactionAccount:IAccount
    {
        /// <summary>
        /// 
        /// </summary>
        CurrencyAmount Limit
        {
            get;
        }
    }
}
