using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class Program
    {
        public static double startTime = (DateTime.Now - DateTime.MinValue).TotalSeconds;
        public static List<Beehive> Beehives = new List<Beehive>();
        static void Main(string[] args)
        {
            float honey = 0;
            while (0 == 0)
            {                
                Console.Clear();
                Console.WriteLine("Make a Beehive : 1");
                Console.WriteLine("Make a Bee     : 2");
                Console.WriteLine("Collect Honey  : 3");


                Console.WriteLine("Honey collected: " + honey);
                Console.WriteLine("Days passed " + GetTime());
                string initialInput = Console.ReadLine();
                if (initialInput=="1")
                {
                    Console.Clear();
                    Beehive b = MakeHive();                    
                }
                else if (initialInput == "2" && Beehives.Count >= 1)
                {
                    Console.Clear();
                    Bee b = MakeBee();                    
                }
                else if (initialInput == "2" && Beehives.Count < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Bees cannot be made without a Hive to go into");
                    Console.WriteLine("Pleese make a hive.");
                }
                else if (initialInput == "3" && Beehives.Count >= 1)
                {
                    Console.Clear();
                    string hives = "";
                    foreach (Beehive beehive in Beehives)
                    {
                        hives += "[" + beehive.getHiveName() + "] ";
                    }
                    Console.WriteLine(hives);
                    string h = Console.ReadLine();
                    honey += getHiveHoney(h);
                }
                else
                {
                    Console.WriteLine("Sorry, i do not know that command \n Or you do not have a Hive");
                }

                


                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        public static float GetTime()
        {
            double nowTime = (DateTime.Now - DateTime.MinValue).TotalSeconds;
            double diffTime = nowTime - startTime;
            diffTime /= 10;
            int timeInt = Convert.ToInt32(diffTime);
            float time = timeInt;

            return time;
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
            Bee b = new Bee(n, s, false);
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
        public static float getHiveHoney(string name)
        {
            foreach (Beehive beehive in Beehives)
            {
                if (beehive.getHiveName().Equals(name))
                {
                    float honey = beehive.CollectHoney(GetTime());
                    return honey;
                }
            }
            return 0;
        }
        public static void AddBeehive(Beehive b)
        {
            Beehives.Add(b);
        }
        public static bool CanBirth(float floatStr)
        {
            string str = floatStr.ToString();
            // Compute sum of digits 
            int n = str.Length;
            int digitSum = 0;

            for (int i = 0; i < n; i++)
                digitSum += (str[i] - '0');

            // Check if sum of digits is  
            // divisible by 3. 
            return (digitSum % 3 == 0);
        }
    }

    public class Bee
    {
        private string name;
        private float size;        
        private bool isQueen;
        public Bee(string name, float size, bool isQueen)
        {
            this.name = name;
            this.size = size;            
            this.isQueen = isQueen;
        }
        public float getBeeSize()
        {
            return size;
        }
        public bool IsQueen()
        {
            return isQueen;
        }
        public void BreedQueen()
        {
            Bee b = new Bee("Worker", 0.1f, false);
        }
    }    
    public class QueenBee : Bee {
        public QueenBee(string name, float size, bool isQueen) : base(name, size, isQueen)
        {
            size = 0;            
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
            AddBee(new QueenBee("Queen of "+ hiveName, 2.2f, true));
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
            foreach (Bee bee in Bees)
            {
                float beesize = bee.getBeeSize();
                honey += days * beesize * 0.2f;
            }
            return honey;
        }
        public void BreedQueen()
        {
            Console.Clear();
            Console.WriteLine("Hive name");
            string n = Console.ReadLine();
            foreach (Bee bee in Bees)
            {
                if (bee.IsQueen())
                {
                    bee.BreedQueen();
                }
            }
        }
    }
}

