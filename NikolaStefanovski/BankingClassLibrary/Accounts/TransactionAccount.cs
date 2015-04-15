using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using BankingClassLibrary.Helpers;

namespace BankingClassLibrary.Accounts
{
    /// <summary>
    /// A standard transacton account with an imposed limit.
    /// </summary>
    [AccountMetadata]
    public class TransactionAccount : Account, ITransactionAccount
    {

        #region Fields and properties
        /// <summary>
        /// Field for the limit.
        /// </summary>
        private CurrencyAmount _limit;

        /// <summary>
        /// Property for the limit.
        /// </summary>
        public CurrencyAmount Limit { get { return _limit; } set { _limit = value; } }
        #endregion

        /// <summary>
        /// A constructor for a skeleton transaction account (only the limit and the currecny type are defined).
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount) : base(currency)
        {
            _limit.Amount = limitAmount;
            _number = GenerateAccountNumber();
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<TransactionAccount>(ID);
        }
    }
}
