using System;
using System.Collections.Generic;

namespace Lists_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeList = new List<int> {1,2,3,4,5};

            int b = 0;
            while (b==0)
            {
                Console.WriteLine("Gimmi a number");
                int number = int.Parse(Console.ReadLine());

                if (primeList.Contains(number))
                {
                    Console.WriteLine("That number has already been used.");
                    Console.WriteLine();
                }
                else{
                    primeList.Add(number);
                }
            }

            Console.WriteLine("Enter a number");
            Console.ReadLine();
        }
    }
}
