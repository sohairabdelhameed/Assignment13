using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13.Book
{
    public class BookFunctions
    {
        public string GetISBN(Book book)
        {
            return book.ISBN;
        }

        public DateTime GetPublicationDate(Book book)
        {
            return book.PublicationDate;
        }


    }
}
