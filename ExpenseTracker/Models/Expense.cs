using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    internal class Expense
    {
        public string Payer { get; set; }
        public double Amount { get; set; }
        public List<string> Participants { get; set; }
    }
}
