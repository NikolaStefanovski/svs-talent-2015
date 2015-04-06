using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingClassLibrary.Common;

namespace BankingClassLibrary.Accounts
{
    /// <summary>
    /// Base type for defining a bank account, contains an account id, a transactaion account number, the currency type and the total balance.
    /// </summary>
    abstract public class Account : IAccount
    {
        #region Fields and properties
        private long _id;
        private string _number;
        private string _currency;
        private CurrencyAmount _balance;

        /// <summary>
        /// ID number of the account
        /// </summary>
        public long ID { get { return _id; } private set { _id = value; } }
        /// <summary>
        /// the account number
        /// </summary>
        public string Number { get { return _number; } private set { _number = value; } }
        /// <summary>
        /// the currency type of the account
        /// </summary>
        public string Currency { get { return _currency; } private set { _currency = value; } }
        /// <summary>
        /// the balance of the account
        /// </summary>
        public CurrencyAmount Balance { get { return _balance; } private set { _balance = value; } }
        #endregion

        #region Constructors

        /// <summary>
        /// A constructor for a fully defined account.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="currency"></param>
        public Account(long id, string number, string currency)
        {
            _id = id;
            _number = number;
            _currency = currency;
            _balance.Amount = 0;
            _balance.Currency = "euro";
        }

        /// <summary>
        /// A constructor for a skeleton account (only currency type).
        /// </summary>
        /// <param name="currency"></param>
        public Account(string currency) : this(-1, "X", null)
        {
            _currency = currency;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (!IsCurrencyAmountOK(amount)) return TransactionStatus.Failed;
            _balance.Amount -= amount.Amount;
            return TransactionStatus.Completed;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (!IsCurrencyAmountOK(amount)) return TransactionStatus.Failed;
            _balance.Amount += amount.Amount;
            return TransactionStatus.Completed;
        }
        #endregion

        #region Private methods
        private bool IsCurrencyAmountOK(CurrencyAmount amount)
        {
            return Balance.Currency.Equals(amount.Currency);
        }
        #endregion
    }
}
