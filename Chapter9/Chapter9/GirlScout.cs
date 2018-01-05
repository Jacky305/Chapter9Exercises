using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class GirlScout
    {
        public const string MOTTO = "to obey the Girl Scout law";
        public string name { get; set; }
        public int number { get; set; }
        public double duesOwed { get; set; }

        public GirlScout() : this("Unnamed", 0,0)
        {
        }
        public GirlScout(string name, int number, double owed)
        {
            this.name = name;
            this.number = number;
            this.duesOwed = owed;

            SayMotto();
        }
        private void SayMotto()
        {
            Console.WriteLine("to obey the Girl Scout law");
        }
    }
}
