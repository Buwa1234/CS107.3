using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Lab04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, a, c;
            Console.WriteLine("Enter the radius of the circle:");
            r = Convert.ToDouble(Console.ReadLine());
            a = 3.14 * r * r;
            c = 2 * 3.14 * r;
            Console.WriteLine("The area of the circle is: " + a);
            Console.WriteLine("The circumference of the circle is: " + c);
            Console.ReadLine();

            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("It is an Even number.");
            }
            else
            {
                Console.WriteLine("It is an Odd number.");
            }
            Console.ReadLine();
        }
    }
}
