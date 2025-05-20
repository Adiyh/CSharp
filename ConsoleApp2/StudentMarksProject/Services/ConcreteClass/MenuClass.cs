using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksProject.Services.ConcreteClass
{
    internal class MenuClass

    {
        public void Menu()
        {
            StudentRecordOperations studentRecordOperations = new StudentRecordOperations();
            Console.WriteLine("Welcome to Student Management System");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1. Add Student Details");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Delete students");
            Console.WriteLine("4. Exit");

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter your choice:");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            studentRecordOperations.AddStudent();
                            break;
                        case 2:
                            studentRecordOperations.ShowStudents();
                            break;
                        case 3:studentRecordOperations.DeleteStudents();
                            break;
                            
                        case 4:
                            Console.WriteLine("Exiting...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
