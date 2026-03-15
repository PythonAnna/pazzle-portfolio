using System;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;

namespace Practice22
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            int[] nums = { -3, -1, 0, 2, 4, 5, 6, 10, 12 };
            var new_nums = nums
                .Where(n => n > 0 && n % 2 == 0);
            var numsSquare = new_nums
                .Select(n => n * n);
            var numsSum = new_nums
                .Sum(n => n);
            var numsCount = new_nums.Count();
            var numsAvg = new_nums
                .Average(n => n);
            Console.WriteLine("Числа: "+string.Join(",", new_nums));
            Console.WriteLine("Квадраты чисел: "+string.Join(",", numsSquare));
            Console.WriteLine("Сумма чисел: "+numsSum);
            Console.WriteLine("Количество чисел: "+numsCount);
            Console.WriteLine("Среднее значение: "+numsAvg);

            //Задание2
            var words = new List<string>
            {
                "апельсин","Арбуз","ананас","банан","груша","Авокадо","арбуз"
            };

            var result = words
                .Where(w => w.StartsWith("а", StringComparison.OrdinalIgnoreCase))
                .Select(w => w.ToUpperInvariant())
                .Distinct()
                .OrderBy(w => w.Length)
                .ThenBy(w => w);

            Console.WriteLine(string.Join(",", result));

            //Задание3
            var students = new List<Student>
            {
                new("Вика",4),
                new("Аня",5),
                new("Борис",3),
                new("Гена",4),
                new("Дана",5)
            };

            var goodStudants = students
                .Where(s => s.Grade >= 4)
                .Select(s => s.Name)
                .OrderBy(s => s);
            Console.WriteLine(string.Join(",", goodStudants));
            bool anyBad = students.Any(s => s.Grade < 3);
            if (anyBad)
                Console.WriteLine("В классе есть двоечники");
            else
                Console.WriteLine("В классе нет плохих учеников");

            //Задание4
            var dates = new List<Dates>
            {
                new(2025,1,10),
                new(2025,1,25),
                new(2025,2,3),
                new(2025,2,28),
                new(2025,2,15),
                new(2025,3,1)
            };

            var maxDates = dates
                .GroupBy(d => d.Month)
                .Select(g => g.Max(d=>d.Day));
            var minDates = dates
                .GroupBy(d => d.Month)
                .Select(g => g.Min(d=>d.Day));
            Console.WriteLine(string.Join(",", maxDates));
            Console.WriteLine(string.Join(",", minDates));

            //Задание7
            var studentsClub = new[]
            {
                new StudentClub("Аня", "Робототехника"),
                new StudentClub("Борис", "Шахматы"),
                new StudentClub("Вика", "Театр"),
                new StudentClub("Гена", "Шахматы"),
                new StudentClub("Дана", "Дебаты")
            };

            var clubs = new[]
            {
                new ClubInfo("Шахматы", "Ауд.203"),
                new ClubInfo("Робототехника", "Ауд.105"),
                new ClubInfo("Театр", "Сцена 1"),
                new ClubInfo("Дебаты", "Ауд.211")
            };

            var members = studentsClub.Join(
                inner: clubs,
                outerKeySelector: s=>s.Club,
                innerKeySelector: c=>c.Club,
                resultSelector: (s, c) => new
                {
                    s.Name,
                    Club = c.Club,
                    c.Room
                });
            Console.WriteLine(string.Join("\n", members));
        }
        record class StudentClub(string Name, string Club);
        record class ClubInfo(string Club, string Room);
    }
}