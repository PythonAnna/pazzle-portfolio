using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание1
            var b1 = new Book();
            var b2 = new Book("1984");
            var b3 = new Book("Гарри Поттер", "Дж. Роулинд", 500);
            b1.PrintInfo();
            b2.PrintInfo();
            b3.PrintInfo();

            //задание2
            var car = new Car();
            car.PrintCar();
            var car1 = new Car("BMW");
            car1.PrintCar();

            //задание3
            var p1 = new Player("Alex", 10);
            var p2 = p1;
            Console.WriteLine(p1 == p2);

            //задание4
            var user = new User();
            user.Login = "U";
            user.Password = "";
            user.Password = "12345";
            user.CheckPassword("54321");
            user.CheckPassword("12345");

            //задание5
            var point1 = new Point(1, 1);
            var point2 = point1;
            Console.WriteLine("Координаты point 2");
            point2.Move(2, 3);
            Console.WriteLine("Координаты point 1");
            Console.WriteLine($"{point1.X}, {point1.Y}");
        }

        //задание1
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }

            public Book()
            {
                Title = "Не указано";
                Author = "Не указано";
                Pages = 0;
            }

            public Book(string title)
            {
                Title = title;
                Author = "Не указано";
                Pages = 0;
            }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
                Pages = 0;
            }

            public Book(string title, string author, int pages)
            {
                Title = title;
                Author = author;
                Pages = pages;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{Title}, {Author}, {Pages}");
            }
        }

        //задание2
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Speed { get; set; }
            public Car(string brand, string model, int speed)
            {
                Brand = brand;
                Model = model;
                Speed = speed;
            }

            public Car() : this("Неизвестно", "Неизвестно", 0) { }
            public Car(string brand) : this(brand, "Неизвестно", 0) { }
            public Car(string brand, string model) : this(brand, model, 0) { }

            public void PrintCar()
            {
                Console.WriteLine($"{Brand}, {Model}, {Speed}");
            }
        }

        //задание3
        public class Player
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public Player(string name, int level)
            {
                Name = name;
                Level = level;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"{Name}, {Level}");
            }
        }

        //задание4
        public class User
        {
            public string Login { get; set; }
            private string password;
            public string Password
            {
                get 
                {
                    return "скрыто";
                }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Ошибка: пароль не может быть пустым!");
                        return;
                    }
                    password = value;
                    Console.WriteLine("Пароль обновлен!");
                }
            }
            public void CheckPassword(string input)
            {
                if (input == password)
                {
                    Console.WriteLine($"Здравствуйте, {Login}!");
                }
                else
                {
                    Console.WriteLine("Неверный пароль!");
                }
            }
        }

        //задание5
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Move(int dx, int dy)
            {
                X += dx;
                Y += dy;
                Console.WriteLine($"{X}, {Y}");
            }
        }
    }
}