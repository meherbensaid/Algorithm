using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Fibonacci
    {
        public Fibonacci()
        {
                
        }
        public int DoFiconacci(int value)
        {
            if (value == 1) return 1;
            if (value == 0) return 0;
            else
            {
                return DoFiconacci(value - 1) + DoFiconacci(value - 2);
            }
        }

        public int DoFibonacciIterative(int value)
        {
            var Fib = new int [value+1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= value; i++)
            {

                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }

            return Fib[value];

        }

        
    }
}
