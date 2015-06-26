using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            for (int i = 0; i < array.Length; i += 2)
            {

                array[i] = (array[i] + 1) + (array[i] + 1);

                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
