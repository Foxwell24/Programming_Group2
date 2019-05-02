using System;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            Console.WriteLine("Enter 5 names, pressing [ENTER] after each one.");

            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[3] = Console.ReadLine();
            names[4] = Console.ReadLine();

            foreach (string s in names)
                Console.WriteLine("Hello " + s);

            Console.ReadKey();
        }
    }
}
