using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Common;

namespace CSharpProgrammingBasics.Classes.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class AccountHelper
    {
        private static int s_accountId;
        /// <summary>
        /// Increase the private static s_AccountId variable and returns the new value.
        /// </summary>
        /// <returns></returns>
        public static int GenerateAccountId()
        {
            return ++s_accountId;
        }
        /// <summary>
        /// 
        /// </summary>
        static AccountHelper()
        {
            s_accountId = 0;
        }
        /// <summary>
        /// Checks what is the type provided in the parameter and according to the type generates an account number in the following format:
        /// - When type = TransactionAccount, TR0000AccountId
        /// - When type = DepositAccount, DP0000AccountId
        /// - When type = LoanAccount, LN0000AccountId.
        /// - If none of the previous types is provided returns null.
        /// </summary>
        /// <param name="accountType"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static string GenerateAccountNumber(Type accountType, long accountId)
        {
            string accountNumber = null;
            if (accountType == typeof(TransactionAccount))
            {
                accountNumber = "TR0000" + accountId;
            }
            else if (accountType == typeof(DepositAccount))
            {
                accountNumber = "DP0000" + accountId;
            }
            else if (accountType == typeof(LoanAccount))
            {
                accountNumber = "LN0000" + accountId;
            }
            return accountNumber;
        }
        /// <summary>
        /// Uses the generic type provided in the method call to find the type of the account for which the number should be generated.
        ///- Calls the GenerateAccountNumber(Type accountType, long accountId) method to generate the actual number.
        /// </summary>
        /// <typeparam name="AccountType"></typeparam>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static string GenerateAccountNumber<AccountType>(long accountId) where AccountType : IAccount
        {
            return GenerateAccountNumber(typeof(AccountType),accountId);
        }
        /// <summary>
        /// Checks whether the amount exceeds 20000 MKD and if this is the case then writes the 
        /// accountNumber, transactionType, amount and amountCurrency to the console output.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if ((amount.Currency.Equals("MKD")) && (amount.Amount > 20000))
            {
                StringBuilder output = new StringBuilder();
                output.Append("Amount exceeds 20000!!!\n");
                output.Append("accountNumber: " + account.Number);
                output.Append("\ntransactionType: " + transactionType);
                output.Append("\namount: " + amount.Amount);
                output.Append("\namountCurrency: " + amount.Currency + "\n");
                Console.WriteLine(output.ToString());
            }
        }
        /// <summary>
        /// Checks whether the amount exceeds 25000 MKD and if this is the case writes a notification message 
        /// in the console output that mimics the national bank notification.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if ((amount.Currency.Equals("MKD")) && (amount.Amount > 25000))
            {
                Console.WriteLine("Notification for National Bank because amount exceeded 25000 MKD...\n");
            }
        }
    }
}
