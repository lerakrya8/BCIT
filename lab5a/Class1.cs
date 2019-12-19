using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    class Class1
    {
        public static int rasstoyanie(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return -1;
            int ss1 = s1.Length;
            int ss2 = s2.Length;
            if (ss1 == 0 || ss2 == 0)
                return 0;
            if (ss1 == 0)
                return ss2;
            if (ss2 == 0)
                return ss1;
            string str1 = s1.ToUpper();
            string str2 = s2.ToUpper();
            int[,] mass = new int[ss1 + 1, ss2 + 1];
            for (int i = 0; i < ss1 + 1; i++)
                mass[i, 0] = i;
            for (int j = 0; j < ss2 + 1; j++)
                mass[0, j] = j;
            for (int i = 1; i < ss1 + 1; i++)
            {
                for (int j = 1; j < ss2 + 1; j++)
                {
                    int m = str1[i - 1] == str2[j - 1] ? 0 : 1;
                    int pl = mass[i, j - 1] + 1;
                    int min = mass[i - 1, j] + 1;
                    int zam = mass[i - 1, j - 1] + m;
                    mass[i, j] = Math.Min(Math.Min(pl, min), zam);
                    if (i > 1 && j > 1 && str1[i - 1] == str2[j - 2] && str1[i - 2] == str2[j - 1])
                    {
                        mass[i, j] = Math.Min(mass[i, j], mass[i - 2, j - 2] + zam);
                    }
                }
            }
            return mass[ss1, ss2];
        }
        public static void Vivod(string s1, string s2)
        {
            int length = rasstoyanie(s1, s2);
            Console.Write("Строка1: " + s1 + "\n Строка2: " + s2 + "\n Расстояние Дамерау-Левейнштейна: " + length.ToString());
        }
    }
}
