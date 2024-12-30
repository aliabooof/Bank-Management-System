using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Models.Interfaces
{
    interface IAccountManager
    {
        void CreateAccount(string accountNumber, double initialBalance);
        void ListAccounts();
    }
}
