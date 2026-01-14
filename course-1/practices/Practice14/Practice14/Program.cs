using System;
using System.Xml.Linq;

namespace Practice14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal cow = new Cow();
            dog.Speak();
            cat.Speak();
            cow.Speak();

            //Задание 2
            Transport[] vehicles =
            {
                new Car {Model="Audi"},
                new Boat{Model="Yamaha"},
                new Plane{Model="Boeing"}
            };

            foreach(var v in vehicles)
            {
                v.Move();
            }

            //Задание 3
            Shape[] shapes =
            {
                new Circle{Radius=5},
                new Square{Side=4},
                new Rectandl{Width=3, Height=6}
            };

            foreach(var s in shapes)
            {
                Console.WriteLine(s.GetArea());
            }

            //Задание 4
            Instrument[] instruments =
            {
                new Guitar(),
                new Piano(),
                new Drum()
            };

            foreach(var i in instruments)
            {
                i.Play();
            }

            //Задание 5
            Character[] team =
            {
                new Warrior{Name="Алекс"},
                new Mage{Name="Лия"},
                new Archer{Name="Робин"}
            };

            foreach(var c in team)
            {
                Console.Write($"{c.Name}:");
                c.Attack();
            }
        }

        //Задание 1
        public class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Животное издает звук");
            }
        }
        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Собака говорит: Гав-гав!");
            }
        }
        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Кошка говорит: Мяу!");
            }

        }
        public class Cow : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Корова говорит: Муу!");
            }

        }

        //Задание 2
        public class Transport
        {
            public string Model { get; set; }
            public virtual void Move()
            {
                Console.WriteLine($"{Model}: транспорт движется");
            }
        }
        public class Car: Transport
        {
            public override void Move()
            {
                base.Move();
                Console.WriteLine("Машина едет по дороге");
            }
        }
        public class Boat: Transport
        {
            public override void Move()
            {
                base.Move();
                Console.WriteLine("Лодка плывет по воде");
            }
        }
        public class Plane: Transport
        {
            public override void Move()
            {
                base.Move();
                Console.WriteLine("Самолет летит в небе");
            }
        }

        //Задание 3
        public abstract class Shape
        {
            public abstract double GetArea();
        }

       public class Circle: Shape
        {
            public double Radius { get; set; }
            public override double GetArea() => Math.PI*Radius*Radius;
        }

        public class Square: Shape
        {
            public double Side { get; set; }
            public override double GetArea() => Side * Side;
        }

        public class Rectandl: Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double GetArea() => Width * Height;
        }

        //Задание 4
        public class Instrument
        {
            public virtual void Play()
            {
                Console.WriteLine("Инструмент издает звук");
            }
        }

        public class Guitar: Instrument
        {
            public override void Play()
            {
                Console.WriteLine("Гитара играет аккорды");
            }
        }

        public class Piano : Instrument
        {
            public override void Play()
            {
                Console.WriteLine("Пианино играет мелодию");
            }
        }

        public class Drum : Instrument
        {
            public override void Play()
            {
                Console.WriteLine("Барабан бьет ритм");
            }
        }

        //Задание 5
        public abstract class Character
        {
            public string Name { get; set; }
            public abstract void Attack();
        }

        public class Warrior : Character
        {
            public override void Attack()
            {
                Console.WriteLine("Воин атакует мечом!");
            }
        }

        public class Mage : Character
        {
            public override void Attack()
            {
                Console.WriteLine("Маг выпускает огненный шар!");
            }
        }

        public class Archer : Character
        {
            public override void Attack()
            {
                Console.WriteLine("Лучник стреляет из лука!");
            }
        }
    }
}