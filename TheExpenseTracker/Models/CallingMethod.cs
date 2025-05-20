using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpenseTracker.Models
{
   public class CallingMethod
    {
        
        public Dictionary<string, Dictionary<string, double>> Balances = new Dictionary<string, Dictionary<string, double>>();
        public void ShowBalances()
        {
            Console.WriteLine("Current Balances:");
            bool hasBalance = false;

            foreach (var fromUser in Balances)
            {
                foreach (var toUser in fromUser.Value)
                {
                    if (toUser.Value > 0)
                    {
                        Console.WriteLine(fromUser.Key + " owes " + toUser.Key + ": ₹" + toUser.Value);
                        hasBalance = true;
                    }
                }
            }

            if (!hasBalance)
            {
                Console.WriteLine("All balances are settled.");
            }
        }
    }
}
