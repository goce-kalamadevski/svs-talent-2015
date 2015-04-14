using CSharpProgrammingBasics.Classes.Accounts;
using System;
namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface IDepositAccount:IAccount
    {
        DateTime EndDate { get; }
        CSharpProgrammingBasics.Classes.Common.InterestRate Interest { get; }
        CSharpProgrammingBasics.Classes.Common.TimePeriod Period { get; }
        DateTime StartDate { get; }
        ITransactionAccount TransactionAccount { get; }
    }
}
