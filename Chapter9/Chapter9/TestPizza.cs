using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class TestPizza
    {
        public static void Run(string[] args)
        {
            //Instantiate 1 Pizza object
            Pizza pizza = new Pizza();
            //Demonstrate use of set and get accessors
            pizza.Toppings = "Ham";
            Console.WriteLine("Pizza's topping: {0}", pizza.Toppings);

            pizza.Toppings = "Cheese";
            Console.WriteLine("Pizza's topping now: {0}", pizza.Toppings);
        }
    }
}
