// See https://aka.ms/new-console-template for more information
// задание 1
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

void SayHello()
{
    Console.WriteLine("Привет, Мир!");
}

SayHello();
SayHello();
SayHello();

// задание 2
void Greet(string name)
{
    Console.WriteLine("Привет, " + name+"!");
}

Greet("Саша");
Greet("Ярослав");
Greet("Анна");

// задание 3
void PrintPerson(string name, int age, string city)
{
    Console.WriteLine($"Имя: {name}, возраст: {age}, город: {city}");
}

PrintPerson("Егор", 15, "Москва");
PrintPerson("Саша", 18, "Челябинск");
PrintPerson("Катя", 20, "Казань");

// задание 4
void PrintPerson1(string name, int age = 18, string hobby = "Не указано")
{
    Console.WriteLine($"Имя: {name}, возраст: {age}, хобби: {hobby}");
}

PrintPerson1("Егор", 15, "Пение");
PrintPerson1("Катя", 20);
PrintPerson1("Саша");

// задание 5
void Square(int x)
{
    Console.WriteLine(x * x);
}

Square(9);

// задание 6
void Add(int a, int b)
{
    Console.WriteLine(a + b);
}

void Subtract(int a, int b)
{
    Console.WriteLine(a - b);
}

void Multiply(int a, int b)
{
    Console.WriteLine(a * b);
}

void Divide(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Делить на ноль нельзя!");
    }
    else
    {
        Console.WriteLine(a / b);
    }
}

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите знак действия: ");
string c = Console.ReadLine();
if (c == "+")
{
    Add(a, b);
}
else if (c == "-")
{
    Subtract(a, b);
}
else if (c == "*")
{
    Multiply(a, b);
}
else if (c == "/")
{
    Divide(a, b);
}

// задание 7
int counter = 0;
void Increment()
{
    counter++;
    Console.WriteLine(counter);
}

Increment();
Increment();
Increment();

// задание 8
static int Multiply1(int a, int b)
{
    return a * b;
}

static int Multiply2(int a, int b, int c)
{
    return a * b * c;
    
}

static double Multiply3(double a, double b)
{
    return a * b;
}

Console.WriteLine(Multiply1(2, 3));
Console.WriteLine(Multiply2(2, 3, 4));
Console.WriteLine(Multiply3(2.5, 4.0));