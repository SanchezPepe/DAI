using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        private int num1 = 0;
        private int num2 = 0;

        public void setNum1(int num)
        {
            num1 = num;
        }

        public void setNum2(int num)
        {
            num2 = num;
        }

        public int suma()
        {
            return num1 + num2;
        }
    }
}
