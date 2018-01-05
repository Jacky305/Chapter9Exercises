using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class Circle
    {
        public double Radius { get; set; }
        private double area;
        public double Area { get { return area; }}
        private double diameter;
        public double Diameter { get { return diameter; } }

        public Circle(double radius)
        {
            this.Radius = radius;
            this.diameter = radius * 2;
            this.area = radius * radius * Math.PI;
        }
        public Circle()
        {
            this.Radius = 1;
            this.diameter = this.Radius * 2;
            this.area = this.Radius * this.Radius * Math.PI;
        }
    }
}
