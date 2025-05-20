using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanceapp
{
     public class Class1
    {   public Class1()
        {
            Console.WriteLine("class1 constructor");
        }
        public void test1()
        {
            Console.WriteLine("Method 1 is called");
        }
        public void test2()
        {
            Console.WriteLine("Method 2 is called");

        }
        static void main(string[] args)
        {
            Class1 cs1 = new Class1();
            cs1.test2();
        }
    }
}
