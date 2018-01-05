using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class DemoScouts
    {
        public static void Run(string[] args)
        {
            GirlScout g1 = new GirlScout();
            Console.WriteLine("Scout1: Name: {0}, Number: {1}, DuesOwed: {2}",g1.name,g1.number,g1.duesOwed);
            GirlScout g2 = new GirlScout("Mary", 1212, 50);
            Console.WriteLine("Scout2: Name: {0}, Number: {1}, DuesOwed: {2}", g2.name, g2.number, g2.duesOwed);
        }
    }
}
