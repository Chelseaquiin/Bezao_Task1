using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's Look at an example of the break keyword");

            for(int i = 0; i < 10; i++)
            {

                if(i == 5)
                {
                    break;
                }

                Console.WriteLine(i);   
                
            }
            Console.WriteLine("Let's Look at an example of the continue keyword");

            for (int i = 0; i < 10; i++)
            {

                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);

            }
        }
    }
}
