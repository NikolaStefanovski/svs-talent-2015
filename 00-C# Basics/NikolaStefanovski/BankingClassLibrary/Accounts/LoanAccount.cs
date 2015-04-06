using BankingClassLibrary.Account;
using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Accounts
{
    sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        public LoanAccount(string currency, TimePeriod timePeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount) : base(currency, timePeriod, interestRate, startDate, endDate, transactionAccount)
        {

        }
    }
}
