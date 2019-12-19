using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circle;
using rectangle;
using square;
using figures;
//using icomparable;
using Figures;
using System.Collections;
using simplelist;
using simplestack;
using simplelistitem;
using figurematrix;
using matrix;
using imatrixcheck;

namespace lab3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Гусева Валерия ИУ5-33Б";
            Rectangle rectangle = new Rectangle(20, 8);
            Square square = new Square(7);
            Circle circle = new Circle(4);
            ArrayList al = new ArrayList();

            al.Add(rectangle);
            al.Add(square);
            al.Add(circle);

            al.Sort();

            Console.WriteLine("Сортировка коллекции класс ArrayList: ");
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            List<Figure> li = new List<Figure>
            {
                rectangle, square, circle
            };
            Console.WriteLine("Сортировка коллекции класса List<Figure>: ");
            li.Sort();
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\nМатрица");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0] = square;
            matrix[1, 1] = circle;
            matrix[2, 2] = rectangle;
            Console.WriteLine(matrix.ToString());

            SimpleList<Figure> list = new SimpleList<Figure>();

            list.Add(circle);
            list.Add(rectangle);
            list.Add(square);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (var x in list) Console.WriteLine(x);
            list.Sort();

            Console.WriteLine("\nПосле сортировки:");

            foreach (var x in list) Console.WriteLine(x); Console.ReadLine();
            Console.ReadKey();
        }
    }
}