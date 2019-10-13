using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        static double proverka()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Значение введено некорректно! Повторите попытку.");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Гусева Валерия ИУ5-33Б";
            double a, b, c;
            if (args.Length == 3)
            {
                double.TryParse(args[0], out a);
                double.TryParse(args[1], out b);
                double.TryParse(args[2], out c);
            }
            else
            {
                Console.Write("Введите значения коэффициентов a, b, c би-квадратного уравнения: \na = ");
                a = proverka();
                Console.Write("\nb = ");
                b = proverka();
                Console.Write("\nc = ");
                c = proverka();
            }
            double x1, x2, x3, x4;
            if (a == 0)
            {
                if (b != 0)
                {
                    if ((-1) * c / b > 0)
                    {
                        x1 = Math.Sqrt((-1) * c / b);
                        x2 = (-1) * x1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни би-квадратного уравнения: x1 = {x1}, x2 = {x2}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет!");
                    }
                }
                else
                {
                    if (c != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Бескочное множество решений");
                    }
                }
            }
            else
            {
                if (b == 0)
                {
                    if ((-1) * c / a > 0)
                    {
                        x3 = Math.Sqrt((-1) * c / a);
                        x4 = (-1) * x3;
                        x1 = Math.Sqrt(x3);
                        x2 = (-1) * x1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни би-квадратного уравнения: x1 = {x1}, x2 = {x2}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет!");
                    }
                }
                else
                {
                    if (c == 0)
                    {
                        x1 = 0;
                        x2 = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Корни би-квадратного уравнения: x1 = {x1}, x2 = {x2}");
                        if ((-1) * b / a > 0)
                        {
                            x3 = Math.Sqrt((-1) * b / a);
                            x4 = (-1) * x3;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($", x3 = {x3}, x4 = {x4}");
                        }
                    }
                    else
                    {
                        double D, t1, t2;
                        D = b * b - 4 * a * c;
                        if (D > 0)
                        {
                            t1 = (-b + Math.Sqrt(D)) / (2 * a);
                            t2 = (-b - Math.Sqrt(D)) / (2 * a);
                            if (t1 < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Корней нет!");
                            }
                            if (t2 > 0)
                            {
                                x1 = Math.Sqrt(t1);
                                x2 = -x1;
                                x3 = Math.Sqrt(t2);
                                x4 = -x3;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"Корни би-квадратного уравнения: x1 = {x1}, x2 = {x2}, x3 = {x3}, x4 = {x4}");
                            }
                            else
                            {
                                if (t1 > 0)
                                {
                                    x1 = Math.Sqrt(t1);
                                    x2 = -x1;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"Корни би-квадратного уравнения: x1 = {x1}, x2 = {x2}");
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Корней нет!");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}