using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class Program
    {
        static List<Beehive> Beehives = new List<Beehive>();
        static void Main(string[] args)
        {
            
            while (0 == 0)
            {
                Console.Clear();
                Console.WriteLine("Make a Beehive: 1");
                Console.WriteLine("Make a Bee    : 2");
                string i = Console.ReadLine();
                if (i=="1")
                {
                    Console.Clear();
                    Beehive b = MakeHive();                    
                    Beehives.Add(b);
                }
                else if (i == "2" && Beehives.Count >= 1)
                {
                    Console.Clear();
                    Bee b = MakeBee();                    
                }
                else if (i == "2" && Beehives.Count < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Bees cannot be made without a Hive to go into");
                    Console.WriteLine("Pleese make a hive.");
                }
                else
                {
                    Console.WriteLine("Sorry, i do not know that command");
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                
            }
        }

        public static Bee MakeBee()
        {
            Console.Clear();
            Console.WriteLine("Bee name");
            string n = Console.ReadLine();

            Console.WriteLine("Bee size");
            float s = float.Parse(Console.ReadLine());

            string hives = "";
            foreach (Beehive i in Beehives)
            {
                hives += "[" + Beehives[0] + "] ";
            }

            Console.WriteLine("What Hive do you want to put ["+n+"] into?");
            Console.WriteLine("");
            Console.WriteLine(hives);
            string h = Console.ReadLine();
            
                
            Bee b = new Bee(n, s, h);

            
            return b;
            
        }

        public static Beehive MakeHive()
        {
            Console.Clear();
            Console.WriteLine("Hive name");
            string n = Console.ReadLine();
            Beehive bh = new Beehive(n);
            return bh;
        }
    }

    public class Bee
    {
        public string Name;
        public float Size;
        public string Hive;
        public Bee(string name, float size, string hive)
        {
            Name = name;
            Size = size;
            Hive = hive;
        }
    }

    public class Beehive
    {
        public string HiveName;
        public List<Bee> Bees;
        public Beehive(string hiveName)
        {
            HiveName = hiveName;
            Bees = new List<Bee>();
        }
        public void AddBee(Bee b)
        {
            Bees.Add(b);
        }
    }
}

