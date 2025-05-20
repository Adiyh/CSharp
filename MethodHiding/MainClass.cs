using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class MainClass
    {


       public class Adarsh

        {
            public void Test()
            {
                Console.WriteLine("djefkh");
            }
           

        }
        public class Adarsh2 : Adarsh
        {
            public new void Test()
            {
                Console.WriteLine("NEW");
            }
            public void ree()
            {
                base.Test();
            }
        }

        public static void Main(string[] args)
        {
            Adarsh2 ad= new Adarsh2();
            ad.Test();
            
        }
    }
}
