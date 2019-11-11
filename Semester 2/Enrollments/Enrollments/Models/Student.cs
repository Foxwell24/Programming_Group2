using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enrollments.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SirName { get; set; }
        public List<Subject> Subjects;

        public Student()
        {
        }
        public Student(int iD, string firstName, string sirName)
        {
            ID = iD;
            FirstName = firstName;
            SirName = sirName;
            Subjects = new List<Subject>();
        }
    }
}
