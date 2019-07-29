using System;
using System.Collections.Generic;

namespace FutureTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                Console.WriteLine("[R]ectange or [S]quare");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                if (input.Key == ConsoleKey.R)
                    MakeRectange(1, 2);
                if (input.Key == ConsoleKey.S)
                    MakeSquare(1, 1);
                else
                    Console.WriteLine("Thats not an option");
            }
        }

        private static Square MakeSquare(int side1, int side2)
        {
            Square square = new Square();
            square.SetLengths(side1, side2);
            return square;
        }

        public static Rectangle MakeRectange(int side1, int side2)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetLengths(side1, side2);

            return rectangle;
        }
    }
}
