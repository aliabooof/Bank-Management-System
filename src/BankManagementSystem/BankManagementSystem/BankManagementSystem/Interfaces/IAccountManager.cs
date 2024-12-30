using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Interfaces
{
    interface IAccountManager
    {
        void CreateAccount(string accountNumber, double initialBalance);
        void ListAccounts();
    }
}
