using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class FizzBuzz
    {
        public Boolean DivisibleBy3(int value)
        {
            return value % 3 == 0;
        }

        public Boolean DivisibleBy5(int value)
        {
            return value % 5 == 0;
        }

       
        public  string Check(int value)
        {
            ThrowExceptionIfValueIsOutOfRung(value);
            if (DivisibleBy3(value) && DivisibleBy5(value)) return "FizzBuzz";
            if (DivisibleBy3(value)) return "Fizz";
            if (DivisibleBy5(value)) return "Buzz";
           
            return $"{value}";
        }

        public void Display(int max)
        {
            for (int i = -1; i <= max; i++)
            {
                Console.WriteLine(Check(i));
            }
        }

        public void ThrowExceptionIfValueIsOutOfRung(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("value should be greater than 1", nameof(value));
            }

            if (value > 100)
            {
                throw new ArgumentException("value should be lower than 100", nameof(value));
            }
        }

        public static void Main()
        {
            FizzBuzz fb=new FizzBuzz();
            fb.Display(100);
        }
    }
}
