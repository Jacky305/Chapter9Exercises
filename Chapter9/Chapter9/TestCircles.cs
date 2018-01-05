using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class TestCircles
    {
        public static void Run(string[] args)
        {
            Circle circle1 = new Circle(2);
            Circle circle2 = new Circle(20);
            Circle circle3 = new Circle();

            Console.WriteLine("C1- Radius: {0} Diameter: {1}, Area: {2}",circle1.Radius,circle1.Diameter,circle1.Area.ToString("0.##"));
            Console.WriteLine("C2- Radius: {0} Diameter: {1}, Area: {2}", circle2.Radius, circle2.Diameter, circle2.Area.ToString("0.##"));
            Console.WriteLine("C3- Radius: {0} Diameter: {1}, Area: {2}", circle3.Radius, circle3.Diameter, circle3.Area.ToString("0.##"));
        }
    }
}
