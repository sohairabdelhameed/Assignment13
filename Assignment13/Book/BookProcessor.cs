using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13.Book
{
    public class BookProcessor
    {
        // Custom delegate type for a method that takes a Book object and returns a string (ISBN)
        public delegate string BookISBNDelegate(Book book);

        // Custom delegate type for a method that takes a Book object and returns a DateTime (Publication Date)
        public delegate DateTime BookDateDelegate(Book book);

        // Method that processes a list of books using custom delegates for getting ISBN and publication date
        public void ProcessBooks(List<Book> books, BookISBNDelegate isbnDelegate, BookDateDelegate dateDelegate)
        {
            foreach (var book in books)
            {
                // Invoke the delegate to get the ISBN of the book
                string isbn = isbnDelegate(book);
                // Invoke the delegate to get the publication date of the book
                DateTime publicationDate = dateDelegate(book);
                // Print the ISBN and publication date of the book
                Console.WriteLine($"ISBN: {isbn}, Publication Date: {publicationDate.ToShortDateString()}");
            }
        }

        // Method that processes a list of books using built-in Func delegates for getting ISBN and publication date
        public void ProcessBooksBuiltIn(List<Book> books, Func<Book, string> isbnFunc, Func<Book, DateTime> dateFunc)
        {
            foreach (var book in books)
            {
                // Invoke the Func delegate to get the ISBN of the book
                string isbn = isbnFunc(book);
                // Invoke the Func delegate to get the publication date of the book
                DateTime publicationDate = dateFunc(book);
                // Print the ISBN and publication date of the book
                Console.WriteLine($"ISBN: {isbn}, Publication Date: {publicationDate.ToShortDateString()}");
            }
        }
    }
}
