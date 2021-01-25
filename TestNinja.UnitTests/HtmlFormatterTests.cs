using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    class HtmlFormatterTests
    {
        HtmlFormatter htmlFormat;
        string testText;
        [SetUp]
        public void SetUp()
        {
            htmlFormat = new HtmlFormatter();
            testText = "boldAub";
        }

        [Test]
        public void FormatAsBold_WhenCalled_ReturnStringAsStrong()
        {
            string result = htmlFormat.FormatAsBold(testText);
            Assert.AreEqual($"<strong>{testText}</strong>",result);
        }
    }
}
