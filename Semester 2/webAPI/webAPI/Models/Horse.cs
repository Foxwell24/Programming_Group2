using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class Horse
    {
        public string name;
        public string color;

        public Horse(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
