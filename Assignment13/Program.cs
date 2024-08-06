using Assignment13.CustomLists;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            #region Part01

            //    var bookFunctions = new BookFunctions();
            //    List<Book> books = new List<Book>
            //    {
            //    new Book("Title1", "Author1", "ISBN1", new DateTime(2024, 8, 8)),
            //    new Book("Title2", "Author2", "ISBN2", new DateTime(2024, 8, 2))
            //    };

            //    BookProcessor processor = new BookProcessor();

            //    // Using anonymous method for GetISBN and method group for GetPublicationDate
            //    processor.ProcessBooks(books,
            //        delegate (Book book) { return bookFunctions.GetISBN(book); },
            //        bookFunctions.GetPublicationDate);

            //    // Using lambda expressions
            //    processor.ProcessBooks(books,
            //        book => bookFunctions.GetISBN(book),
            //        book => bookFunctions.GetPublicationDate(book));


            #endregion

            #region Part02
            //We need to Implement the List methods from scratch with all overloads.
            //Exist
            //Find
            //Find All
            //Find index
            //Find Last
            //Find Last Index
            //Foreach
            //TrueForAll
           
            CustomList<int> numbers = new CustomList<int> { 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Using ForEach to print each element in the list");
            numbers.ForEach(x => Console.Write(x + " ")); // 1 2 3 4 5
            Console.WriteLine();
           
            Console.WriteLine("Does 3 exist in the list?");
            Console.WriteLine(numbers.Exists(x => x == 3)); // True

            Console.WriteLine("Find the first number greater than 2?");
            Console.WriteLine(numbers.Find(x => x > 2)); // 3

            Console.WriteLine("Find all the numbers greater than 2?");
            var allGreaterThanTwo = numbers.FindAll(x => x > 2);
            allGreaterThanTwo.ForEach(x => Console.Write(x + " ")); // 3 4 5
            Console.WriteLine();

            Console.WriteLine("Find The Index of 3 in the List?");
            Console.WriteLine(numbers.FindIndex(x => x == 3)); // 2

            Console.WriteLine("Find The Last Number less than 5?");
            Console.WriteLine(numbers.FindLast(x => x < 5)); // 4

            Console.WriteLine("Find the Index of the Last Number less than 5?");
            Console.WriteLine(numbers.FindLastIndex(x => x < 5)); // 3

            

            Console.WriteLine("Is all the Numbers in the List less than 6?");
            Console.WriteLine(numbers.TrueForAll(x => x < 6)); // True
        

        #endregion

        }

    }


    
}
