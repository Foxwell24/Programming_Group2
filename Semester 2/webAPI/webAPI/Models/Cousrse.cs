using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class Cousrse
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        public Cousrse(int courseID, string courseName)
        {
            CourseID = courseID;
            CourseName = courseName;
        }
    }
}
