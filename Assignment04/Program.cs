using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            float num = float.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            string oe = (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + oe);
            Console.ReadKey();
        }
    }
}
