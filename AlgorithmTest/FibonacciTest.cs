using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]    
    public class FibonacciTest
    {
        private Fibonacci _fibonacci;

        [SetUp]
        public void SetUp()
        {
            _fibonacci=new Fibonacci();
        }

        [Test]
        public void Should_Return_0_When_The_Number_Is_Equal_To_0()
        {
            var number = 0;
            var expected = 0;
            
            var actual = _fibonacci.DoFiconacci(number);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Return_1_When_The_Number_Is_Equal_To_1()
        {
            var number = 1;
            var expected = 1;

            var actual = _fibonacci.DoFiconacci(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Return_Fibonacci_Number()
        {
            var number = 20;
            var expected = 6765;

            var actual = _fibonacci.DoFiconacci(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Return_Iterative_Fibonacci_Number()
        {
            var number = 20;
            var expected = 6765;


            var actual = _fibonacci.DoFibonacciIterative(number);

            Assert.AreEqual(expected, actual);
        }

    }
}
