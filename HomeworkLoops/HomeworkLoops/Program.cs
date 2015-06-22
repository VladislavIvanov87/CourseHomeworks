using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = (a + b);

            while (a > 0 && b > 0)
            {
                Console.WriteLine(result);

                if ((a == 0) || (b == 0))
                {
                    break;
                }
            }
        }
    }
}
