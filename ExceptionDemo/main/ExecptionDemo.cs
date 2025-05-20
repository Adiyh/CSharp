using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo.main
{
    internal class ExecptionDemo
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0; // Initialize variables to avoid CS0165  
            try
            {
                Console.WriteLine("Enter 1st number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine(result);
                if (num2 >= 5)
                    return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter 2nd number");
                num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine(result);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("Enter 2nd number");
                num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("End of the program");
        }
    }
}
