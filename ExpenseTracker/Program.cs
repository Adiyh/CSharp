using System;
using ExpenseTracker.Repository;
using ExpenseTracker.Business;
using ExpenseTracker.Utilities;

namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.PrintLine(" Welcome to the Expense Tracker ");

            DataRepository repo = new();
            ExpenseManager manager = new(repo);

            while (true)
            {
                ConsoleHelper.PrintLine("\nMenu:");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. Show Balances");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        manager.AddUser();
                        break;
                    case "2":
                        manager.AddExpense();
                        break;
                    case "3":
                        manager.ShowBalances();
                        break;
                    case "4":
                        return;
                    default:
                        ConsoleHelper.PrintLine("Invalid option. Try again.", ConsoleColor.Red);
                        break;
                }
            }
        }
    }
}
