using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
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
        }

    }
}
