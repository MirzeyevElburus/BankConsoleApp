using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_ConsoleAppilication.Utilits.Exception.BankOfExceptions;

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
           foreach(var account in accounts)
            {
                if(account.Balance>amount)
                {
                    account.Balance += amount;
                    return;
                }
            }
        }
        public void WithdrawMoney(int accountId, decimal amount)
        {
            try
            {
                IAccount account = FindAccount(accountId);
                account.Withdraw(amount);
                Console.WriteLine($"{amount:C} Manat pul hesabınızdan çıxarıldı.");
            }
          
            catch (Exception exception)
            {
                Console.WriteLine("Xeta baş verdi.emeliyyatı tekrarlayın.");
            }
        }

        public void TransferMoney(int fromAccountId, int toAccountId, decimal amount)
        {
            try
            {
                IAccount fromAccount = FindAccount(fromAccountId);
                IAccount toAccount = FindAccount(toAccountId);
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine($"{amount:C} Manat pul köçürüldü.");
            }
            
            catch (Exception exception)
            {
                Console.WriteLine("Xeta baş verdi. emeliyyatı tekrarlayın.");
            }
        }

        public List<IAccount> GetAllAccounts()
        {
            return accounts;
        }

        private IAccount FindAccount(int accountId)
        {

          
        }

        private static AccountNotFoundException NewMethod()
        {
            return new AccountNotFoundException();
        }






























        //public void DepositMoney(int accountId, decimal amount)
        //{
        //    IAccount account = FindAccount(accountId);
        //    account.Deposit(amount);
        //}

        //private IAccount FindAccount(int accountId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void WithdrawMoney(string accountId, decimal amount)
        //{
        //    IAccount account = FindAccount(accountId);
        //    account.Withdraw(amount);
        //}

        //private IAccount FindAccount(string accountId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void TransferMoney(string fromAccountId, string toAccountId, decimal amount)
        //{
        //    IAccount fromAccount = FindAccount(fromAccountId);
        //    IAccount toAccount = FindAccount(toAccountId);

        //    fromAccount.Withdraw(amount);
        //    toAccount.Deposit(amount);
        //}

        //public List<IAccount> GetAllAccounts()
        //{
        //    return accounts;
        //}






    }
}
