using System;
namespace BankingClassLibrary.Interfaces
{
    public interface ITransactionAccount : IAccount
    {
        BankingClassLibrary.Common.CurrencyAmount Limit { get; set; }
    }
}
