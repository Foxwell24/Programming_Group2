using System;
using System.Collections.Generic;
using System.Text;

namespace FutureTask
{
    abstract class Quadralaterals : Shape
    {
        public int side1Length;
        public int side2Length;
        public int side3Length;
        public int side4Length;

        public int GetPerimeter()
        {
            return side1Length + side2Length + side3Length + side4Length;
        }
        public void SetLengths(int s1, int s2)
        {
            side1Length = s1;
            side2Length = s2;
        }
    }

    class Rectangle : Quadralaterals
    {
        public int GetArea()
        {
            return side1Length*side2Length;
        }
    }

    class Square : Quadralaterals
    {
        public int GetArea()
        {
            return side1Length*side1Length;
        }
    }
}
