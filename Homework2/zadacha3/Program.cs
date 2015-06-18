using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a symbol that represents valid card");

            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":

                    Console.WriteLine("valid card");
                    break;
                    default:
                    Console.WriteLine("invalid card");
                    break;

            }
        }
    }
}
