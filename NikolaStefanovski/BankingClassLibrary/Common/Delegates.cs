using BankingClassLibrary.Common;
using BankingClassLibrary.Interfaces;

public delegate void TrasactionLogger(IAccount account, TransactionType type, CurrencyAmount amount); 