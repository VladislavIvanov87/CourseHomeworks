using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your result here: ");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt >= 1 && numInt <= 9)
            {
                if (numInt >= 1 && numInt <= 3)
                {
                    Console.WriteLine(numInt * 5);
                }

                else if (numInt >= 4 && numInt <= 6)
                {
                    Console.WriteLine(numInt * 10);
                }

                else if (numInt >= 7 && numInt <= 9)
                {
                    Console.WriteLine(numInt * 50);
                }
            }

                else
                {
                    Console.WriteLine("Invalid result");
                }
        }
    }
}
