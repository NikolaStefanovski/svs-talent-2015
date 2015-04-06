using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingClassLibrary.Common;

namespace BankingClassLibrary.Accounts
{
    /// <summary>
    /// A standard transacton account with an imposed limit.
    /// </summary>
    public class TransactionAccount : Account, ITransactionAccount
    {
        /// <summary>
        /// Field for the limit.
        /// </summary>
        private CurrencyAmount _limit;

        /// <summary>
        /// Property for the limit.
        /// </summary>
        public CurrencyAmount Limit { get { return _limit; } set { _limit = value; } }

        /// <summary>
        /// A constructor for a skeleton transaction account (only the limit and the currecny type are defined).
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount) : base(currency)
        {
            _limit.Amount = limitAmount;
        }
    }
}
