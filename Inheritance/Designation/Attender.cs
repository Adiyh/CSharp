using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Inheritance.modules;
using System.Xml.Linq;


namespace Inheritance.staffs
    {
        internal class Attender : School
        {
            public static void AttenderData()
            {
                string branch = "Mechanical"; // Branch information
                Console.WriteLine("Attender Details are");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Attender Id :" + _id);
                Console.WriteLine("Attender Name :" + _name);
                Console.WriteLine("Attender Age :" + _age);
                Console.WriteLine("Attender Address :" + _address);
                Console.WriteLine("Attender Phn number:" + _phnnumber);
                Console.WriteLine("Attender Branch :" + branch);
            }
        }
    }

