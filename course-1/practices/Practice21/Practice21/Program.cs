using System;
using System.Text.Json;
using System.IO;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace Practice21
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            var books = new List<Book>
            {
                new Book{Title="Война и мир", Author="Толстой", Year=1869},
                new Book{Title="Преступление и наказание", Author="Достоевский", Year=1866}
            };

            string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("books.json", json);

            string jsonFromFile = File.ReadAllText("books.json");
            var booksFromFile = JsonSerializer.Deserialize<List<Book>>(jsonFromFile);

            foreach (var book in booksFromFile)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
            }

            var book_options = new JsonSerializerOptions { WriteIndented = true };
            string json2 = JsonSerializer.Serialize(books, book_options);
            File.WriteAllText("books2.json", json2);

            //Задание 2
            var library = new Library
            {
                Name = "Городская библиотека",
                Books = new List<Book>
                {
                   new Book{Title="Война и мир", Author="Толстой", Year=1869},
                   new Book{Title="Преступление и наказание", Author="Достоевский", Year=1866}
                }
            };

            var library_options = new JsonSerializerOptions { WriteIndented = true };
            string library_json = JsonSerializer.Serialize(library, library_options);
            File.WriteAllText("library.json", library_json);

            string lib_jsonFromFile = File.ReadAllText("library.json");
            var libraryFromFile = JsonSerializer.Deserialize<Library>(lib_jsonFromFile);

            Console.WriteLine($"Библиотека: {libraryFromFile.Name}");
            foreach(var b in libraryFromFile.Books)
            {
                Console.WriteLine($"Книга: \"{b.Title}\", автор: {b.Author}, год: {b.Year}");
            }
        }
    }

}