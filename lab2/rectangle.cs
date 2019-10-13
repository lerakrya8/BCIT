using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures;
using iprint;

namespace rectangle
{
    public class Rectangle : Figure, IPrint
    {
        double width;
        double length;
        public Rectangle(double wh, double lh)
        {
            this.width = wh;
            this.length = lh;
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            double result = this.width * this.length;
            return result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}