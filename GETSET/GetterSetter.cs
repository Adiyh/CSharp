using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETSET
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public string course { get; set; }

        public void Display()
        {
            Console.WriteLine("Student Detaiks Are");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"ID:{id}");
            Console.WriteLine($"NAME:{name}");
            Console.WriteLine($"AGE:{age}");
            Console.WriteLine($"COURSE:{course}");

        }
       
        public static void run()
        {
            Student student = new Student();
            Console.WriteLine("Enter the student id");
            student.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student name");
            student.name = Console.ReadLine();

            
            Console.WriteLine("Enter the student age");
            student.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student Course");
            student.course = Console.ReadLine();


            student.Display();

        }

    }

}
