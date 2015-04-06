using BankingClassLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Interfaces
{
    public interface ITransactionProcessor
    {
        void ProcessTransaction(TransactionType type, IAccount accountFrom, IAccount accountTo, CurrencyAmount amount);
    }
}
