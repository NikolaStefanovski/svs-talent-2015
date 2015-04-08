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
    /// Base type for defining a bank account, contains an account id, a transactaion account number, the currency type and the total balance.
    /// </summary>
    abstract public class Account : IAccount
    {
        #region Fields and properties
        protected long _id;
        protected string _number;
        protected string _currency;
        protected CurrencyAmount _balance;

        protected event BalanceChanged OnBalanceChanged;

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
        public CurrencyAmount Balance 
        { 
            get { return _balance; } 
            private set 
            {
                CurrencyAmount temp = value;
                CurrencyAmount ch;
                ch.Currency = temp.Currency;
                if (temp.Amount > _balance.Amount) ch.Amount = temp.Amount - _balance.Amount;
                else ch.Amount = _balance.Amount - temp.Amount;
                if (temp.Amount != _balance.Amount)
                {
                    OnBalanceChanged(this, new BalanceChangedEventArguments(this, ch));
                }
                
                _balance = value; 
            } 
        }
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
            _balance.Currency = currency;
        }

        /// <summary>
        /// A constructor for a skeleton account (only currency type).
        /// </summary>
        /// <param name="currency"></param>
        public Account(string currency) : this(AccountHelper.GenerateAccountId(), "X", currency) 
        {
    
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Method for taking money from the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (!IsCurrencyAmountOK(amount)) return TransactionStatus.Failed;
            _balance.Amount -= amount.Amount;
            return TransactionStatus.Completed;
        }
        /// <summary>
        /// Method for putting money into the account.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (!IsCurrencyAmountOK(amount)) return TransactionStatus.Failed;
            _balance.Amount += amount.Amount;
            return TransactionStatus.Completed;
        }
        #endregion

        #region Private methods
        protected abstract string GenerateAccountNumber();

        /// <summary>
        /// Checks if the currency of the account equals with the currency of any incoming or outgoing amount.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        protected bool IsCurrencyAmountOK(CurrencyAmount amount)
        {
            return Balance.Currency.Equals(amount.Currency);
        }
        #endregion
    }
}
