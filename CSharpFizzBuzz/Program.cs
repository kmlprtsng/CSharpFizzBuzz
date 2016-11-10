using System;

namespace CSharpFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new FizzBuzzConverter();
            
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(converter.Convert(i));
            }

        }
    }
}
