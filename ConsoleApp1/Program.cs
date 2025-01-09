using LibraryBooks;
using System;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        while (true)
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. Borrow a book");
            Console.WriteLine("3. Return a book");
            Console.WriteLine("4. Display all books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    var newBook = new Book
                    {
                        ISBN = isbn,
                        Title = title,
                        Author = author,
                        IsAvailable = true
                    };

                    library.AddBook(newBook);
                    Console.WriteLine("Book added successfully!");
                    break;
                case "2":
                    Console.Write("Enter ISBN of the book to borrow: ");
                    string borrowIsbn = Console.ReadLine();
                    library.BorrowBook(borrowIsbn);
                    break;
                case "3":
                    Console.Write("Enter ISBN of the book to return: ");
                    string returnIsbn = Console.ReadLine();
                    library.ReturnBook(returnIsbn);
                    break;
                case "4":
                    library.DisplayBooks();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
