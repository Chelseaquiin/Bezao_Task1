using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Library Management System");
            Console.WriteLine("Select An Option");
            Console.WriteLine("1. View All Books");
            Console.WriteLine("2. Exit");
           

            int userInput = Convert.ToInt32(Console.ReadLine());

            LibraryManagementSystem library = new LibraryManagementSystem();

 

            switch (userInput)
            {
                case 1:
                   
                    Console.WriteLine("Book");

                    string bookName = Console.ReadLine();

                    Books newBook = new Books(bookName);

                    library.AddABook(newBook);
                    break;
                case 2:
                    library.ViewAllBooks();
                    break;
                case 3:
                    return;
                case 4:
                    break;
                default:
                    Console.WriteLine("Select A Valid Option");
                    break;
                 
            }

            Console.WriteLine("Please Select An Option");
            userInput = Convert.ToInt32(Console.ReadLine());

        }      
    }
}
