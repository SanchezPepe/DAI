using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL1
{
    public class Class1
    {

        public static String mayus(String s)
        {
            return s.ToUpper();
        }

        public static Char[] mandaArray(String s)
        {
            return mayus(s).ToCharArray();
        }
    }
}
