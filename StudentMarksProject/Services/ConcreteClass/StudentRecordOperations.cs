using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksProject.Services.ConcreteClass
{
    internal partial class StudentRecordOperations
    {
        private List<Student> _students = new List<Student>();

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter the number of students:");
                int noOfStudents = int.Parse(Console.ReadLine());

                for (int i = 0; i < noOfStudents; i++)
                {
                    Console.WriteLine($"Enter the name of student {i + 1}:");
                    string name = Console.ReadLine();
                    Student student = new Student(name);

                    Console.WriteLine($"Enter the number of subjects for {name}:");
                    int noOfSubjects = int.Parse(Console.ReadLine());

                    for (int j = 0; j < noOfSubjects; j++)
                    {
                        Console.WriteLine($"Enter subject {j + 1} name:");
                        string subject = Console.ReadLine();
                        Console.WriteLine($"Enter marks for {subject}:");
                        int marks = int.Parse(Console.ReadLine());
                        student._SubjectMarks[subject] = marks;
                    }

                    _students.Add(student);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

      
   
    }
}
