using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker.Repository
{
    internal class DataRepository
    {
        public List<User> Users = new();
        public List<Expense> Expenses = new();
        public Dictionary<string, Dictionary<string, double>> Balances = new();
    }
}
