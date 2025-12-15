using System;

namespace Practice12
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Шарик");
            dog.Eat();
            dog.Bark();
            dog.Speak();
            dog.Move();

            var cat = new Cat("Мурка");
            cat.Eat();
            cat.Meow();
            cat.Speak();

            var transport = new Transport();
            var car = new Car();
            var tesla = new ElectricCar();

            transport.Drive();
            car.Drive();
            tesla.Drive();
        }
        public class Animal
        {
            public string Name { get; set; }
            public void Eat()
            {
                Console.WriteLine($"{Name} ест");
            }
            public virtual void Speak()
            {
                Console.WriteLine("Животное издает звук");
            }
            public virtual void Move()
            {
                Console.WriteLine("Животное двигается");
            }
            public Animal(string name)
            {
                Name = name;
                Console.WriteLine($"Создано животное: {Name}");
            }
        }
        public class Dog: Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} лает");
            }
            public override void Speak()
            {
                Console.WriteLine("Собака говорит: Гав-гав!");
            }
            public override void Move()
            {
                base.Move();
                Console.WriteLine("Собака бежит по дороге");
            }
            public Dog(string name) : base(name)
            {
                Console.WriteLine($"Создана собака по имени {Name}");
            }
        }
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine($"{Name} мяукает");
            }
            public override void Speak()
            {
                Console.WriteLine("Кошка говорит: Мяу!");
            }
            public Cat(string name) : base(name)
            {
                Console.WriteLine($"Создана кошка по имени {Name}");
            }
        }
        public class Transport
        {
            public virtual void Drive()
            {
                Console.WriteLine("Транспорт движется");
            }
        }
        public class Car:Transport
        {
            public override void Drive()
            {
                Console.WriteLine("Машина едет по дороге");
            }
        }
        public class ElectricCar:Car
        {
            public override void Drive()
            {
                Console.WriteLine("Электромобиль тихо едет на батарее");
            }
        }
    }
}