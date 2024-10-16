using ConsoleApp1;

public class Program
{
    public static void Main()
    {
        // Create the library
        Library library = new Library();

        // Create books
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234567890");
        Book book2 = new Book("1984", "George Orwell", "0987654321");

        // Add books to the library
        library.AddBook(book1);
        library.AddBook(book2);

        // Create users
        Member member = new Member("John Doe", "M001", "john@example.com");
        Librarian librarian = new Librarian("Jane Smith", "L001", "jane@example.com");

        // Librarian adds a new book
        librarian.AddBook(library, new Book("To Kill a Mockingbird", "Harper Lee", "1122334455"));

        // Member borrows a book
        member.BorrowBook(book1, library);
        member.BorrowBook(book2, library);

        // Display available books
        library.DisplayAvailableBooks();

        // Member returns a book
        member.ReturnBook(book1, library);

        // Display available books again
        library.DisplayAvailableBooks();
    }
}
