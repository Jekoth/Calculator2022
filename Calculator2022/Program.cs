using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Which symbol: +, -, / or * ?");
            string which = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Second number");
            double second = Convert.ToDouble(Console.ReadLine());

            if (which == "+")
            {
                Console.WriteLine("Summary: " + (first + second));
            }
            else if (which == "-")
            {
                Console.WriteLine("Difference: " + (first - second));
            }
            else if (which == "/")
            {
                Console.WriteLine("Division: " + (first / second));
            }
            else if (which == "*")
            {
                Console.WriteLine("Times: " + (first * second));
            }
            else
            {
                Console.WriteLine("Error 404?");
            }

            Console.WriteLine("Want to do another operations? y/n");
            string O = Console.ReadLine();
            // Restart
            if (O == "y")
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
            }
            // Finish
            if (O == "n")
            {
                Console.WriteLine("Enter a key to close");
                Console.ReadKey();
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

        public static double Division(double first, double second)
        {
            return first / second;
        }

        public static int Times(int first, int second)
        {
            return first * second;
        }
    }
}
