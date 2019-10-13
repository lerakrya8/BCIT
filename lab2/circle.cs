using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures;
using iprint;



namespace circle
{
    public class Circle : Figure, IPrint
    {
        double radius;
        public Circle(double rs)
        {
            this.radius = rs;
            this.Type = "Круг";
        }
        public override double Area()
        {
            double result = this.radius * this.radius * Math.PI;
            return result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
