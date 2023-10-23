using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ConsoleAppilication.Models
{
    internal class Transaction
    {
        public int TransactionId { get;  set; }
        public decimal Amount { get;  set; }
        public DateTime TransactionDate { get;  set; }
        public TransactionType TransactionType { get;  set; }

        private static int transactionCounter = 0;

        public Transaction(decimal amount, TransactionType transactionType)
        {
            TransactionId = ++transactionCounter;
            Amount = amount;
            TransactionType = transactionType;
            TransactionDate = DateTime.Now;
        }
    }

    public class TransactionType
    {
        public static TransactionType Deposit { get;  set; }
        public static TransactionType Withdraw { get; set; }
        public int TransactionId { get;}
    }
    
    
}

