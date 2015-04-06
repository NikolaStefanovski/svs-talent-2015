using System;
namespace BankingClassLibrary.Accounts
{
    public interface ITransactionAccount : IAccount
    {
        BankingClassLibrary.Common.CurrencyAmount Limit { get; set; }
    }
}
