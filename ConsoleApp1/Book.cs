using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    
    public class Book : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public void Borrow()
        {
            Console.WriteLine("Borrowing...");
        }

        public void Return()
        {
            Console.WriteLine("Returning...");
        }
    }
}
