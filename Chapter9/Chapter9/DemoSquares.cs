using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class DemoSquares
    {
        public static void Run(string[] args)
        {
            //Instantiate an array with 10 squares with n+1 side lengths
            Square[] squares = new Square[10];
            for(int x=0;x<squares.Length;x++)
            {
                squares[x] = new Square(x + 1);
                //Display areas of each square
                Console.WriteLine("Area: {0}",squares[x].Area);
            }
        }
    }
}
