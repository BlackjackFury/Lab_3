using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    abstract class Figure : IComparable
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;
        public abstract double Area();

        public int CompareTo(object obj)
        {
            Figure f = (Figure)obj;
            if (this.Area() < f.Area())
            {
                return -1;
            }
            if (this.Area() > f.Area())
            {
                return 1;
            }

            return 0;
            
        }

        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
    }
}
