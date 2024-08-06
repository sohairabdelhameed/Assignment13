using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13.Book
{
    public class Book
    {

        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        #endregion

        #region Constructor
        public Book(string title, string author, string isbn, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
        } 
        #endregion
    }
}
