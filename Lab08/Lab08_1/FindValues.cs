using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_1
{
    internal class FindValues
    {
        public double FindArea(double radius)
        {
            double A = 3.142 * radius * radius;
            return A;
        }
        public double FindCircumference(double radius)
        {
            double C = 2 * 3.142 * radius;
            return C;
        }
    }
}
