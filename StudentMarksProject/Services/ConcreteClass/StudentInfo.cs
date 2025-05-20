using System;
using System.Collections.Generic;

namespace StudentMarksProject.Services.ConcreteClass
{
    internal class Student
    {
        public string _Name { get; set; }
        public Dictionary<string, int> _SubjectMarks { get; set; }

        public Student(string name)
        {
            _Name = name;
            _SubjectMarks = new Dictionary<string, int>();
        }
    }

  
}
