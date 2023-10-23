using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ConsoleAppilication.Models
{
    internal class Bank
    {
        private List<IAccount> accounts;
        private object accoundId;

        public Bank()
        {
            accounts = new List<IAccount>();
        }
        public IAccount CreateAccount()
        {
            int accountId = accounts.Count + 1;
            var account = new Account(accountId);
            accounts.Add(account);
            return account;
        }
        public void DepositMoney(int accountId, decimal amount)
        {
            var account = GetAccountById(accoundId);
            object value = account.Deposit(amount);
        }

        
    }
}
