using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("Enter number " + i + ":");
                number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("It is an even number.");
                }
                else
                {
                    Console.WriteLine("It is an odd number.");
                }
            }
            Console.ReadLine();
        }
    }
}
