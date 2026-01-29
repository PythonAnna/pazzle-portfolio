using System;
namespace Homework3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            Worker[] workers =
            {
                new Manager{Name="Анна"},
                new Developer{Name="Иван"}
            };

            foreach(var w in workers)
            {
                w.ShowInfo();
                w.Work();
            }

            //Задание2
            CookingProcess[] food =
            {
                new Soup(),
                new Steak()
            };

            foreach(var f in food)
            {
                f.Preparation();
                f.Cooking();
                f.Serve();
            }
        }
    }

    //Задание1
    public abstract class Worker
    {
        public string Name { get; set; }
        public abstract void Work();
        public void ShowInfo()
        {
            Console.WriteLine($"Работник: {Name}");
        }
    }

    public class Manager:Worker
    {
        public override void Work()
        {
            Console.WriteLine("Планирует задачи");
        }
    }

    public class Developer : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Пишет код");
        }
    }

    //Задание2
    public abstract class CookingProcess
    {
        public abstract void Preparation();
        public abstract void Cooking();
        public abstract void Serve();
    }

    public class Soup:CookingProcess
    {
        public override void Preparation()
        {
            Console.WriteLine("Достать картошку, маркошку, мяско, лаврушку, специи по вкусу");
        }
        public override void Cooking()
        {
            Console.WriteLine("Почистить и порезать овощи, кинуть все ингридиенты в кастрюлю, залить водой, доюавить специи по вкусу, пусть варится");
        }
        public override void Serve()
        {
            Console.WriteLine("Налить в тарелку, посывать зеленью, подавать с хлебушком");
        }
    }

    public class Steak: CookingProcess
    {
        public override void Preparation()
        {
            Console.WriteLine("Подготовить мясо, специи");
        }
        public override void Cooking()
        {
            Console.WriteLine("Кинуть на сковородку, пусть жарится");
        }
        public override void Serve()
        {
            Console.WriteLine("Выложить на тарелку, добавить гарнир или соус");
        }
    }
}
