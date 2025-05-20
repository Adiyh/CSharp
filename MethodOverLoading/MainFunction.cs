using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOverLoading.Mthods;

namespace MethodOverLoading
{
    internal class MainFunction
    {
        public static void Main(string[] args)
        {
            Overload.Add(12,45);
            Overload.Add(12, 45, 34);
            Overload.Add(12, 45.7);
            Overload.Add(12);

        }
        
    }
}
