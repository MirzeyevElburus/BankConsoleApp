using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ConsoleAppilication.Utilits.Exception
{
    internal class BankOfExceptions : IOException
    {
        public class InsufficientFundsException : IOException
        {
            public InsufficientFundsException(string message) : base("Hesabinizdaki mebleqden çıxış etmek") { }
        }
        public class AccountNotFoundException : IOException
        {
            public AccountNotFoundException(string message) : base("Daxil etdiyiniz mebleq movcud deyil") { }
        }
        public class InvalidAmountException : IOException
        {
            public InvalidAmountException(string message) : base("Daxil etdiyiniz mebleq sifirdan kiçik ve ya mənasizidr") { }
        }
    }
}
