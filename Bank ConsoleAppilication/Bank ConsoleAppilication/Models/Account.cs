using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Bank_ConsoleAppilication.Utilits.Exception.BankOfExceptions;

namespace Bank_ConsoleAppilication.Models
{
    internal class Account : IAccount
    {


        public int AccountId { get; private set; }
        public decimal Balance { get; private set; }
        private List<Transaction> transactions;

        public Account(int accountId)
        {
            AccountId = accountId;
            Balance = 0;
            transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Məbləğ sıfırdan kiçik və ya mənasızdır.");
            }
            Balance += amount;
            transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Məbləğ sıfırdan kiçik və ya mənasızdır.");
               

            if (amount > Balance)
            {
                    Console.WriteLine("Hesabınızda kifayət qədər pul yoxdur.");
                }
           
            Balance -= amount;
            transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }


    }
}
