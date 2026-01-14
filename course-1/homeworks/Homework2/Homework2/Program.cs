using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            var car = new Car { Model = "Audy" };
            car.Accelerate(100);
            car.ShowInfo();
            car.Move();

            var bike = new Bicycle { Model = "Cobe" };
            bike.Pedal();
            bike.ShowInfo();
            bike.Move();

            //Задание 2
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
        public class Transport
        {
            public string Model { get; set; }
            protected int Speed = 0;
            public void ShowInfo()
            {
                Console.WriteLine($"Модель: {Model}, скорость: {Speed} км/ч");
            }
            public virtual void Move()
            {
                Console.WriteLine("Транпорт движется");
            }
        }

        public class Car: Transport
        {
            public void Accelerate(int value)
            {
                if(value>200)
                {
                    Console.WriteLine("Слишком большая скорость!");
                }
                else
                {
                    Speed += value;
                }
            }
            public override void Move()
            {
                Console.WriteLine("Машина едет по дороге");
            }
        }

        public class Bicycle : Transport
        {
            public void Pedal()
            {
                Speed += 5;
            }
            public override void Move()
            {
                Console.WriteLine("Велосипед крутит педали");
            }
        }

        //Задание 2
        public abstract class Character
        {
            public string Name { get; set; }
            public abstract void Attack();
        }

        public class Warrior: Character
        {
            public override void Attack()
            {
                Console.WriteLine("Воин атакует мечем!");
            }
        }

        public class Mage: Character
        {
            public override void Attack()
            {
                Console.WriteLine("Маг выпускает огненный шар!");
            }
        }

        public class Archer: Character
        {
            public override void Attack()
            {
                Console.WriteLine("Лучник стреляет из лука!");
            }
        }
    }
}