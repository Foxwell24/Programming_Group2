using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2Lib
{
    public abstract class Triangle : Shape
    {
        public double side1Length;
        public double side2Length;
        public double side3Length;

        public Triangle(double side1Length, double side2Length) : this(side1Length)
        {
            this.side2Length = side2Length;
        }

        protected Triangle(double side1Length)
        {
            this.side1Length = side1Length;
        }

        protected Triangle()
        {

        }
    }
    public class Equilateral : Triangle, IShapeCalc
    {
        public Equilateral()
        {
        }

        public Equilateral(double side1Length) : base(side1Length)
        {
        }

        public double GetArea()
        {
            double x = Math.Sqrt(3) / 4 * side1Length * side1Length;
            return Math.Round(x, 2, MidpointRounding.AwayFromZero);
        }

        public double GetPerimeter()
        {
            return side1Length * 3;
        }
    }
    public class RightAngle : Triangle, IShapeCalc
    {
        public RightAngle()
        {
        }

        public RightAngle( double side1Length, double side2Length) : base(side1Length, side2Length)
        {
        }

        public double GetArea()
        {
            double x = (0.5 * (side1Length * side2Length));           
            return Math.Round(x, 2);
        }

        public double GetPerimeter()
        {
            SetHypotenuse();
            double x = (side1Length + side2Length + side3Length);
            return Math.Round(x, 2);
        }

        public void SetHypotenuse()
        {
            side3Length = Math.Sqrt(Math.Pow(side1Length, 2) + Math.Pow(side2Length, 2));
        }
    }
}
