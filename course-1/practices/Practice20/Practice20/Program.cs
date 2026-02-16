using System;
using System.IO;
using System.Threading.Tasks;

namespace Practice20
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Задание1

            //Задание2
            var data = @"C:\data";
            if (!Directory.Exists(data)) 
            {
                Directory.CreateDirectory(data);
            }
            FileStream f1 = File.Create("1.txt");
            FileStream f2 = File.Create("2.txt");
            FileStream f3 = File.Create("3.txt");
            FileStream[] files = data.GetFiles();


            //Задание3
        }
    }
}