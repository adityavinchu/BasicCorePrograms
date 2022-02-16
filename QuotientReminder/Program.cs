using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotientReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend, divisor;
            Console.Write("Enter dividend:");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());


            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.Write("----------------------------------");
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
