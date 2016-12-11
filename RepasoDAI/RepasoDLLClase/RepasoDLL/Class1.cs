using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDLL
{
    public class Class1
    {
        private int num = 10;
        private int num2 = 20;

        public void setNum(int numN)
        {
            num = numN;
        }

        public void setNum2(int numN2)
        {
            num2 = numN2;
        }

        public int mult()
        {
            return num * num2;
        }
    }
}
