using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap2numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temprary;

            Console.Write("Enter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            temprary = number1;
            number1 = number2;
            number2 = temprary;

            Console.WriteLine("After Swapping : ");
            Console.Write("First Number :{0} \nSecond Number :{1}", number1, number2);

            Console.ReadLine();
        }
    }
}
