using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMApp;

namespace Encapsulation
{
    internal class MainClass
    {
        
        
            static void Main(string[] args)
            {
                ATM myATM = new ATM();
            
                try
                {

                    while (true)
                    {
                        Console.WriteLine("\n--- ATM Menu ---");
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Withdraw");
                        Console.WriteLine("4. Exit");
                    Console.WriteLine("5.Addition");

                        Console.Write("Choose an option: ");
                        int choice = Convert.ToInt32(Console.ReadLine());



                        switch (choice)
                        {
                            case 1:
                                myATM.ShowBalance();
                                break;

                            case 2:
                                Console.Write("Enter amount to deposit: ");
                                decimal depositAmount = Convert.ToInt32(Console.ReadLine());
                                myATM.Deposit(depositAmount);
                                break;

                            case 3:
                                Console.Write("Enter amount to withdraw: ₹");
                                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                                myATM.Withdraw(withdrawAmount);
                                break;

                            case 4:
                                Console.WriteLine("Thank you for using our ATM!");
                                return;


                            case 5: int k=  myATM.maths();
                            Console.WriteLine("SUM is " + k);
                            break;
                        default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }


                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    return;

                }
            }
        }
    }


