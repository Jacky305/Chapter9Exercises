using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class Square
    {
        public int Side { get; set; }
        public int Area { get; set; }

        public Square(int sideLength)
        {
            this.Side = sideLength;
            ComputerSquareArea();
        }
        private void ComputerSquareArea()
        {
            this.Area = this.Side * this.Side;
        }
    }
}
