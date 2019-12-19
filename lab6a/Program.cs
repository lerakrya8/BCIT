using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6a
{
    class Program
    {
        delegate int PlusOrMultiplicatoin(int x, int y);
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Multip(int a, int b)
        {
            return a * b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static void PlusOrMultiplyMetod(string str, int a, int b, PlusOrMultiplicatoin PlusOrMultiplyParam)
        {
            int result = PlusOrMultiplyParam(a, b);
            Console.WriteLine(str + result.ToString());
        }
        static void PlusOrMultiplyMetodFunc(string str, int a1, int b2, Func<int, int, int> PlusOrMultiplyParam)
        {
            int Result = PlusOrMultiplyParam(a1, b2);
            Console.WriteLine(str + Result.ToString());
        }
        static void Main(string[] args)
        {
            Console.Write("Введите значения a: ");
            string a1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);
            Console.Write("Введите значение b: ");
            string b1 = Console.ReadLine();
            int b = Convert.ToInt32(b1);
            PlusOrMultiplicatoin p = new PlusOrMultiplicatoin(Multip);
            PlusOrMultiplyMetod("Создание экземпляра делегата на основе метода: ", a, b, p);
            PlusOrMultiplyMetod("Создание экземпляра делегата на основе лямбда-выражения: ", a, b, (x, y) => x + y);
            PlusOrMultiplyMetodFunc("Создание экземпляра делегата на основе метода Funk: ", a, b, Minus);
            Console.ReadKey();
        }
    }
}
