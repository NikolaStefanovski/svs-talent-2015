using BankingClassLibrary.Common;
using BankingClassLibrary.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionLogEntry LastTransaction { get; }
        int TransactionCount { get; }
        TransactionLogEntry this[int key] { get; }
        TransactionLogger ExternalLogger { get; set; }

        void ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount);
        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);

        TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);
    }
}
