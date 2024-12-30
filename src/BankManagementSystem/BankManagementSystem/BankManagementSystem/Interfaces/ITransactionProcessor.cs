using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Interfaces
{
    interface ITransactionProcessor
    {
        void Deposit(string accountNumber, double Amount);
        void Withdraw(string accountNumber, double Amount);
    }
}
