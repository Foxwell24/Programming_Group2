using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Staff : Person
    {
        public int Id;
        public Staff(string fName, string sName, int yearOfBirth, int id) : base(fName, sName, yearOfBirth)
        {
            Id = id;
        }
        public override string GetInfo()
        {
            return $"{SName}, {FName}. {YearOfBirth}: {Id}";
        }
    }
}
