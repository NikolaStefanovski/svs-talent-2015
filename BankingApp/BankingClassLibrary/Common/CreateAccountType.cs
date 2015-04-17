using System;

namespace BankingClassLibrary.Common
{
    [Flags]
    public enum CreateAccountType
    {
        None, TransactionAccount, DepositAccount, LoanAccount
    }
}