using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    internal class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            // ARRANGE / GIVEN
            int numA = 5;
            int numB = 7;

            // ACT / WHEN
            int result = _math.Add(numA, numB);
            // ASSERT / THEN
            Assert.AreEqual(12, result);
        }

        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(4, 4, 4)]
        public void Max_WhenCalled_ReturnsLargerNumber(int numA, int numB, int expectedResult)
        {
            int result = _math.Max(numA, numB);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void GetOddNumbers_WhenGivenLimitHigherThanZero_ReturnOddNumbersArray()
        {
            var expectedResult = new[] { 1, 3, 5 };
            IEnumerable<int> result = _math.GetOddNumbers(5);

            Assert.NotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual(expectedResult, result);
        }
    }
}