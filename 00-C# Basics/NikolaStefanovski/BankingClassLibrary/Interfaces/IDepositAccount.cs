﻿using System;
namespace BankingClassLibrary.Accounts
{
    public interface IDepositAccount : IAccount
    {
        DateTime EndDate { get; }
        BankingClassLibrary.Common.InterestRate Interest { get; }
        BankingClassLibrary.Common.TimePeriod Period { get; }
        DateTime StartDate { get; }
        ITransactionAccount TransactionAccount { get; }
    }
}
