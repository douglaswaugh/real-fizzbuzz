using System.Linq;

namespace fizzbuzz
{    
    public class FizzBuzz
    {
        public string Generate(int lowerBound, int upperBound)
        {
            if (lowerBound <= 0)
                return string.Empty;

            if (upperBound < lowerBound)
                return string.Empty;

            return Enumerable.Range(lowerBound, (upperBound - lowerBound) + 1)
                .Select(number => ConvertNumberToWord(number))
                .Aggregate((fizzBuzz, word) => fizzBuzz + " " + word)
                .TrimEnd();
        }

        private string ConvertNumberToWord(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
                return "fizzbuzz";

            if (number % 5 == 0)
                return "buzz";

            if (number % 3 == 0)
                return "fizz";

            return number.ToString();
        }
    }
}
