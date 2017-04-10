using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{    
    public class FizzBuzz
    {
        private Dictionary<string, int> _wordTypeCount;

        public FizzBuzz()
        {
             _wordTypeCount = new Dictionary<string, int>
             {
                {"fizz", 0},
                {"buzz", 0},
                {"fizzbuzz", 0},
                {"lucky", 0},
                {"integer", 0},
             };
        }

        public string Generate(int lowerBound, int upperBound)
        {
            if (lowerBound <= 0)
                return string.Empty;

            if (upperBound < lowerBound)
                return string.Empty;

            var fizzbuzz = Enumerable.Range(lowerBound, (upperBound - lowerBound) + 1)
                .Select(number => ConvertNumberToWord(number))
                .Aggregate((aggregated, word) => aggregated + " " + word);

            var report = _wordTypeCount
                .Select(keyValuePair => keyValuePair.Key + ": " + keyValuePair.Value.ToString())
                .Aggregate((aggregated, reportItem) => aggregated + " " + reportItem);

            return (fizzbuzz + " " + report).TrimEnd();
        }

        private string ConvertNumberToWord(int number)
        {
            if (number.ToString().Contains('3'))
            {
                _wordTypeCount["lucky"] += 1;
                return "lucky";
            }

            if (number % 5 == 0 && number % 3 == 0)
            {
                _wordTypeCount["fizzbuzz"] += 1;
                return "fizzbuzz";
            }

            if (number % 5 == 0)
            {
                _wordTypeCount["buzz"] += 1;
                return "buzz";
            }

            if (number % 3 == 0)
            {
                _wordTypeCount["fizz"] += 1;
                return "fizz";
            }

            _wordTypeCount["integer"] += 1;
            return number.ToString();
        }
    }
}
