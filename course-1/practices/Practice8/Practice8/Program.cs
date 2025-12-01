// See https://aka.ms/new-console-template for more information

// задание 1
int[] nums = { 1, 2, 3, 4, 5 };
for (int i = 0; i<nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

// задание 2
int[] grs = { 2, 1, 5, 4, 2, 3 };
int sum = 0;
for (int i = 0; i < grs.Length; i++)
{
    sum += grs[i];
}
Console.WriteLine(sum/grs.Length);

// задание 3
int[] m = { 4, 78, 213, 7, 54, 98, 0, 43 };
int max = 0;
for (int i = 0; i < m.Length; i++)
{
    if (m[i] > max)
    {
        max = m[i];
    }
}
Console.WriteLine(max);

// задание 4
string[] fruits = { "Яблоко", "Груша", "Лимон", "Апельсин", "Банан" };
foreach (string fruit in fruits)
{
    Console.WriteLine("Фрукт: " + fruit);
}

// задание 5
int[,] matrix =
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};
for (int i = 0; i < matrix.GetLength(0);i++)
{
    for (int j = 0; j<matrix.GetLength(1);j++)
    {
        if (j == 2)
        {
            Console.WriteLine(matrix[i, j]);
        }
        else
        {
            Console.Write(matrix[i, j]);
        }
    }
    
}

// задание 6
string pass = "1234";
string u_pass = "";
do
{
    Console.WriteLine("Введите пароль: ");
    u_pass = Console.ReadLine();
}
while (u_pass != pass);
