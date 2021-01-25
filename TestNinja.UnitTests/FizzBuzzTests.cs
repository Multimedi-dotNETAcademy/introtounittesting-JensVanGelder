using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    class FizzBuzzTests
    {

        [TestCase(7,"7")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(14, "14")]
        public void GetOutput_WhenCalled_ReturnNeededFizzBuzzString(int number, string expectedResult)
        {
            string result = FizzBuzz.GetOutput(number);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
