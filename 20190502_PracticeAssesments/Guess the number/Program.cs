using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int rw = 0;
            int rl = 0;
            int rd = 0;
            while (rw <= 2 || rl <= 2 || rd <= 3)
            {

                string[] RPS = { "Rock", "Paper", "Sicors", };

                

                int w = 0;
                int l = 0;
                int d = 0;
                while (w <= 2 || l <= 2 || d <= 3)
                {
                    Console.WriteLine("Rock Paper Sicors!");
                    string input = Console.ReadLine();
                    int numInput = 0;
                    string WLD = "";
                    int rand = new Random().Next(0, RPS.Length);
                    string CPInput = RPS[rand];

                    if (input == "Rock") { numInput = 1; }
                    else if (input == "Paper") { numInput = 2; }
                    else if (input == "Sicors") { numInput = 3; }

                    if (numInput == 1 && CPInput == RPS[1]) { WLD = "l"; }
                    else if (numInput == 1 && CPInput == RPS[2]) { WLD = "w"; }
                    else if (numInput == 2 && CPInput == RPS[0]) { WLD = "w"; }
                    else if (numInput == 2 && CPInput == RPS[2]) { WLD = "l"; }
                    else if (numInput == 3 && CPInput == RPS[0]) { WLD = "l"; }
                    else if (numInput == 3 && CPInput == RPS[1]) { WLD = "w"; }
                    else if (input == CPInput) { WLD = "d"; }

                    if (WLD == "w") { Console.WriteLine("You win"); w++; }
                    else if (WLD == "l") { Console.WriteLine("You loose"); l++; }
                    else if (WLD == "d") { Console.WriteLine("You draw"); d++; }
                }
                if (w == 2) { rw++; }
                else if (l == 2) { rl++; }
                else if (d == 3) { rd++; }                
            }
            if (rw == 2) { Console.WriteLine("You ultimatly win"); }
            else if (rl == 2) { Console.WriteLine("You ultimatly loose"); }
            else if (rd == 3) { Console.WriteLine("You ultimatly draw"); }
            Console.ReadKey();

        }
    }
}
