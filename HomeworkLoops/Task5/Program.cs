using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter 5 numbers: ");
            int biggest = 0;
            int smallest = 0;

            for (int i = 1; i <= 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i == 1)
	{
        biggest = number;
        smallest = number;
	}
                else
                {
                    if (number > biggest)
                    {
                        biggest = number;
                    }
                    else if (number < smallest)
                    {
                        smallest = number;
                    }

                    Console.WriteLine("Biggest: {0}, Smallest: {1}", biggest, smallest);
                }
            }


        }
    }
}
