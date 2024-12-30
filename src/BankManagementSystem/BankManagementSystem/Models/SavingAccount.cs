using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Models
{
    class SavingAccount :Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(string accountNumber, double initialBalance, double _interestRate)
            : base(accountNumber , initialBalance)
            => InterestRate = _interestRate;

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }

        public override string ToString()
        {
            return base.ToString() + $", Interest Rate: {InterestRate * 100}%";
        }



    }
}
