using Xunit;
using Shouldly;

namespace fizzbuzz_tests
{
    public class FizzBuzz
    {
        public string Generate(int lowerBound, int upperBound)
        {
            return string.Empty;
        }
    }

    public class FizzBuzzTests
    {
        [Fact]
        public void Should_return_empty_string_for_range_with_a_lower_bound_of_less_than_1()
        {
            var fizzBuzz = new FizzBuzz();

            fizzBuzz.Generate(0, 0).ShouldBe(string.Empty);
        }
    }
}

// for numbers that are multiples of 3 write fizz
// for numbers that are multiples of 5 write buzz
// for numbers that are multiples of both 3 and 5 write fizzbuzz
// for all other numbers write the number 
