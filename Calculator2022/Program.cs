using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which is printed: +, -, * or /?");
            string which = Console.ReadLine();
            Console.WriteLine("\n");

            if (which == "+")
            {
                Console.WriteLine("Sum: " + (first + second));
            }
            else if (which == "-")
            {
                Console.WriteLine("Difference: " + (first - second));
            }
        }

        public static int Summary(int first, int second)
        {
            return first + second;
        }

        public static int Difference(int first, int second)
        {
            return first - second;
        }
    }
}
