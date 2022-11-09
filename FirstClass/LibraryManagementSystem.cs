using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class LibraryManagementSystem
    {
         private List<Books> bookLists { get; set; } = new List<Books>();


        public void AddABook(Books book)
        {
            bookLists.Add(book);
        }

        public void ViewAllBooks()
        {
            foreach (Books book in bookLists)
            {
                Console.WriteLine(book.BookName);
            }
        }
    }
}
