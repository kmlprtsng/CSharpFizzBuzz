using NUnit.Framework;

namespace CSharpFizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzConverterTests
    {
        private FizzBuzzConverter _fizzBuzzConverter;

        [OneTimeSetUp]
        public void GivenFizzBuzzConverter()
        {
            _fizzBuzzConverter = new FizzBuzzConverter();
        }

        [Test]
        public void WhenTrue_ThenTheResultIsTrue()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
