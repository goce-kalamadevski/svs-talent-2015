using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);
public delegate void BalanceChanged(Object sender, BalanceChangedEventArguments eventArgs);

public class BalanceChangedEventArguments:EventArgs
{
    public BalanceChangedEventArguments(IAccount account, CurrencyAmount amount)
    {
        this.Account = account;
        this.Change = amount;
    }
    public IAccount Account
    {
        get;
        private set;
    }
    public CurrencyAmount Change
    {
        get;
        private set;
    }
}