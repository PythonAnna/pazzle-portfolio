// See https://aka.ms/new-console-template for more information

// задание 1
int[] grs = { 5, 4, 3, 5, 4, 2, 5 };
int sr = 0;
int grs5 = 0;
int grs2 = 0;
for (int i = 0; i < grs.Length; i++)
{
    sr += grs[i];
}
Console.WriteLine("Средний балл: "+sr / grs.Length);
for (int i =0; i < grs.Length; i++)
{
    if (grs[i] == 5)
    {
        grs5++;
    }
    else if (grs[i] == 2)
    {
        grs2++;
    }
}
Console.WriteLine("Коллическо оценок 5: "+grs5);
Console.WriteLine("Количество оценок 2: "+grs2);

// задание 2
int[] m = { 1, 2, 3, 4, 5 };
Console.WriteLine("Массив в прямом порядке: ");
for (int i = 0; i < m.Length; i++)
{
    Console.WriteLine(m[i]);
}
Console.WriteLine("Массив в обратном порядке: ");
for (int i = 4; i >= 0; i--)
{
    Console.WriteLine(m[i]);
}

// задание 3
Console.WriteLine("Четные числа:");
for (int i = 1; i <=20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        continue;
    }
}

// задание 4
string pass = "1234";
Console.WriteLine("Введите пароль: ");
string u_pass = Console.ReadLine();
for (int i = 0; i < 3; i++)
{
    if (u_pass == pass)
    {
        Console.WriteLine("Доступ разрешен!");
        break;
    }
    else if (i == 2)
    {
        Console.WriteLine("Доступ запрещен!");
        break;
    }
    else
    {
        u_pass = Console.ReadLine();
    }
}