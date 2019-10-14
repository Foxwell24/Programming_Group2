using NUnit.Framework;
using Challenge2Lib;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        Circle circle;
        Square square;
        Rectangle rectangle;
        Equilateral equilateral;
        RightAngle rightAngle;

        [SetUp]
        public void Setup()
        {
            circle = new Circle();
            square = new Square();
            rectangle = new Rectangle();
            equilateral = new Equilateral();
            rightAngle = new RightAngle();
        }

        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void SquareTest(double side1, double area, double perimeter)
        {
            square.side1Length = side1;
            Assert.AreEqual(area, square.GetArea());
            Assert.AreEqual(perimeter, square.GetPerimeter());
        }
        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void RectangleTest(double side1, double side2, double area, double perimeter)
        {
            rectangle.side1Length = side1;
            rectangle.side2Length = side2;
            Assert.AreEqual(area, rectangle.GetArea());
            Assert.AreEqual(perimeter, rectangle.GetPerimeter());
        }
        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void EquilateralTest(double side1, double area, double perimeter)
        {
            equilateral.side1Length = side1;
            Assert.AreEqual(area, equilateral.GetArea());
            Assert.AreEqual(perimeter, equilateral.GetPerimeter());
        }
        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void RightAngleTest(double side1, double side2, double area, double perimeter)
        {
            rightAngle.side1Length = side1;
            rightAngle.side2Length = side2;
            Assert.AreEqual(area, rightAngle.GetArea());
            Assert.AreEqual(perimeter, rightAngle.GetPerimeter());
        }
        [TestCase(5, 78.550, 31.42)]
        [TestCase(15, 706.95, 94.26)]
        [TestCase(7, 153.96, 43.99)]
        public void CircleTest(double side1, double area, double perimeter)
        {
            circle.radius = side1;
            Assert.AreEqual((decimal)area, (decimal)circle.GetArea());
            Assert.AreEqual((decimal)perimeter, (decimal)circle.GetPerimeter());
 
        }
    }
}