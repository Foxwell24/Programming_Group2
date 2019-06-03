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
            float s = 0f;
            try
            {
                s = float.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error, not a number");
                Console.ReadKey();
                return MakeBee();
            }
            string hives = "";
            foreach (Beehive i in Beehives)
            {
                hives += "[" + i.getHiveName() + "] ";
            }
            Console.WriteLine("What Hive do you want to put ["+n+"] into?");
            Console.WriteLine("");
            Console.WriteLine(hives);
            string h = Console.ReadLine();
            Beehive hive = getHive(h);
            if(hive == null)
            {
                Console.WriteLine("Hive does not exist");
                Console.ReadKey();
                return MakeBee();
            }
            Bee b = new Bee(n, s, h);
            hive.AddBee(b);
            return b;
        }
        public static Beehive MakeHive()
        {
            Console.Clear();
            Console.WriteLine("Hive name");
            string n = Console.ReadLine();
            Beehive bh = new Beehive(n);
            Program.AddBeehive(bh);
            return bh;
        }
        public static Beehive getHive(string name)
        {
            foreach(Beehive beehive in Beehives)
            {
                if (beehive.getHiveName().Equals(name))
                {
                    return beehive;
                }
            }
            return null;
        }
        public static void AddBeehive(Beehive b)
        {
            Beehives.Add(b);
        }
    }

    public class Bee
    {
        private string name;
        private float size;
        private string hive;
        public Bee(string name, float size, string hive)
        {
            this.name = name;
            this.size = size;
            this.hive = hive;
        }
        public float getBeeSize()
        {
            return size;
        }
    }
    public class QueenBee : Bee {
        public QueenBee(string name, float size, string hive) : base(name, size, hive)
        {
            
        }        
    }

    public class Beehive
    {
        private string hiveName;
        private List<Bee> Bees;
        public Beehive(string hiveName)
        {
            this.hiveName = hiveName;
            Bees = new List<Bee>();
            AddBee(new QueenBee("bob", 2.2f, hiveName));
        }
        public void AddBee(Bee b)
        {
            Bees.Add(b);
        }
        public string getHiveName()
        {
            return hiveName;
        }
        public float CollectHoney(float days)
        {
            float honey = 0f;
            foreach (Bee i in Bees)
            {
                float beesize = Bees[i.getBeeSize()];
                honey = days * beesize * 0.2f;
            }
            return honey;
        }
    }
}

