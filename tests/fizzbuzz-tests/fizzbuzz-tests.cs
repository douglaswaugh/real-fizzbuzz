using Xunit;
using Shouldly;
using fizzbuzz;

namespace fizzbuzz_tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_return_empty_string_for_range_with_a_lower_bound_of_less_than_1()
        {
            var fizzBuzz = new FizzBuzz();

            fizzBuzz.Generate(0, 0).ShouldBe(string.Empty);
        }

        [Fact]
        public void Should_return_empty_string_for_range_with_an_upper_bound_less_than_the_lower_bound()
        {
            var fizzBuzz = new FizzBuzz();

            fizzBuzz.Generate(1, 0).ShouldBe(string.Empty);
        }

        [Theory]
        [InlineData(1, 1, "1")]
        [InlineData(1, 2, "1 2")]
        [InlineData(1, 3, "1 2 fizz")]
        [InlineData(1, 5, "1 2 fizz 4 buzz")]
        [InlineData(1, 15, "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz")]
        public void Should_return_string_for_range(int lowerBound, int upperBound, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            fizzBuzz.Generate(lowerBound, upperBound).ShouldBe(expected);
        }
    }
}

// for numbers that are multiples of 3 write fizz
// for numbers that are multiples of 5 write buzz
// for numbers that are multiples of both 3 and 5 write fizzbuzz
// for all other numbers write the number 
