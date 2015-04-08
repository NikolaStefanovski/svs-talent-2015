using BankingClassLibrary.Accounts;
using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary.Helpers
{
    public static class AccountHelper
    {
        private static int s_AccountId;

        static AccountHelper()
        {
            s_AccountId = 0;
        }

        public static int GenerateAccountId() {
            return s_AccountId++;
        }

        public static string GenerateAccountNumber<T>(long accountId) where T : IAccount
        {
            switch (typeof(T).Name)
            {
                case "TransactionAccount": return "TR0000" + accountId;
                case "DepositAccount": return "DP0000" + accountId;
                case "LoanAccount": return "LN0000" + accountId;
                default: return null;
            }
        }

        public static void LogTransaction(IAccount account, TransactionType type, CurrencyAmount amount)
        {
            if (amount.Amount > 20000)
            {
                Console.WriteLine("Account No.: " + account.Number);
                Console.WriteLine("Type: " + type);
                Console.WriteLine("Amount: " + amount.Amount + " " + amount.Currency);

            }
        }

        public static void NotifyNationalBank(IAccount account, TransactionType type, CurrencyAmount amount) 
        {
            if (amount.Amount > 25000)
            {
                Console.WriteLine("Too much money, off to prison!");
            }
        }
    }
}
