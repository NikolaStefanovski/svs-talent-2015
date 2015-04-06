using System;
namespace BankingClassLibrary.Accounts
{
    interface ITransactionAccount : IAccount
    {
        BankingClassLibrary.Common.CurrencyAmount Limit { get; set; }
    }
}
