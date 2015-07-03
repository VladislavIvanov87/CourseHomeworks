using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethods
{
    class Program
    {

        static int PrintMaxNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        static void Main()
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.Write("The biggest number is: {0}", PrintMaxNumber(PrintMaxNumber(number1, number2), number3));
            Console.WriteLine();
        }
    }
}


