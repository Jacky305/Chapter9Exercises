using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class TaxPayerDemo
    {
        public static void Run(string[] args)
        {
            TaxPayer[] taxArray = new TaxPayer[5];

            for (int x=0; x < taxArray.Length; x++)
            {
                
                Console.WriteLine("Enter gross income for customer NO.{0}",x+1);
                taxArray[x] = new TaxPayer(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Details:\n");
            foreach (TaxPayer person in taxArray)
            {
                Console.WriteLine("GrossIncome: {0}\n", person.YearlyGrossIncome);
                Console.WriteLine("Tax owed: {0}",person.TaxOwed);
            }
        }
    }
}
