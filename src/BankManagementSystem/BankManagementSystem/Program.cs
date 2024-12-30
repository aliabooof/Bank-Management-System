using System;
using BankManagementSystem.Services;

namespace BankManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountManager = new AccountManager();

            while (true)
            {
                Console.WriteLine("\nBank Management System");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. List Accounts");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter Account Number: ");
                        var accNum = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        var initBal = Convert.ToDouble(Console.ReadLine());
                        accountManager.CreateAccount(accNum, initBal);
                        break;
                    case "2":
                        accountManager.ListAccounts();
                        break;
                    case "3":
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        Console.Write("Enter Amount to Deposit: ");
                        var depositAmount = Convert.ToDouble(Console.ReadLine());
                        accountManager.Deposit(accNum, depositAmount);
                        break;
                    case "4":
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        Console.Write("Enter Amount to Withdraw: ");
                        var withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        accountManager.Withdraw(accNum, withdrawAmount);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}