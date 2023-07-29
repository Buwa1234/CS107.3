using Lab_07.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter km value: ");
            double km = double.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            double m = obj.kmTOm(km);
            Console.WriteLine(m.ToString());

            Console.ReadKey();
        }
    }
}


namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter km value: ");
            double km = double.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            double m = obj.kmTOm(km);
            Console.WriteLine(m.ToString());

            Console.ReadKey();
        }
    }
}
