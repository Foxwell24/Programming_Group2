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

                Console.WriteLine("How many numbers? [0->10]");
                int amount = int.Parse(Console.ReadLine());

                Console.WriteLine("Guess the " + amount + " numbers");
                Globals.ForNumbers();

                while (cows < amount)
                {
                    cows = 0;
                    bulls = 0;
                    wrong = 0;
                    buttonsUsingInt.Clear();
                    buttonsUsingKey.Clear();
                    buttonsUsingString.Clear();

                    int pressed = 0;
                    while (pressed < amount)
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
            numbers.Add(i1);

            int i2 = rnd.Next(0, 10);
            while (numbers.Contains(i2))
            {
                i2 = rnd.Next(0, 10);
            }
            numbers.Add(i2);

            int i3 = rnd.Next(0, 10);
            while (numbers.Contains(i3))
            {
                i3 = rnd.Next(0, 10);
            }
            numbers.Add(i3);

            int i4 = rnd.Next(0, 10);
            while (numbers.Contains(i4))
            {
                i4 = rnd.Next(0, 10);
            }
            numbers.Add(i4);

            int i5 = rnd.Next(0, 10);
            while (numbers.Contains(i5))
            {
                i5 = rnd.Next(0, 10);
            }
            numbers.Add(i5);

            int i6 = rnd.Next(0, 10);
            while (numbers.Contains(i6))
            {
                i6 = rnd.Next(0, 10);
            }
            numbers.Add(i6);

            int i7 = rnd.Next(0, 10);
            while (numbers.Contains(i7))
            {
                i7 = rnd.Next(0, 10);
            }
            numbers.Add(i7);

            int i8 = rnd.Next(0, 10);
            while (numbers.Contains(i8))
            {
                i8 = rnd.Next(0, 10);
            }
            numbers.Add(i8);

            int i9 = rnd.Next(0, 10);
            while (numbers.Contains(i9))
            {
                i9 = rnd.Next(0, 10);
            }
            numbers.Add(i9);

            int i10 = rnd.Next(0, 10);
            while (numbers.Contains(i10))
            {
                i10 = rnd.Next(0, 10);
            }
            numbers.Add(i10);

            string s1 = i1.ToString();
            string s2 = i2.ToString();
            string s3 = i3.ToString();
            string s4 = i4.ToString();
            string s5 = i5.ToString();
            string s6 = i6.ToString();
            string s7 = i7.ToString();
            string s8 = i8.ToString();
            string s9 = i9.ToString();
            string s10 = i10.ToString();

            return s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
        }
    }
}
