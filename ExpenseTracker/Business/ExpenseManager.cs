using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;
using ExpenseTracker.Repository;
using ExpenseTracker.Utilities;

namespace ExpenseTracker.Business
{
    internal class ExpenseManager
    {
        private readonly DataRepository _repo;

        public ExpenseManager(DataRepository repo)
        {
            _repo = repo;
        }

        public void AddUser()
        {
            ConsoleHelper.PrintLine("Enter user name:", ConsoleColor.Yellow);
            string name = Console.ReadLine();

            if (_repo.Users.Any(u => u.Name == name))
            {
                ConsoleHelper.PrintLine("User already exists!", ConsoleColor.Red);
                return;
            }

            _repo.Users.Add(new User { Name = name });
            _repo.Balances[name] = new Dictionary<string, double>();

            foreach (var user in _repo.Users)
            {
                if (user.Name != name)
                {
                    _repo.Balances[user.Name][name] = 0;
                    _repo.Balances[name][user.Name] = 0;
                }
            }

            ConsoleHelper.PrintLine($"User '{name}' added.");
        }

        public void AddExpense()
        {
            ConsoleHelper.PrintLine("Enter payer name:", ConsoleColor.Yellow);
            string payer = Console.ReadLine();

            if (!_repo.Users.Any(u => u.Name == payer))
            {
                ConsoleHelper.PrintLine("Payer not found.", ConsoleColor.Red);
                return;
            }

            ConsoleHelper.PrintLine("Enter total amount:");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                ConsoleHelper.PrintLine("Invalid amount.", ConsoleColor.Red);
                return;
            }

            ConsoleHelper.PrintLine("Enter number of people sharing the expense:");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                ConsoleHelper.PrintLine("Invalid number.", ConsoleColor.Red);
                return;
            }

            List<string> participants = new();
            for (int i = 0; i < num; i++)
            {
                ConsoleHelper.PrintLine($"Enter name of participant #{i + 1}:");
                string name = Console.ReadLine();
                if (!_repo.Users.Any(u => u.Name == name))
                {
                    ConsoleHelper.PrintLine("User not found.", ConsoleColor.Red);
                    return;
                }
                participants.Add(name);
            }

            double share = amount / participants.Count;

            foreach (var participant in participants)
            {
                if (participant != payer)
                {
                    _repo.Balances[participant][payer] += share;
                    _repo.Balances[payer][participant] -= share;
                }
            }

            _repo.Expenses.Add(new Expense
            {
                Payer = payer,
                Amount = amount,
                Participants = participants
            });

            ConsoleHelper.PrintLine("Expense recorded and split successfully.");
        }

        public void ShowBalances()
        {
            ConsoleHelper.PrintLine("\n Current Balances:");
            foreach (var fromUser in _repo.Balances.Keys)
            {
                foreach (var toUser in _repo.Balances[fromUser].Keys)
                {
                    double amount = _repo.Balances[fromUser][toUser];
                    if (amount > 0)
                        Console.WriteLine($"{fromUser} owes {toUser}: ₹{amount:F2}");
                }
            }
        }
    }
}
