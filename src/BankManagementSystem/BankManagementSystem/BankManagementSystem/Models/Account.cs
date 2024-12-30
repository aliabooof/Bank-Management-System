using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Models
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }

        public double Balance { get; set; }

        protected Account(string _AccountNumber, double initialBalance)
        {
            AccountNumber = _AccountNumber;
            Balance = initialBalance;
        }

        public virtual void Deposit(double Amount)
          => Balance += Amount;

        public virtual bool Withdraw(double Amount)
        {
            if (Amount > Balance)
                return false;
            Balance -= Amount;
            return true;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Balance: {Balance}";
        }

    }
}

