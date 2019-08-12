using System;

namespace Classes
{
    public abstract class Person
    {
        public string FName;
        public string SName;
        public int YearOfBirth;

        protected Person(string fName, string sName, int yearOfBirth)
        {
            FName = fName;
            SName = sName;
            YearOfBirth = yearOfBirth;
        }

        public abstract string GetInfo();
        // Returns string "Sname, Fname. YearOfBirth" etc.

        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }
    }
}
