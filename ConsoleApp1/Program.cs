using LibraryBooks;
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var book1 = new Book();
            book1.ISBN = "First";
            book1.Title = "title of book 1 ";
            book1.Author = "Author of book 1";
            book1.IsAvailable = true;

            var book2 = new Book();
            book2.ISBN = "Two";
            book2.Title = "title of book 2 ";
            book2.Author = "Author of book 2";
            book2.IsAvailable = true;

            library.AddBook(book1);
            library.BorrowBook("First");
            library.ReturnBook("First");

            library.AddBook(book2);
            library.BorrowBook("Two");
            library.DisplayBooks();
        }
    }
}
