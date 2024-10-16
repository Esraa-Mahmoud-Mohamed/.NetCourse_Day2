using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void DisplayAvailableBooks()
        {
            var availableBooks = Books.Where(b => b.IsAvailable);
            if (availableBooks.Any())
            {
                Console.WriteLine("Available books:");
                foreach (var book in availableBooks)
                {
                    Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN})");
                }
            }
            else
            {
                Console.WriteLine("No books are available.");
            }
        }

        public Book FindBookByISBN(string isbn)
        {
            return Books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public void HandleBorrow(LibraryUser user, Book book)
        {
            user.BorrowBook(book, this);
        }

        public void HandleReturn(LibraryUser user, Book book)
        {
            user.ReturnBook(book, this);
        }
    }

}
