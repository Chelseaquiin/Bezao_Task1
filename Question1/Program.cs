using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            
            string word = Console.ReadLine();

            if (word.Length >= 4)
            {
                string last4Letters = word.Substring(word.Length - 4);

                string newWord = new String('#', word.Length - 4) + last4Letters;

                Console.WriteLine(newWord);
            }

            else
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
