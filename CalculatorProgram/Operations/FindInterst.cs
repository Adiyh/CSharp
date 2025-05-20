using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram.Operations
{
    internal class FindInterst
    {
        public void findinterst()
        {
            try
            {
                Console.WriteLine("Enter Principal Amount: ");
                double principal = double.Parse((Console.ReadLine()));

                Console.WriteLine("Enter Rate of Interest: ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Time (in years): ");
                double time = Convert.ToDouble(Console.ReadLine());
                double simpleInterest = (principal * rate * time) / 100;
                Console.WriteLine("Simple Interest = " + simpleInterest);
            }
            catch (FormatException ex)
            {

               Console.WriteLine( ex.Message);
            }

            


           
        }
    }
}
