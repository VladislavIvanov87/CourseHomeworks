using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            for (int i = 1; i <= n; i++)
            {
                if ((i % 7 == 0) || (i % 11 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
