using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Inheritance.modules;

namespace Inheritance.staffs
{
    internal class Teacher : School
    {
        public static void TeacherData()
        {
            int experience = 100;
            string subject= "Hindi";
            
            Console.WriteLine("Teacher Details are");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Teacher Id :" + _id);
            Console.WriteLine("Teacher Name :" + _name);
            Console.WriteLine("Teacher Age :" + _age);
            Console.WriteLine("Teacher Address :" + _address);
            Console.WriteLine("Teacher Phn number:" + _phnnumber);
            Console.WriteLine("Teacher Experience :" + experience);
            Console.WriteLine("Teacher Subject :" + subject);
          
        }
    }
}
