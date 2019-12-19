using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class1;

namespace lab5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое слово: ");
            string sl1 = Console.ReadLine();
            Console.Write("Второе слово: ");
            string sl2 = Console.ReadLine();
            Console.Write("Введите максимальное расстояние: ");
            string sizz = Console.ReadLine();
            int size = Convert.ToInt32(sizz);
            if (rasstoyanie(sl1, sl2) < size)
                Vivod(sl1, sl2);
            else
                Console.Write("Расстояние Дамерау-Левейнштейна больше максимального! ");
            Console.ReadKey();
        }

        private static void Vivod(string sl1, string sl2)
        {
            throw new NotImplementedException();
        }

        private static int rasstoyanie(string sl1, string sl2)
        {
            throw new NotImplementedException();
        }
    }
}
