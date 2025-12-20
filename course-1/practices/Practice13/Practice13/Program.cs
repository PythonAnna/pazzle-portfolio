using System;

namespace Practice13
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Алиса";
            p.Age = 25;
            p.Age = -5;
        }
        public class Person
        {
            private string name;
            private int age;
            public string Name
            {
                get { return name; }
                set
                {
                    if (value != "")
                    {
                        name = value;
                    }
                    else
                        Console.WriteLine("Вы не указали имя");
                }
            }
            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                    else
                        Console.WriteLine("Возраст не может быть отрицательным!");
                }
            }
        }
        public class BankAccount
        {

        }
    }
}
