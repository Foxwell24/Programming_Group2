using System;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] numbers = new int[10] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };


            foreach (int i in numbers)
                count += i;

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
