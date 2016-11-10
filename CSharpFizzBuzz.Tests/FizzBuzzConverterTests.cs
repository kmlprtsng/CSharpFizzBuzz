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
        public void WhenNumberIsNotDivisibleBy3And5_ThenTheNumberIsReturnedAsIs()
        {
            Assert.That(_fizzBuzzConverter.Convert(1), Is.EqualTo("1"));
            Assert.That(_fizzBuzzConverter.Convert(2), Is.EqualTo("2"));
        }

        [Test]
        public void WhenNumberIsDivisibleBy3_ThenFizzIsReturned()
        {
            Assert.That(_fizzBuzzConverter.Convert(3), Is.EqualTo("Fizz"));
            Assert.That(_fizzBuzzConverter.Convert(6), Is.EqualTo("Fizz"));
        }
        
        [Test]
        public void WhenNumberIsDivisibleBy5_ThenBuzzIsReturned()
        {
            Assert.That(_fizzBuzzConverter.Convert(5), Is.EqualTo("Buzz"));
            Assert.That(_fizzBuzzConverter.Convert(10), Is.EqualTo("Buzz"));
        }
        
        [Test]
        public void WhenNumberIsDivisibleByBoth3And5_ThenFizzBuzzIsReturned()
        {
            Assert.That(_fizzBuzzConverter.Convert(15), Is.EqualTo("FizzBuzz"));
            Assert.That(_fizzBuzzConverter.Convert(30), Is.EqualTo("FizzBuzz"));
        }
    }
}
