using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public string Generate(int lowerBound, int upperBound)
        {
            if (lowerBound <= 0)
                return string.Empty;

            if (upperBound < lowerBound)
                return string.Empty;

            var words = Enumerable.Range(lowerBound, (upperBound - lowerBound) + 1)
                .Select(number => ConvertNumberToWord(number));

            return BuildFizzBuzzView(words) + " " + BuildReportView(words);
        }

        private string BuildFizzBuzzView(IEnumerable<string> words)
        {
            return words.Aggregate((aggregated, word) => aggregated + " " + word);
        }

        private string BuildReportView(IEnumerable<string> words)
        {
            var fizzCount = words.Where(word => word == "fizz").Count();
            var buzzCount = words.Where(word => word == "buzz").Count();
            var fizzBuzzCount = words.Where(word => word == "fizzbuzz").Count();
            var luckyCount = words.Where(word => word == "lucky").Count();
            var integerCount = words.Count() - fizzCount - buzzCount - fizzBuzzCount - luckyCount;

            return string.Format("fizz: {0} buzz: {1} fizzbuzz: {2} lucky: {3} integer: {4}", fizzCount, buzzCount, fizzBuzzCount, luckyCount, integerCount);
        }

        private string ConvertNumberToWord(int number)
        {
            if (number.ToString().Contains('3'))
                return "lucky";

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
