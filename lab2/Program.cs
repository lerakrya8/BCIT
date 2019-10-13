using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rectangle;
using square;
using circle;


namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Гусева Валерия ИУ5-33Б";
            Rectangle rectangle = new Rectangle(20, 8);
            Square square = new Square(7);
            Circle circle = new Circle(4);
            rectangle.Print();
            square.Print();
            circle.Print();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}