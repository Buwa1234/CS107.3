using Lec11.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapclass ec = new Encapclass();
            ec.setnum1(2);
            ec.setnum2(3);
            Console.WriteLine("The sum is " + (ec.getnum1() +ec.getnum2()));

            Console.ReadLine();
        }
    }
}
