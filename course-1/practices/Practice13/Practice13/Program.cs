using System;

namespace Practice13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            var p = new Person();
            p.Name = "Алиса";
            p.Age = 25;
            p.Age = -5;

            //Задание 2
            var account = new BankAccount();
            account.Deposit(500);
            account.ShowBalance();
            account.Withdraw(600);

            //Задание 3
            var t = new Thermometer();
            t.TemperatureCelsius(25);
            t.TemperatureFahrenheit();

            //Задание 4
            var bobik = new Dog();
            bobik.Eat();
            bobik.Run();
        }

        //Задание 1
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

        //Задание 2
        public class BankAccount
        {
            private decimal balance;
            public void Deposit(decimal amount)
            {
                balance += amount;
            }
            public void Withdraw(decimal amount)
            {
                if (amount <= balance)
                    balance -= amount;
                else
                    Console.WriteLine("Недостаточно средств");
            }
            public void ShowBalance()
            {
                Console.WriteLine($"Баланс: {balance}");
            }
        }

        //Задание 3
        public class Thermometer
        {
            private int temperatureCelsius;
            public void TemperatureCelsius(int temp)
            {
                if (temp < -273)
                    Console.WriteLine("Слишком низкая температура");
                else
                    temperatureCelsius = temp;
            }
            public void TemperatureFahrenheit()
            {
                Console.WriteLine((temperatureCelsius * 9 / 5) + 32);
            }
        }

        //Задание 4
        public class Animal
        {
            protected int energy = 100;
            public void Eat()
            {
                energy += 10;
                Console.WriteLine($"Животное поело, энергия: {energy}");
            }
        }
        public class Dog:Animal
        {
            public void Run()
            {
                energy -= 20;
                Console.WriteLine($"Собака побежала, энергия: {energy}");
            }
        }
    }
}
