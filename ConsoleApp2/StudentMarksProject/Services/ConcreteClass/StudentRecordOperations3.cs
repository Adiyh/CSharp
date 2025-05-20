using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksProject.Services.ConcreteClass
{
    internal partial class StudentRecordOperations
    {
        public void ShowStudents()
        {
            try
            {
                Console.WriteLine("The Students details are:");
                foreach (var student in _students)
                {
                    Console.WriteLine($"Student Name: {student._Name}");
                    foreach (var subjectMark in student._SubjectMarks)
                    {
                        Console.WriteLine($"  Subject: {subjectMark.Key}, Marks: {subjectMark.Value}");
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
