using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Library");
            Console.WriteLine("Select an Option");
            Console.WriteLine("c. C# Books");
            Console.WriteLine("o. .Net Core Books");
            Console.WriteLine("d. Clean coding Books");
            Console.WriteLine("d. EfCore books");

            string userInput = Console.ReadLine();

            

                switch (userInput)
                {
                case "c":
                    Console.WriteLine("You have successfully borrowed C# books ");
                     break;
                case "o":
                    Console.WriteLine("You have successfully borrowed .Net Core books ");
                    break;
                case "d":
                    Console.WriteLine("You have successfully borrowed Clean coding books ");
                    break;
                case "e":
                    Console.WriteLine("You have successfully borrowed EFCore books ");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        
    }
    }
}
