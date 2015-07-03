using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            CalculateNumber(a, b, c);
        }

        static void CalculateNumber(int a, int b, int c)
        {
            Console.WriteLine("The number is: " + (a * b * c));
        }
    }
}
