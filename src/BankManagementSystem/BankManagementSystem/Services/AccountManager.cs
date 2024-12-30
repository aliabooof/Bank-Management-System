using BankManagementSystem.Interfaces;
using BankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Services
{
    class AccountManager : IAccountManager, ITransactionProcessor
    {
        private readonly List<Account> accounts = new();
        public void CreateAccount(string accountNumber, double initialBalance)
        {
            var account = accounts.Find(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                accounts.Add(new SavingAccount(accountNumber, initialBalance, 0.05));

                Console.WriteLine("Account created successfully!");
            }
            else
            {

                Console.WriteLine("This account is already existed ");
                return;
            }
        }

        public void ListAccounts()

        {
            foreach (var item in accounts)
            {
                Console.WriteLine(item);
                
            }
        }

        public void Deposit(string accountNumber, double Amount)
        {
            var account = accounts.Find(a=>a.AccountNumber == accountNumber);
            if (account == null)
            { 
                Console.WriteLine("Account not found!");
                return;
            }
            account.Deposit(Amount);
            Console.WriteLine($"Deposited {Amount} to account {accountNumber}. New Balance: {account.Balance}");

        }
        public void Withdraw(string accountNumber, double Amount)
        {
            var account = accounts.Find(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found!");
                return;
            }
            if (!account.Withdraw(Amount))
                Console.WriteLine("Insufficient funds!");
            else
                Console.WriteLine($"Withdrew {Amount} from account {accountNumber}. New Balance: {account.Balance}");


        }
    }
}
