using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    internal class HtmlFormatterTests
    {
        private HtmlFormatter htmlFormat;
        private string testText;

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
            Assert.AreEqual($"<strong>{testText}</strong>", result);
        }
    }
}