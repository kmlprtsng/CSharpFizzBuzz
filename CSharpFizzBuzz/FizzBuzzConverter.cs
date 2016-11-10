namespace CSharpFizzBuzz
{
    public class FizzBuzzConverter
    {
        public string Convert(int number)
        {
            var convertedString = "";

            if (number%3 == 0)
                convertedString = "Fizz";

            if (number%5 == 0)
                convertedString += "Buzz";

            return string.IsNullOrEmpty(convertedString) ? number.ToString() : convertedString;
        }
    }
}