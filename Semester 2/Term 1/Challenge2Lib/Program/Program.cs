using System;
using System.Collections.Generic;
using Challenge2Lib;

namespace Program
{
    class Program
    {
        public static bool cont = true;
        static void Main(string[] args)
        {
            
            while (cont)
            {
                int input = 0;
                Console.WriteLine("[3]Quaderlateral, [2]Trianle, or [1]Circle : [0]STOP PROGRAM");
                while (!int.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("Not an option");
                if (input == 3)
                    quaderlateral();
                if (input == 2)
                    triangle();
                if (input == 1)
                    circle();
                if (input == 0)
                    cont = false;


                Console.ReadKey();
            }
        }

        public static void quaderlateral()
        {
            int input = 0;
            Console.Clear();
            Console.WriteLine("[1]Square, or [2]Rectangle : [0]STOP PROGRAM");
            while (!int.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Not an option");
            if (input == 1)
                square();
            if (input == 2)
                rectangle();
            if (input == 0)
                cont = false;
        }
        public static void triangle()
        {
            int input = 0;
            Console.Clear();
            Console.WriteLine("[2]Equilateral, or [1]RightAngle : [0]STOP PROGRAM");
            while (!int.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Not an option");
            if (input == 1)
                equlateral();
            if (input == 2)
                rightangle();
            if (input == 0)
                cont = false;
        }
        public static void circle()
        {
            double input = 0;
            Console.Clear();
            Console.WriteLine("Enter Radius");
            while (!double.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Not a Number");
            Circle circle = new Circle(input);
            Console.WriteLine("Done");
        }
        public static void square()
        {
            double input = 0;
            Console.Clear();
            Console.WriteLine("Enter Side Length");
            while (!double.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Not a Number");
            Square square = new Square(input);
            Console.WriteLine("Done " + square.GetArea());
        }
        public static void rectangle()
        {
            double input1 = 0;
            double input2 = 0;
            Console.Clear();
            Console.WriteLine("Enter Side 1 Length");
            while (!double.TryParse(Console.ReadLine(), out input1))
                Console.WriteLine("Not a Number");
            Console.Clear();
            Console.WriteLine("Enter Side 2 Length");
            while (!double.TryParse(Console.ReadLine(), out input2))
                Console.WriteLine("Not a Number");
            Rectangle square = new Rectangle(input1, input2);
            Console.WriteLine("Done");
        }
        public static void equlateral()
        {
            double input = 0;
            Console.Clear();
            Console.WriteLine("Enter Side Length");
            while (!double.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Not a Number");
            Equilateral square = new Equilateral(input);
            Console.WriteLine("Done");
        }
        public static void rightangle()
        {
            double input1 = 0;
            double input2 = 0;
            Console.Clear();
            Console.WriteLine("Enter Side 1 Length");
            while (!double.TryParse(Console.ReadLine(), out input1))
                Console.WriteLine("Not a Number");
            Console.Clear();
            Console.WriteLine("Enter Side 2 Length");
            while (!double.TryParse(Console.ReadLine(), out input2))
                Console.WriteLine("Not a Number");
            RightAngle square = new RightAngle(input1, input2);
            Console.WriteLine("Done");
        }
    }
}
