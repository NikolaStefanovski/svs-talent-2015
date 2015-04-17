using BankingClassLibrary.Accounts;
using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Processors
{
    public class TransactionLogEntry
    {
        private TransactionType _transactionType;
        private CurrencyAmount _amount;
        private IAccount[] _accounts;
        private TransactionStatus _status;

        public TransactionType TransactionType { get { return _transactionType; } private set { _transactionType = value; } }
        public CurrencyAmount Amount { get { return _amount; } private set { _amount = value; } }
        public IAccount[] Accounts { get { return _accounts; } private set { _accounts = value; } }
        public TransactionStatus Status { get { return _status; } private set { _status = value; } }

        public TransactionLogEntry(TransactionType type, CurrencyAmount amount, IAccount[] accounts, TransactionStatus status)
        {
            _transactionType = type;
            _amount = amount;
            _accounts = accounts;
            _status = status;
        }
    }
}
