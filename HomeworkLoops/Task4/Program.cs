using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 1 && (i % 7) == 1))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
