using System;
namespace Practice18
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Textbook t1 = new Textbook("Математика 101", "Иванов", 2020, 300, "Математика");
            FictionBook f1 = new FictionBook("Война и мир", "Толстой", 1869, 1200, "Роман");
            Book b1 = new Book("Маленький принц", "Антуан де Сент-Экзюпери", 1943, 96);

            library.AddBook(t1);
            library.AddBook(f1);
            library.ListBooks();

            Reader reader = new Reader("Алексей", 1);

            library.IssueBook(t1, reader);
            reader.ShowBorrowedBooks();

            library.ListBooks();

            library.ReturnBook(t1);
            library.ListBooks();

            Publication pub = new BookPublication(f1);
            pub.GetInfo();

            Reservation res = new Reservation(b1, DateTime.Now, 5);
            
            library.NewReservation(res);
            library.CancelReservation(res);
        }
    }
}