using BankingClassLibrary.Common;
using System;
namespace BankingClassLibrary.Interfaces
{
    public interface IAccount
    {
        BankingClassLibrary.Common.CurrencyAmount Balance { get; }
        BankingClassLibrary.Common.TransactionStatus CreditAmount(BankingClassLibrary.Common.CurrencyAmount amount);
        string Currency { get; }
        BankingClassLibrary.Common.TransactionStatus DebitAmount(BankingClassLibrary.Common.CurrencyAmount amount);
        long ID { get; }
        string Number { get; }
        event BalanceChanged OnBalanceChanged;
    }
}
