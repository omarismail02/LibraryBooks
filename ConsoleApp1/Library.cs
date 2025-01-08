using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public class Library
    {
        private List<Book> _library = new List<Book>();

        public void AddBook(Book book)
        {
            _library.Add(book);
        }

        public List<Book> BorrowBook(string isbn)
        {

            for (int i = 0; i < _library.Count; i++)
            {
                if (_library[i].ISBN == isbn)
                {
                    if (_library[i].IsAvailable == true)
                    {
                        _library[i].IsAvailable = false;
                    }
                }
            }
            return _library;
        }

        public List<Book> ReturnBook(string isbn)
        {

            for (int i = 0; i < _library.Count; i++)
            {
                if (_library[i].ISBN == isbn)
                {
                    _library[i].IsAvailable = true;
                }
            }
            return _library;
        }

        public void DisplayBooks()
        {
            Console.WriteLine("List of books : ");
            foreach (var book in _library)
            {
                Console.WriteLine("\n\nBook's title : " + book.Title);
                Console.WriteLine("Book's Author: " + book.Author);
                Console.WriteLine("Book's ISBN : " + book.ISBN);
                Console.WriteLine("Book's availabitly  : " + book.IsAvailable);
            }
        }
    }
}
