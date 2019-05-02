using System;
using System.Collections.Generic;

namespace Lists_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTimes = 0;
            List<int> primeList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> countList = new List<int> { 1, 2, 3, 4, 5 };

            int b = 0;
            while (b == 0)
            {
                Console.WriteLine("Gimmi a number");
                int number = int.Parse(Console.ReadLine());

                if (primeList.Contains(number))
                {
                    Console.WriteLine();
                    countList.Add(number);
                    numTimes = 0;
                    foreach (int items in countList)
                    {
                        if(items == number)
                        {
                            numTimes++;
                        }
                    }
                    numTimes -= 1;
                    Console.WriteLine(number + " you tried to add " + numTimes + " Times to many.");
                }
                else
                {
                    primeList.Add(number);
                    countList.Add(number);
                }
            }

            Console.ReadLine();
        }
    }
}
