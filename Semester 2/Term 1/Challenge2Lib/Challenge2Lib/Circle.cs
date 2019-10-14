using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2Lib
{
    public class Circle : IShapeCalc
    {
        public readonly double PI = 3.141592;
        double x = Math.PI;
        public double radius;

        public Circle(double input)
        {
        }

        public Circle()
        {
        }

        public double GetArea()
        {
            double x = PI * (radius * radius);
            return Math.Round(x, 2);
        }

        public double GetPerimeter()
        {
            return 2 * PI * radius;
        }
    }
}
