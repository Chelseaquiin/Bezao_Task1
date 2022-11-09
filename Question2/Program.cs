using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();


            List<int> index = new List<int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] >= 'A' && sentence[i] <= 'Z')
                {
                    index.Add(i);
                }
            }

            foreach (int i in index)
            {
                Console.WriteLine("Index: " + i + " " + "Value:" +  sentence[i]);
            }


        }



        
    }
}
