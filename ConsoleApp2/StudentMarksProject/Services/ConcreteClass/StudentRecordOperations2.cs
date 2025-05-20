using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksProject.Services.ConcreteClass
{
    internal partial class StudentRecordOperations

    {
        public void DeleteStudents()
        {
            try
            {
                Console.WriteLine("Enter the name of the student to delete:");
                string nameToDelete = Console.ReadLine();

                var studentToDelete = _students.FirstOrDefault(s => s._Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

                if (studentToDelete != null)
                {
                    _students.Remove(studentToDelete);
                    Console.WriteLine($"Student '{nameToDelete}' has been deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Student '{nameToDelete}' not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
