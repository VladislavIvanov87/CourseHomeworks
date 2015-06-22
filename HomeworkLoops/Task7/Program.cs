using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int k = 3;

            long factorial1 = 1;
            long factorial2 = 1;


            for (int i = 1; i <= n; i++)
            {
                factorial1 *= i;
                Console.WriteLine(factorial1 + " ");
            }

            for (int i = 1; i <= k; i++)
            {
                factorial2 *= i;
                Console.WriteLine(factorial2 + " ");
            }

            Console.WriteLine((factorial1 * factorial2) / (factorial1 - factorial2));
            Console.WriteLine();
        }
    }
}
