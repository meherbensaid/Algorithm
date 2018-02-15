using System;
using Algorithm;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = "FizzBuzz";

        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
                _fizzBuzz=new FizzBuzz();
        }

        [Test]
        public void Should_Return_Fizz_If_Number_Is_Multiple_Of_3()
        {
            var number = 3;

            var actual = _fizzBuzz.Check(number);

            Assert.AreEqual(Fizz,actual);
        }

        [Test]
        public void Should_Return_Fizz_If_Number_Is_Multiple_Of_5()
        {
            //arrange
            var number = 5;

            //actual
            var actual = _fizzBuzz.Check(number);

            //assert
            Assert.AreEqual(Buzz, actual);
        }

        [Test]
        public void Should_Return_FizzBuzz_If_Number_Is_Multiple_Of_3_and_5()
        {
            var number = 15;

            var actual = _fizzBuzz.Check(number);

            Assert.AreEqual(FizzBuzz,actual);
        }

        [Test]
        public void Should_Return_Number_If_Number_Is_Not_Divisible_By_3_or_5()
        {
            var expected = "7";

            var actual = _fizzBuzz.Check(7);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Throw_Expection_If_Number_Is_Lower_than_1()
        {
            try
            {
                _fizzBuzz.Check(-1);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.IsTrue(e.Message.Equals("value should be greater than 1"));
            }
        }

        [Test]
        public void Throw_Expection_If_Number_Is_Greater_than_100()
        {
            try
            {
                _fizzBuzz.Check(101);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.IsTrue(e.Message.Equals("value should be lower than 101"));
            }
        }

    }
}
