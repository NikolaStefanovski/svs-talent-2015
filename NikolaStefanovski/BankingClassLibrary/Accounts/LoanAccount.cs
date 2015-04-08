using BankingClassLibrary.Accounts;
using BankingClassLibrary.Common;
using BankingClassLibrary.Helpers;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Accounts
{
    /// <summary>
    /// A class modeling a loan account, not inheritable (sealed).
    /// </summary>
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        /// <summary>
        /// Full constructor with base from DepositAccount (skeleton Account constr.)
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="timePeriod"></param>
        /// <param name="interestRate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="transactionAccount"></param>
        public LoanAccount(string currency, TimePeriod timePeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount) : base(currency, timePeriod, interestRate, startDate, endDate, transactionAccount)
        {
            _number = GenerateAccountNumber();
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<LoanAccount>(ID);
        }

        #region Public methods
        /// <summary>
        /// Method for decreasing the loan account balance (returning the debt = decreasing the loan).
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (!IsCurrencyAmountOK(amount)) return TransactionStatus.Failed;
            _balance.Amount -= amount.Amount;
            return TransactionStatus.Completed;
        }

        /// <summary>
        /// Method for increasing the loan account balance (asking for more money = increasing the loan).
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (!IsCurrencyAmountOK(amount)) return TransactionStatus.Failed;
            _balance.Amount += amount.Amount;
            return TransactionStatus.Completed;
        }
        #endregion
    }
}
