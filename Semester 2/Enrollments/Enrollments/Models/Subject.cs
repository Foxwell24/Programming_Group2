using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enrollments.Models
{
    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Subject()
        {
        }

        public Subject(int code, string name, string description)
        {
            Code = code;
            Name = name;
            Description = description;
        }
    }
}
