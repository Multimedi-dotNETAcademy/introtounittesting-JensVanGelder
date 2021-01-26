using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    class DemeritPointsCalculatorTests
    {
        DemeritPointsCalculator _dpCalc;
        [SetUp]
        public void SetUp()
        {
            _dpCalc = new DemeritPointsCalculator();
        }
        [TestCase(50,0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            int result = _dpCalc.CalculateDemeritPoints(speed);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
