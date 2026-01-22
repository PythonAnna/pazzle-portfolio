using System;
namespace Practice17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            IPlayable[] instruments =
            {
                new Guitar(),
                new Piano(),
                new Drum()
            };

            foreach (var i in instruments)
                i.Play();

            //Задание2
            TextDocument doc = new TextDocument();
            doc.Read("data.txt");
            doc.Write("data.txt", "Привет, Мир!");
            doc.Save();

            //Задание3
            IDocumntExporter[] exporters =
            {
                new TxtExporter(),
                new PdfExporter()
            };
            foreach(var e in exporters)
            {
                e.ShowInfo("Hello, World!");
                e.Export("Hello, World!");
            }
        }

        //Задание1
        public interface IPlayable
        {
            void Play();
        }

        public class Guitar: IPlayable
        {
            public void Play()
            {
                Console.WriteLine("Гитара играет аккорды");
            }
        }

        public class Piano: IPlayable
        {
            public void Play()
            {
                Console.WriteLine("Пианино играет мелодию");
            }
        }

        public class Drum : IPlayable
        {
            public void Play()
            {
                Console.WriteLine("Барабан отбивает ритм");
            }
        }

        //Задание2
        public interface IReadable
        {
            void Read(string filename);
        }

        public interface IWriteable
        {
            void Write(string filename, string content);
        }

        public interface ISavable
        {
            void Save();
        }

        public class TextDocument : IReadable, IWriteable, ISavable
        {
            private string content;
            public void Read(string filename)
            {
                Console.WriteLine($"Чтение из файла {filename}");
                content = "Текст из файла";
            }
            public void Write(string filename, string content)
            {
                Console.WriteLine($"Записть в файл {filename}: {content}");
                this.content = content;
            }
            public void Save()
            {
                Console.WriteLine($"Файл сохранен. Содержимое: {content}");
            }
        }

        //Задание3
        public interface IDocumntExporter
        {
            string FormatName { get; }
            void Export(string content);

            void ShowInfo(string content)
            {
                Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
            }
        }

        public class TxtExporter : IDocumntExporter
        {
            public string FormatName => "TXT";
            public void Export(string content)
            {
                Console.WriteLine("Создаем текстовый файл...");
            }
        }
        public class PdfExporter : IDocumntExporter
        {
            public string FormatName => "PDF";
            public void Export(string content)
            {
                Console.WriteLine("Создаем PDF-документ...");
            }
        }
    }
}