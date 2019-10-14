using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2Lib
{
    public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double side1Length;
        public double side2Length;
        public double side3Length;
        public double side4Length;

        public Quadrilateral(double side1Length, double side2Length) : this(side1Length)
        {
            this.side2Length = side2Length;
        }

        protected Quadrilateral(double side1Length)
        {
            this.side1Length = side1Length;
        }

        protected Quadrilateral()
        {

        }

        public abstract double GetArea();
               
        public abstract double GetPerimeter();
    }
    public class Square : Quadrilateral
    {
        public Square()
        {
        }

        public Square(double side1Length) : base(side1Length)
        {
        }

        public override double GetArea()
        {
            return side1Length * side1Length;
        }

        public override double GetPerimeter()
        {
            return side1Length * 4;
        }
    }
    public class Rectangle : Quadrilateral
    {
        public Rectangle()
        {
        }

        public Rectangle(double side1Length, double side2Length) : base( side1Length, side2Length)
        {
        }

        public override double GetArea()
        {
            return side1Length * side2Length;
        }

        public override double GetPerimeter()
        {
            return (side1Length * 2) + (side2Length * 2);
        }
    }
}
