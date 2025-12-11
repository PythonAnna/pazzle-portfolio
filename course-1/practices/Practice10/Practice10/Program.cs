using System;

namespace Practice10
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            var car = new Car { Brand = "BMW" };
            car.Accelerate();
            Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
            //задание 2
            var car1 = new Car1("Audi", 50);
            Console.WriteLine($"{car1.Brand} едет со скоростью {car1.Speed} км/ч");
            //задание 3
            var book = new Book { Title = "Маленький принц", Author = "Антуан де Сент Экзюпери", Pages = 100 };
            book.Read(19);
            book.Read(200);
            //задание 4
            var lib = new Library();
            lib.AddBook(new Book { Title = "1984", Author = "Дж. Оруэлл", Pages = 350 });
            lib.PrintAllBooks();
            //задание 5
            var calc = new Calc();
            calc.Main();
            //задание 6
            var phone = new Phone { Model = "Samsung Galaxy", Battery = 0 };
            phone.Charge(30);
            Console.WriteLine($"Заряд: {phone.Battery}%");
            phone.Use(10);
            Console.WriteLine($"Заряд: {phone.Battery}%");
        }

        //задание 1
        public class Car
        {
            public string Brand { get; set; }
            public int Speed { get; set; } = 0;
            public void Accelerate()
            {
                Speed += 10;
            }
        }

        //задание 2
        public class Car1
        {
            public string Brand { get; set; }
            public int Speed { get; set; }
            public Car1(string brand, int speed)
            {
                Brand = brand;
                Speed = speed;
            }
            public void Accelerate()
            {
                Speed += 10;
            }
        }

        //задание 3
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public void Read(int x)
            {
                if (x > Pages)
                {
                    Console.WriteLine($"В книге всего {Pages} страниц!");
                }
                else
                {
                    Console.WriteLine($"Вы прочитали {x} страниц из {Pages}");
                }
            }
        }

        //задание 4
        public class Library
        {
            public List<Book> books = new List<Book>();
            public void AddBook(Book book)
            {
                books.Add(book);
            }
            public void PrintAllBooks()
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title}-{book.Author} {book.Pages} стр.");
                }
            }
        }

        //задание 5
        public class Calc
        {
            public void Add(int x, int y)
            {
                Console.WriteLine(x + y);
            }
            public void Subtract(int x, int y)
            {
                Console.WriteLine(x - y);
            }
            public void Multiply(int x, int y)
            {
                Console.WriteLine(x * y);
            }
            public void Divide(int x, int y)
            {
                Console.WriteLine(x / y);
            }
            public void Main()
            {
                Console.WriteLine("Введите start для запуска калькуляора и exit для его выключения");
                string input = Console.ReadLine();
                while (input != "exit")
                {
                    Console.WriteLine("Введите математическое выражение. Например, 2 + 2");
                    input = Console.ReadLine();
                    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int x = int.Parse(parts[0]);
                    int y = int.Parse(parts[2]);
                    string operation = parts[1];
                    Console.Write($"{input} = ");
                    if (operation == "+")
                    {
                        Add(x, y);
                    }
                    else if (operation == "-")
                    {
                        Subtract(x, y);
                    }
                    else if (operation == "*")
                    {
                        Multiply(x, y);
                    }
                    else if (operation == "/")
                    {
                        Divide(x, y);
                    }
                }
            }
        }

        //задание 6
        public class Phone
        {
            public string Model { get; set; }
            public int Battery { get; set; }
            public void Charge(int amount)
            {
                Battery += amount;
            }
            public void Use(int amount)
            {
                Battery -= amount;
            }
        }
    }
}