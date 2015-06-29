using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]{

            {30, 29, 28, 27, 26, 25},
            {24, 23, 22, 21, 20, 19},
            {18, 17, 16, 15, 14, 13},
            {12, 11, 10,  9,  8,  7,},
            { 6, 5, 4, 3, 2,  1}
        };
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
