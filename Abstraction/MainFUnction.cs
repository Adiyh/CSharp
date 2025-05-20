using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class MainFUnction
    {
        enum Status
        {
            None = 0,
            Started = 1,
            InProgress = 1,
            Completed = 2
        }
        

        public static void Main(string[] args)
        {

            //Payment.Run();
            Status status= Status.Started;
            Console.WriteLine(status);
            
            //Console.WriteLine((Status)1);


        }

    }
}
