using System;
using System.collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ObjStudent = new Student();
            ObjStudent.MyMethod();
            ObjStudent.MyInfo();

            Console.ReadKey();
        }
    }

}