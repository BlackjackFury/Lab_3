using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Rectangle : Figure
    {
        public double w;
        public double h;
        public Rectangle(double w, double h)
        {
            this.h = h;
            this.w = w;
            this.Type = "Rectangle"; 
        }

        public override double Area()
        {
            return w * h;
        }
    }
}
