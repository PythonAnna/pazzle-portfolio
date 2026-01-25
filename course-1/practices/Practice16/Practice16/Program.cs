using System;

namespace Practice16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            Shape[] shapes =
            {
                new Circle{Radius=5},
                new Rectangle{Width=2, Height=3}
            };

            foreach (var s in shapes) 
            {
                s.Print();
            }

            //Задание2
            Animal[] animals =
            {
                new Dog("Рекс"),
                new Cat("Мурка")
            };

            foreach(var a in animals)
            {
                a.Eat();
                a.MakeSound();
            }

            //Задание3
            Transport[] t =
            {
                new Car(),
                new Boat()
            };

            foreach (var x in t)
            {
                x.Move();
            }

            //Задание4
            DocumentExporter[] exporters =
            {
                new TxtExporter(),
                new PdfExporter()
            };

            foreach(var e in exporters)
            {
                e.ShowInfo("Hello, World!");
                e.Export("Hello, World!");
            }
        }

        //Задание1
        public abstract class Shape
        {
            public abstract string Name { get; }
            public abstract double GetArea();
            public void Print()
            {
                Console.WriteLine($"{Name}: площядь = {GetArea}");
            }
        }

        public class Circle : Shape
        {
            public override string Name => "Круг";
            public double Radius { get; set; }
            public override double GetArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : Shape
        {
            public override string Name => "Прямоугольник";
            public double Width { get; set; }
            public double Height { get; set; }
            public override double GetArea()
            {
                return Width * Height;
            }
        }

        //Задание2
        public abstract class Animal
        {
            public string Name { get; }
            protected Animal(string name)
            {
                Name = name;
                Console.WriteLine($"Создано животное: {Name}");
            }
            public void Eat()
            {
                Console.WriteLine($"{Name} ест.");
            }
            public abstract void MakeSound();
        }

        public class Dog : Animal
        {
            public Dog(string name): base(name)
            {
                Console.WriteLine($"{Name} - собака");
            }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name}: Гав-гав!");
            }
        }

        public class Cat: Animal
        {
            public Cat(string name): base(name)
            {
                Console.WriteLine($"{Name} - кошка");
            }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name}: Мяу!");
            }
        }

        public abstract class Transport
        {
            public void Move()
            {
                Start();
                MoveCore();
                Stop();
            }

            protected void Start()
            {
                Console.WriteLine("Старт!");
            }
            protected void Stop()
            {
                Console.WriteLine("Стоп!");
            }
            protected abstract void MoveCore();
        }

        //Задание3
        public class Car: Transport
        {
            protected override void MoveCore()
            {
                Console.WriteLine("Машина едет по дороге");
            }
        }

        public class Boat: Transport
        {
            protected override void MoveCore()
            {
                Console.WriteLine("Лодка плывёт по воде");
            }
        }

        //Задание4
        public abstract class DocumentExporter
        {
            public abstract string FormatName { get; }
            public abstract void Export(string content);
            public void ShowInfo(string content)
            {
                Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
            }
        }

        public class TxtExporter: DocumentExporter
        {
            public override string FormatName => "TXT";
            public override void Export(string content)
            {
                Console.WriteLine("Сохраняем текстовый файл");
            }
        }

        public class PdfExporter: DocumentExporter
        {
            public override string FormatName => "PDF";
            public override void Export(string content)
            {
                Console.WriteLine("Создаём PDF-документ");
            }
        }
    }
}