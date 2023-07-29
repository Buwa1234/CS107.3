using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 1 for Addition");
            Console.WriteLine(" Enter 2 for Substraction");
            Console.WriteLine(" Enter 3 for Multiplication");
            Console.WriteLine(" Enter 4 for Division");

            Console.WriteLine("Enter your choice:");

            string input = Console.ReadLine();

            Console.WriteLine("Enter number 1:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            double num2 = double.Parse(Console.ReadLine());

            CalculatorValues obj = new CalculatorValues();

            double answer = 0;

            if (input =="1")
            {
                answer = obj.sum(num1, num2);
            }
            else if(input == "2")
            {
                answer = obj.sub(num1, num2);
            }
            else if (input == "3")
            {
                answer = obj.multi(num1, num2);
            }
            else if (input == "4")
            {
                answer = obj.div(num1, num2);
            }
            Console.WriteLine("Answer is " + answer);
        }
    }
}

    

