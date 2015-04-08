using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        #region Fields and props
        private IList<TransactionLogEntry> _transactionLog;
        private static TransactionProcessor _instance;

        /// <summary>
        /// Propert for getting last transaction
        /// </summary>
        public TransactionLogEntry LastTransaction 
        {
            get
            {
                if (_transactionLog == null) return null;
                if (_transactionLog.Count == 0) return null;
                return _transactionLog[_transactionLog.Count - 1];
            } 
        }

        /// <summary>
        /// Prop for keeping transaction count
        /// </summary>
        public int TransactionCount { get; private set; }

        /// <summary>
        /// Indexer for the entries
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TransactionLogEntry this[int key] 
        {
            get
            {
                if (key >= _transactionLog.Count) return null;
                return _transactionLog[key];
            }
        }
        #endregion 

        /// <summary>
        /// Private normal constr.
        /// </summary>
        private TransactionProcessor()
        {
            _transactionLog = new List<TransactionLogEntry>();
        }

        /// <summary>
        /// Method for incerasing the count and addind the new entry;
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <param name="transactionStatus"></param>
        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transactionStatus)
        {
            TransactionCount++;
            _transactionLog.Add(new TransactionLogEntry(transactionType, amount, accounts, transactionStatus));
        }

        static TransactionProcessor()
        {
            _instance = new TransactionProcessor();
        }

        #region Public methods
        public static TransactionProcessor GetTransactionProcessor() {
            return _instance;
        }

        public void ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount)
        {
            switch (type)
            {
                case TransactionType.Transfer:
                    accountFrom.DebitAmount(amount);
                    accountTo.CreditAmount(amount);
                    break;
                case TransactionType.Debit:
                    accountFrom.DebitAmount(amount);
                    break;
                case TransactionType.Credit:
                    accountFrom.CreditAmount(amount);
                    break;
            }
            IAccount[] accounts = { accountFrom, accountTo };
            LogTransaction(type, amount, accounts, TransactionStatus.Completed);
        }

        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            if (accounts == null) return TransactionStatus.Failed;
            foreach (IAccount a in accounts)
            {
                //LogTransaction(transactionType, amount, accounts, TransactionStatus.Failed);
                if (a == null) return TransactionStatus.Failed;
            }
            if (transactionType.Equals(TransactionType.Transfer) || transactionType.Equals(TransactionType.none))
            {
                //LogTransaction(transactionType, amount, accounts, TransactionStatus.Failed);
                return TransactionStatus.Failed;
            }
            foreach (IAccount a in accounts) {
                if (transactionType.Equals(TransactionType.Debit))
                {
                    a.DebitAmount(amount);
                }
                else
                {
                    a.CreditAmount(amount);
                }
            }
            LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
            return TransactionStatus.Completed;
        }
        #endregion
    }
}
