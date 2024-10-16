using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class LibraryUser
    {
        public string Name { get; set; }
        public string MembershipID { get; set; }
        public string Email { get; set; }

        public LibraryUser(string name, string membershipId, string email)
        {
            Name = name;
            MembershipID = membershipId;
            Email = email;
        }

        public abstract void BorrowBook(Book book, Library library);

        public abstract void ReturnBook(Book book, Library library);
    }

}
