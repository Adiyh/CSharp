using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CalculatorProgram.Operations;

namespace CalculatorProgram.models
{
    internal class Menu
    {
        public static int choice;

        public static void Menu1()
        {
            try
            {
                Console.WriteLine("Choose the operation you want to perform");
                Console.WriteLine("1.Arithmatic Operations");
                Console.WriteLine("2.Simple interst");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FindArithmatic findarith = new FindArithmatic();
                        findarith.find();
                        break;
                    case 2:
                        FindInterst findint = new FindInterst();
                        findint.findinterst();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;

                }
            }catch (FormatException ex)
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
}
