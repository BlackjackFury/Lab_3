using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Circle : Figure
    {

        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            this.Type = "Circle";
        }

        public override double Area()
        {
            return this.radius * this.radius * Math.PI;
        }


    }
}
