using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Extensions
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor,
            CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            IAccount[] accountsArray = accounts.ToArray<IAccount>();
            return processor.ProcessGroupTransaction(TransactionType.Debit, amount, accountsArray);
        }
    }
}
