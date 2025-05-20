using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram.Operations
{
    internal class FindArithmatic
    { public void find()
        {
            int num1, num2, result = 0;
            try
            {
                Console.WriteLine("Enter the 1st number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Operator");
                char op = (char)Console.Read();
                switch (op)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/': result = num1 / num2; break;

                    default: Console.WriteLine("Invalid operator"); break;
                }
                Console.WriteLine(result);
            }
           
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }


           finally
            {
               Console.WriteLine("End of the program"); 
            }
            Console.ReadKey();

        }
    }
}
