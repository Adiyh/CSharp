using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ExpenseManager manager = new ExpenseManager();

        try
        {
            while (true)
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. Show Balances");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.Write("Enter user name: ");
                        string name = Console.ReadLine();
                        manager.AddUser(name);
                        break;


                    case 2:
                        Console.Write("Enter payer name: ");
                        string payer = Console.ReadLine();

                        Console.Write("Enter amount: ");
                        double amount = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter number of participants: ");
                        int count = Convert.ToInt32(Console.ReadLine());

                        List<string> participants = new List<string>();
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Enter participant name: ");
                            string part = Console.ReadLine();
                            participants.Add(part);
                        }

                        manager.AddExpense(payer, amount, participants);
                        break;

                    case 3:
                        manager.ShowBalances();
                        break;
                    case 4:
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
