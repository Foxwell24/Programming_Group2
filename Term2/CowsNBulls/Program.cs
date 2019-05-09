using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsNBulls
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int counter = 0;
            List<ConsoleKeyInfo> buttonsUsingKey = new List<ConsoleKeyInfo>();
            List<string> buttonsUsingString = new List<string>();
            List<int> buttonsUsingInt = new List<int>();
            
            while (0 == 0)
            {
                int cows = 0;
                int bulls = 0;
                int wrong = 0;

                Console.WriteLine("Guess the 4 numbers");
                Globals.ForNumbers();

                while (cows < 4)
                {
                    cows = 0;
                    bulls = 0;
                    wrong = 0;
                    buttonsUsingInt.Clear();
                    buttonsUsingKey.Clear();
                    buttonsUsingString.Clear();

                    int pressed = 0;
                    while (pressed < 4)
                    {
                        var v = Console.ReadKey();
                        buttonsUsingKey.Add(v);
                        string s = v.KeyChar.ToString();
                        //Console.WriteLine(s);
                        buttonsUsingString.Add(s);
                        buttonsUsingInt.Add(int.Parse(buttonsUsingString[pressed]));
                        if (buttonsUsingInt[pressed] == Globals.numbers[pressed])
                        {
                            cows++;
                        }
                        else if (Globals.numbers.Contains(buttonsUsingInt[pressed]))
                        {
                            bulls++;
                        }
                        else
                        {
                            wrong++;
                        }
                        pressed++;
                    }
                    counter++;
                    Console.WriteLine("");
                    Console.WriteLine("Cows: {0}", cows);
                    Console.WriteLine("Bulls: {0}", bulls);
                    Console.WriteLine("Wrong: {0}", wrong);
                }
                Console.WriteLine();
                Console.WriteLine("Took " + counter + " guesses");
            }
        }
    }

    static class Globals
    {
        public static Random rnd = new Random();
        public static List<int> numbers = new List<int>();


        public static string ForNumbers()
        {
            numbers.Clear();

            int i1 = rnd.Next(0, 10);

            int i2 = rnd.Next(0, 10);
            while(i2 == i1)
            {
                i2 = rnd.Next(0, 10);
            }

            int i3 = rnd.Next(0, 10);
            while (i3 == i1 || i3 == i2)
            {
                i3 = rnd.Next(0, 10);
            }

            int i4 = rnd.Next(0, 10);
            while (i4 == i1 || i4 == i2 || i4 ==i3)
            {
                i4 = rnd.Next(0, 10);
            }

            numbers.Add(i1);
            numbers.Add(i2);
            numbers.Add(i3);
            numbers.Add(i4);
            string s1 = i1.ToString();
            string s2 = i2.ToString();
            string s3 = i3.ToString();
            string s4 = i4.ToString();

            return s1 + s2 + s3 + s4;
        }
    }
}
