using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; } = true;  // Default is true when the book is added

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"{Title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available.");
            }
        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"{Title} has been returned.");
        }
    }

}
