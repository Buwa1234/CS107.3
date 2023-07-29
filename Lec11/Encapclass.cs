using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec11.Properties
{
    internal class Encapclass
    {
        private int num1,num2,sum;
        public void setnum1(int num1FormUser)
        {
            num1 = num1FormUser;
        }
        public void setnum2(int num2FormUser)
        {
            num2 = num2FormUser;
        }
        public int getnum1()
        {
            return num1;
        }
        public int getnum2()
        {
            return num2;
        }
    }
}
