using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanceapp
{     
    internal class Class2:Class1
    {    
        Class2()
        {
            Console.WriteLine("Class 2 Constructor is called");
        }
        public void test3()
        {
            Console.WriteLine("Third method from class 2");
        }
        static void Main(string[] args)
        {
            Class2 c = new Class2();
           
            c.test1();
            c.test2();
            object obj = new object();
            Console.WriteLine(obj.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(obj);




        }
    }
}
