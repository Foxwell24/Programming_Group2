using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Student : Person
    {
        public string Course;

        public Student(string fName, string sName, int yearOfBirth, string course) : base(fName, sName, yearOfBirth)
        {
            Course = course;
        }

        public override string GetInfo()
        {
            return $"{SName}, {FName}. {YearOfBirth}: {Course}";
        }
    }
}
