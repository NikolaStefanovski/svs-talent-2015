using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;

namespace BankingClassLibrary.Common
{
    public delegate void TransactionLogger(IAccount account, TransactionType type, CurrencyAmount amount);

    //public delegate void BalanceChanged(object sender, BalanceChangedEventArguments eventArgs);

    public class BalanceChangedEventArguments : EventArgs
    {
        private IAccount _account;

        public IAccount Account
        {
            get { return _account; }
            private set { _account = value; }
        }

        private CurrencyAmount _change;

        public CurrencyAmount Change
        {
            get { return _change; }
            private set { _change = value; }
        }

        public BalanceChangedEventArguments(IAccount account, CurrencyAmount change)
        {
            _account = account;
            _change = change;
        }
    }
}