using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVladislavIvanov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number wich will be the length of a matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int[] array = new int[n * n];

            if (n >= 2 && n <= 9)
            
            {
                Console.WriteLine("Enter {0} numbers to fill the array: ", n * n);
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;

                foreach (int item in array)
                {
                    sum += item;
                }

                Console.WriteLine("The sum of all elements is {0}", sum);
            }

            else
            {
                Console.WriteLine("incorrect number");
                return;
            }


            Console.WriteLine();
            Console.WriteLine("Enter numbers to fill the matrix: ");
            
            int c = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[c++];
                }
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write(" " + matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}