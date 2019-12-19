using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            name = "Неизвестно";
            age = 19;
        }
        public Person(string na)
        {
            name = na;
            age = 19;
        }
        public Person(string na, int n)
        {
            name = na;
            age = n;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
        public int Study (int a1, int b1)
        {
            return (a1+b1)/2 ;
        }
         [attribute.NewAttribute(abc = "Описание для Name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [attribute.NewAttribute("Описание для Age")]
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int CompareTo(object obj) { return 0; }
    }
}
