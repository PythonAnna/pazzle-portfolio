// See https://aka.ms/new-console-template for more information
// задание 1
int number = 10;
if (number > 0)
{
    Console.WriteLine("Число положительное");
}
else if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Число равно нулю");
}

// задание 2
Console.WriteLine("Введите ваш возраст");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Вы совершеннолетний");
}
else
{
    Console.WriteLine("Вы несовершеннолетний");
}

// задание 3
int num = 7;
if (num%2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

// задание 4
int a = 5, b = -2;
if (a>0 && b>0)
{
    Console.WriteLine("Оба числа положительные");
}
else if (a>0 || b>0)
{
    Console.WriteLine("Хотябы одно число положительное");
}
else if (a<0)
{
    Console.WriteLine("a - отрицательное");
}
else
{
    Console.WriteLine("Оба числа отрицательные");
}

// задание 5
int grade = int.Parse(Console.ReadLine());
if (grade < 3)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (grade == 3)
{
    Console.WriteLine("Удовлетворительно");
}
else if (grade == 4)
{
    Console.WriteLine("Хорошо");
}
else if (grade == 5)
{
    Console.WriteLine("Отлично");
}

//задание 6
int c, d, e;
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
e = int.Parse(Console.ReadLine());
if (c>d && c>e)
{
    Console.WriteLine(c);
}
else if (d>c && d>e)
{
    Console.WriteLine(d);
}
else
{
    Console.WriteLine(e);
}

// задание 7
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string operant = Console.ReadLine();
if (operant == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (operant == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (operant == "*")
{
    Console.WriteLine(num1 * num2);
}
else if (operant == "/")
{
    Console.WriteLine(num1 / num2);
}