using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateby1wk = Dates();

            Console.WriteLine(dateby1wk);
        }

        public static string Dates()
        {
            Console.WriteLine("Input a date in this format: yyyy/mm/dd");

            string date = Console.ReadLine();

            DateTime dateValue = DateTime.Parse(date);
            dateValue = dateValue.AddDays(7);
            Console.WriteLine(dateValue.Year + "/" + dateValue.Month + "/" + dateValue.Day);

            return dateValue.ToString();
        }
       
    }
}
