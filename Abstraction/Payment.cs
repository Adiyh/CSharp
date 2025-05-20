using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Payment
    {
        public abstract void Pay(double amount);

        public void Recipt()
        {
            Console.WriteLine("Recipt generated");
        }
        public static void Run()
        {
            Console.WriteLine("Enter amount to pay:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose payment method:");
            Console.WriteLine("1. UPI");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Cash");
            Console.Write("Enter your choice (1/2/3): ");
            string choice = Console.ReadLine();
            Payment payment = null;
            switch (choice)
            {
                case "1":
                    payment = new UPI();
                    break;
                case "2":
                    payment = new CREDIT();
                    break;
                case "3":
                    payment = new Cash();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }
            payment.Pay(amount);
            payment.Recipt();
        }

    }
    public class UPI : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"{amount} payment done using UPI");
        }
    }
    public class CREDIT : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"{amount} payment done using CREDIT CARD");
        }
    }
    public class Cash : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"{amount} payment done using CASH");
        }
    }
}


