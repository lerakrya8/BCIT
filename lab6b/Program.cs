using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Person;
using attribute;

namespace lab6b
{
    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributea, out object attribute)
        {
            bool Result = false;
            attribute = null;
            var isAttribute = checkType.GetCustomAttributes(attributea, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }
            return Result;
        }
        static void Main(string[] args)
        {
                Person.Person obj = new Person.Person();
                Type t = obj.GetType();
                Console.WriteLine("\nИнформация о типе:");
                Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
                Console.WriteLine("Пространство имен " + t.Namespace);
                Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);
                Console.WriteLine("\nКонструкторы:");
                foreach (var x in t.GetConstructors())
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("\nМетоды:");
                foreach (var x in t.GetMethods())
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("\nСвойства:");
                foreach (var x in t.GetProperties())
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("\nПоля данных (public):");
                foreach (var x in t.GetFields())
                {
                    Console.WriteLine(x);
                }

            Type t2 = typeof(Person.Person);
            Console.WriteLine("\nВызов метода:");
            Person.Person Lera = (Person.Person)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });
            object[] parameters = new object[] { 5, 5 };
            object Result = t.InvokeMember("Study", BindingFlags.InvokeMethod, null, Lera, parameters);
            Console.WriteLine("Успеваемость: {0}", Result);

            Console.WriteLine("\nPerson реализует IComparable -> " + t.GetInterfaces().Contains(typeof(IComparable)));
                Type a = typeof(Person.Person);
                Console.WriteLine("\nСвойства, помеченные атрибутом:");
                foreach (var x in a.GetProperties())
                {
                    object at;
                    if (GetPropertyAttribute(x, typeof(NewAttribute), out at))
                    {
                        NewAttribute attr = at as NewAttribute;
                        Console.WriteLine(x.Name + " - " + attr.abc);
                    }
                }
                Console.ReadKey();
            }
    }
}
