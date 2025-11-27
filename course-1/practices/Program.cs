// See https://aka.ms/new-console-template for more information
//задание 1
int a = 12;
int b = 5;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

//задание 2
Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine("Привет, "+name);

//задание 3
Console.WriteLine("Введите число: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine(c+" * 19 = "+c * 19);

//задание 4
Console.WriteLine("Введите ширину: ");
int width = int.Parse(Console.ReadLine());
Console.WriteLine("Введите высоту: ");
int height = int.Parse(Console.ReadLine());
Console.WriteLine("Площадь: " + width * height);

//задание 5
Console.WriteLine("Введите температуру в градусах: ");
int temp = int.Parse(Console.ReadLine());
Console.WriteLine("Температура в фаренгейтах: " + temp * 9 / 5 + 32);

//задание 6
Console.WriteLine("Введите 3 числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Среднее арифметическое: "+(num1 + num2 + num3) / 3);

//задание 7
Console.WriteLine("Введите 2 числа: ");
int num4= int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма: " + (num4 + num5));
Console.WriteLine("Разность: " + (num4 - num5));
Console.WriteLine("Произведение: " + (num4 * num5));
Console.WriteLine("Частное: " + (num4 / num5));

//задание8
Console.WriteLine("Ведите сумму в рублях: ");
int rub = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма в доллорах: "+rub * 79);
Console.WriteLine("Сумма в евро: " + rub * 91);
Console.WriteLine("Сумма в юанях: " + rub * 11);