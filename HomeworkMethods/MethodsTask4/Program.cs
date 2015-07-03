using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask4
{
    class Program
    {
        static void PrintNumber(int number)
        {

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }

            else
            {
                Console.WriteLine("The number is odd");
            }
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            PrintNumber(number);
        }
    }
}
