using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Square : Rectangle
    {

        public Square(double size) : base(size, size)
        {
            this.Type = "Square";
        }
    }
}
