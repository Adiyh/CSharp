using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceapp
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            InterfaceClass intt = new InterfaceClass();
            intt.Add(10,20);
            intt.Sub(10,20);
            intt.area(10, 20);
        }
    }
    public interface Interface1
    {
        void Add(int a, int b);
        void area(int l, int b);
    }
    public interface Interface2
    {
        void Sub(int a, int b);
    }
   
    public class InterfaceClass : Interface1, Interface2
    {
         public void Add(int a, int b) {
            Console.WriteLine(a + b);
        }
        public void area(int l,int b)
        {
            Console.WriteLine(l * b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);

        }
    }
}
