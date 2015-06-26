using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int Previous = -1;
            int Next = 1;

            for (int i = 0; i < array.Length; i++)
            {
                int Sum = Next + Previous;
                Previous = Next;
                Next = Sum;

                Console.WriteLine(Sum);
            }
        }
    }
}
