using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingClassLibrary.Common;

namespace BankingClassLibrary.Accounts
{
    public class DepositAccount : Account, BankingClassLibrary.Accounts.IDepositAccount
    {
        #region Fields and properties
          
        private TimePeriod _period;
        private InterestRate _interest;
        private DateTime _startDate;
        private DateTime _endDate;
        private TransactionAccount _transactionAccount;

        /// <summary>
        /// Unit of measurement of the deposit (days, months, years) and how many of them
        /// </summary>
        public TimePeriod Period { get { return _period; } private set { _period = value; } }
        /// <summary>
        /// The interest rate and number of installments
        /// </summary>
        public InterestRate Interest { get { return _interest; } private set { _interest = value; } }
        public DateTime StartDate { get { return _startDate; } private set { _startDate = value; } }
        public DateTime EndDate { get { return _endDate; } private set { _endDate = value; } }
        public ITransactionAccount TransactionAccount { get { return _transactionAccount; } private set { _transactionAccount = value; } }
        #endregion

        /// <summary>
        /// A constructor for a skeleton account (no account number and id defined).
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="depositPeriod"></param>
        /// <param name="interestRate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="transactionAccount"></param>
        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount) : base(currency)
        {
            Period = depositPeriod;
            Interest = interestRate;
            StartDate = startDate;
            EndDate = endDate;
            TransactionAccount = transactionAccount;
        }
    }
}
