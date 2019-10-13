using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public abstract class Figure : IComparable
    {
        public string Type { get; protected set; }
        public abstract double Area();
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        public int CompareTo(object o)
        {
            Figure f = (Figure)o;
            if (this.Area() > f.Area())
                return 1;
            if (this.Area() < f.Area())
                return -1;
            else
                return 0;
        }

    }
}