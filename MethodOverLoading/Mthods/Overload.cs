using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading.Mthods
{
    internal class Overload
    {
       
        public static void Add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(int num1, int num2,int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }
        public static void Add(int num1, double num3)
        {
            Console.WriteLine(num1 + num3);
        }
        public static void Add(int num1)
        {
            Console.WriteLine(num1*num1);
        }

    }
}
