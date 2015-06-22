using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int n = int.Parse(Console.ReadLine());

            while (counter <= n)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
