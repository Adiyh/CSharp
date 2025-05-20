using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Inheritance.modules;

namespace Inheritance.staffs
{
    internal class Student : School
    {
        public static void StudentData()
        {
            int marks1 = 100;
            int marks2 = 80;
            float avg = (marks1 + marks2) / 2.0f; // Ensure division is done in floating-point
            Console.WriteLine("Student Details are");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Student Id :" + _id);
            Console.WriteLine("Student Name :" + _name);
            Console.WriteLine("Student Age :" + _age);
            Console.WriteLine("Student Address :" + _address);
            Console.WriteLine("Student Phn number:" + _phnnumber);
            Console.WriteLine("Student Marks 1 :" + marks1);
            Console.WriteLine("Student Marks 2 :" + marks2);
            Console.WriteLine("Student Average :" + avg);
        }
    }
}
