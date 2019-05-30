using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            Bee yeet = MakeBee();
        }

        public static Bee MakeBee()
        {
            Console.WriteLine("Bee name");
            string n = Console.ReadLine();
            Console.WriteLine("Bee size");
            float s = float.Parse(Console.ReadLine());
            return new Bee(n, s);
        }

        public static Beehive MakeHive()
        {
            Console.WriteLine("Hive name");
            string n = Console.ReadLine();            
            return new Beehive(n);
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

