using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Fibonacci
    {
        public static int DoFiconacci(int value)
        {
            if (value == 1) return 1;
            if (value == 0) return 0;
            else
            {
                return DoFiconacci(value - 1) + DoFiconacci(value - 2);
            }
        }

        public static void Main()
        {
            var result=Fibonacci.DoFiconacci(20);
        }
    }
}
