using System;

namespace Challenge2Lib
{
    public abstract class Shape
    {
        public string color;
        public void Operation1()
        {
            throw new NotImplementedException();
        }
    }
    public interface IShapeCalc
    {
        double GetArea();
        double GetPerimeter();
    }
}
