using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.modules
{
    internal class School
    {
        public static int _id, _age;
        public static string _name, _address, _phnnumber;
        public static void Menu()
        {
            Console.WriteLine("Select your Type");
            Console.WriteLine("1.Student" + "  " + "2.Teacher" + "  " + "3.Stff");
            try
            {
                int type = int.Parse(Console.ReadLine());

          
            _id = 1;
            _age = 18;
            _name = "Adarsh";
            _address = "Hassan";
            _phnnumber = "9483660642";


            
                switch (type)
                {
                    case 1:
                        Inheritance.staffs.Student.StudentData();

                        break;
                    case 2:
                        Inheritance.staffs.Teacher.TeacherData();
                        break;
                    case 3:
                        Inheritance.staffs.Attender.AttenderData();
                        break;

                }
            }
            catch (FormatException ex) 
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

}

   
