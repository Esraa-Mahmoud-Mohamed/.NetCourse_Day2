using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Librarian : LibraryUser
    {
        public Librarian(string name, string membershipId, string email)
            : base(name, membershipId, email) { }

        public void AddBook(Library library, Book book)
        {
            library.AddBook(book);
            Console.WriteLine($"{book.Title} has been added to the library.");
        }

        public override void BorrowBook(Book book, Library library)
        {
            if (book.IsAvailable)
            {
                book.BorrowBook();
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
            }
        }

        public override void ReturnBook(Book book, Library library)
        {
            book.ReturnBook();
        }
    }

}
