using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Member : LibraryUser
    {
        private const int MaxBooks = 3;
        private List<Book> borrowedBooks = new List<Book>();

        public Member(string name, string membershipId, string email)
            : base(name, membershipId, email) { }

        public override void BorrowBook(Book book, Library library)
        {
            if (borrowedBooks.Count >= MaxBooks)
            {
                Console.WriteLine($"{Name} has reached the borrowing limit.");
            }
            else if (book.IsAvailable)
            {
                borrowedBooks.Add(book);
                book.BorrowBook();
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
            }
        }

        public override void ReturnBook(Book book, Library library)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                book.ReturnBook();
            }
            else
            {
                Console.WriteLine($"{Name} did not borrow {book.Title}.");
            }
        }
    }

}
