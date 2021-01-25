using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    internal class DateHelperTests
    {
        [TestCase("22/02/2021","1/03/2021")]
        [TestCase("22/12/2021", "1/01/2022")]
        public void FirstOfNextMonth_WhenCalled_ReturnDateTimeFirstNextMonth(string date, string resultDate)
        {
            DateTime testDate = DateTime.Parse(date);
            DateTime expectedResult = DateTime.Parse(resultDate);
            DateTime result = DateHelper.FirstOfNextMonth(testDate);
            Assert.AreEqual(result, expectedResult);
        }
    }
}