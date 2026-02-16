using System;
using System.Linq;

namespace Practice21
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            int[] nums = { -3, -1, 0, 2, 4, 5, 6, 10, 12 };
            int[] new_nums = { };
            var num =
                from n in nums
                where n > 0 && n % 2 == 0
                select n;
            //foreach (var i in num)
            //{
            //    Console.WriteLine(i * i);
            //    int sum = 0;
            //    int count = 0;
            //    sum += i;

            //}
            //Задание2

            //Задание3
            //Задание4
            //Задание5
        }
    }
}