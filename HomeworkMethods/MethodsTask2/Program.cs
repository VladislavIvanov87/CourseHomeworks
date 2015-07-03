using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask2
{
    class Program
    {
        static string PrintGreetings(string name)
        {
            return ("Greetings," + " " + name + "!");
        }

        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(PrintGreetings(name));
        }
    }
}
