using System.Collections.Generic;

public class Expense
{
    public string Payer { get; set; }
    public double Amount { get; set; }
    public List<string> Participants { get; set; }

    public Expense(string payer, double amount, List<string> participants)
    {
        Payer = payer;
        Amount = amount;
        Participants = participants;
    }

    public void AddExpense(string payer, double amount, List<string> participants)
    {
        if (!Balances.ContainsKey(payer))
        {
            Console.WriteLine("Payer not found.");
            return;
        }

        double share = amount / participants.Count;

        foreach (string participant in participants)
        {
            if (participant != payer)
            {
                Balances[participant][payer] += share;
                Balances[payer][participant] -= share;
            }
        }

        Expenses.Add(new Expense(payer, amount, participants));
        Console.WriteLine("Expense recorded successfully.");
    }
}