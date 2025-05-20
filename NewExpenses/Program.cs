using System;
using System.Collections.Generic;
using System.Linq;

class ExpenseSplitter
{
    class Person
    {
        public string Name;
        public double Paid = 0;
        public double Consumed = 0;

        public double Balance => Paid - Consumed;
    }

    static void Main()
    {
        Console.Write("Enter number of people: ");
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Person> people = new();

        Console.WriteLine("Enter names:");
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            people[name] = new Person { Name = name };
        }

        Console.Write("Enter number of expenses: ");
        int expenseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < expenseCount; i++)
        {
            Console.WriteLine($"\nExpense #{i + 1}:");

            Console.Write("Who paid? ");
            string payer = Console.ReadLine();

            Console.Write("Amount paid: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Number of consumers: ");
            int c = int.Parse(Console.ReadLine());

            List<string> consumers = new();
            for (int j = 0; j < c; j++)
            {
                Console.Write("Enter consumer name: ");
                consumers.Add(Console.ReadLine());
            }

            double share = amount / c;

            // Update payer
            people[payer].Paid += amount;

            // Update consumers
            foreach (var person in consumers)
                people[person].Consumed += share;
        }

        Console.WriteLine("\n--- Final Balances ---");
        foreach (var person in people.Values)
            Console.WriteLine($"{person.Name} -> Paid: {person.Paid}, Consumed: {person.Consumed}, Balance: {person.Balance}");

        Console.WriteLine("\n--- Settlements ---");
        SettleDebts(people.Values.ToList());
    }

    static void SettleDebts(List<Person> persons)
    {
        var creditors = persons.Where(p => p.Balance > 0).OrderByDescending(p => p.Balance).ToList();
        var debtors = persons.Where(p => p.Balance < 0).OrderBy(p => p.Balance).ToList();

        foreach (var debtor in debtors)
        {
            double debt = -debtor.Balance;
            foreach (var creditor in creditors)
            {
                if (debt == 0) break;
                if (creditor.Balance == 0) continue;

                double transfer = Math.Min(debt, creditor.Balance);
                Console.WriteLine($"{debtor.Name} pays {transfer:F2} to {creditor.Name}");

                debtor.Paid += transfer;
                creditor.Paid -= transfer;

                debt -= transfer;
            }
        }
    }
}
