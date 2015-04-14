using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Helpers;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Processors
{
    /// <summary>
    /// 
    /// </summary>
    public class TransactionProcessor:ITransactionProcessor
    {
        private static TransactionProcessor s_transactionProcessorInstance;
        static TransactionProcessor()
        {
            s_transactionProcessorInstance = new TransactionProcessor();
            s_transactionProcessorInstance.ExternalLogger = AccountHelper.LogTransaction;
            s_transactionProcessorInstance.ExternalLogger += AccountHelper.NotifyNationalBank;
        }
        private IList<TransactionLogEntry> _transactionLog;
        private TransactionProcessor ()
	    {
            _transactionLog = new List<TransactionLogEntry>();
	    }
        /// <summary>
        ///For Transfer type of transaction the DebitAmount method is called on the account passed in the accountFrom parameter and the CreditAmount method is called on the account passed in the accountTo parameter.
        ///For Debit type of transaction the DebitAmount method is called on the account passed in the AccountFrom parameter.
        ///For Credit type of transaction the CreditAmount method is called on the account passed in the AccountFrom parameter.
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accountFrom"></param>
        /// <param name="accountTo"></param>
        /// <returns></returns>
        public TransactionStatus ProcessTransaction(TransactionType transactionType, 
            CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
        {
            TransactionStatus transactionStatus = TransactionStatus.InProcess;
            switch (transactionType)
            {
                case TransactionType.Transfer:
                    transactionStatus = accountFrom.DebitAmount(amount);
                    this.CallExternalLogger(accountFrom, transactionType, amount);
                    if (transactionStatus == TransactionStatus.Completed)
                    {
                        transactionStatus = accountTo.CreditAmount(amount);
                        this.CallExternalLogger(accountTo, transactionType, amount);
                    }
                    break;
                case TransactionType.Debit:
                    transactionStatus = accountFrom.DebitAmount(amount);
                    this.CallExternalLogger(accountFrom, transactionType, amount);
                    break;
                case TransactionType.Credit:
                    transactionStatus = accountFrom.CreditAmount(amount);
                    this.CallExternalLogger(accountFrom, transactionType, amount);
                    break;
                default:
                    transactionStatus = TransactionStatus.Failed;
                    break;
            }
            IAccount[] accounts = new IAccount[2] {accountFrom, accountTo};
            this.LogTransaction(transactionType, amount, accounts, transactionStatus);
            return transactionStatus;
        }

        /// <summary>
        /// First checks if the provided transaction type is Credit or Debit and if it is not returns TransactionFailed.
        /// - For the Credit/Debit transaction type itterates through the accounts in the array and for each account calls the CreditAmount/DebitAmount appropriately.
        /// If accounts is null returns TransactionFailed.
        /// If some of the accounts is null returns TransactionCompletedWithWarning.
        /// If all of the accounts are null returns TransactionFailed.
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            TransactionStatus transactionStatus = TransactionStatus.InProcess;
            if ((accounts == null))
            {
                transactionStatus = TransactionStatus.Failed;
            }
            if ((transactionType != TransactionType.Credit) && (transactionType != TransactionType.Debit))
            {
                transactionStatus = TransactionStatus.Failed;
            }
            else if (transactionStatus != TransactionStatus.Failed)
            {
                foreach (IAccount account in accounts)
                {
                    if (account == null)
                    {
                        if ((transactionStatus == TransactionStatus.Completed) || (transactionStatus == TransactionStatus.CompletedWithWarning))
	                    {
		                    transactionStatus = TransactionStatus.CompletedWithWarning;
	                    }
                        else
	                    {
                            transactionStatus = TransactionStatus.Failed;
	                    }
                        continue;
                    }
                    if (transactionType == TransactionType.Credit)
                    {
                            account.CreditAmount(amount);
                            this.CallExternalLogger(account, transactionType, amount);
                    }
                    else
	                {
                            account.DebitAmount(amount);
                            this.CallExternalLogger(account, transactionType, amount);
	                }
                           
                    if ((transactionStatus == TransactionStatus.Failed) || (transactionStatus == TransactionStatus.CompletedWithWarning))
                    {
                        transactionStatus = TransactionStatus.CompletedWithWarning;
                    }
                    else
                    {
                        transactionStatus = TransactionStatus.Completed;
                    }
                }
            }
            this.LogTransaction(transactionType, amount, accounts, transactionStatus);
            return transactionStatus;
        }
        /// <summary>
        /// Creates an instance of the TransactionLogEntry class and add this instance in the _transactionLog collection.
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <param name="transactionStatus"></param>
        /// <returns></returns>
        private TransactionLogEntry LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            TransactionLogEntry transactionLogEntry = new TransactionLogEntry();
            transactionLogEntry.Accounts = accounts;
            transactionLogEntry.Amount = amount;
            transactionLogEntry.Status = transactionStatus;
            transactionLogEntry.TransactionType = transactionType;
            _transactionLog.Add(transactionLogEntry);
            return transactionLogEntry;
        }

        /// <summary>
        /// If the _transactionLog does not contain entries then returns null.
        /// </summary>
        public TransactionLogEntry LastTransaction
        {
            get 
            {
                if (_transactionLog.Count == 0)
                {
                    return null;
                }
                else
                {
                    return this[_transactionLog.Count - 1];
                }
            }
        }
        /// <summary>
        /// Counts how many transactions were executed so far.
        /// </summary>
        public int TransactionCount
        {
            get { return _transactionLog.Count; }
        }
        /// <summary>
        /// Returns the TransactionLogEntry at the specified index by the indexer parameter. 
        /// Checks if the index is out of bounds of the collection and if this is the case returns null.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TransactionLogEntry this[int index]
        {
            get 
            {
                try
                {
                    return _transactionLog[index];
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Create an instance that implements of the TransactionProcesor class using the Singleton pattern.
        /// </summary>
        /// <returns></returns>
        public static TransactionProcessor GetTransactionProcessor()
        {
            return s_transactionProcessorInstance;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransactionLogger ExternalLogger
        {
            get;
            set;
        }
        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            this.ExternalLogger(account, transactionType, amount);
        }

        //We have this method as extension in Extensions.ProcessorExtensions class
        //public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
