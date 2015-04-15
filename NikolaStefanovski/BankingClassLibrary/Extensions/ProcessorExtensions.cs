using BankingClassLibrary.Accounts;
using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Extensions
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            IAccount[] array = accounts.ToArray<IAccount>();
            return processor.ProcessGroupTransaction(TransactionType.Debit, amount, array);
        }
    }
}
