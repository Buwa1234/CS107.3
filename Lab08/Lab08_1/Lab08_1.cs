using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double radius = double.Parse(Console.ReadLine());

            FindValues ObjFindValues = new FindValues();
             double A = ObjFindValues.FindArea(radius);

            Console.WriteLine("Area = " + A );

            double C = ObjFindValues.FindCircumference(radius);

            Console.WriteLine("Circumference = " + C);

            Console.ReadKey();
        }
    }
}