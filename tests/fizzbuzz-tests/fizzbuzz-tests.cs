using Xunit;
using Shouldly;
using FizzBuzzLibrary;

namespace FizzBuzzTests
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
        [InlineData(1, 1, "1 fizz: 0 buzz: 0 fizzbuzz: 0 lucky: 0 integer: 1")]
        [InlineData(1, 2, "1 2 fizz: 0 buzz: 0 fizzbuzz: 0 lucky: 0 integer: 2")]
        [InlineData(1, 3, "1 2 lucky fizz: 0 buzz: 0 fizzbuzz: 0 lucky: 1 integer: 2")]
        [InlineData(1, 5, "1 2 lucky 4 buzz fizz: 0 buzz: 1 fizzbuzz: 0 lucky: 1 integer: 3")]
        [InlineData(1, 15, "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz fizz: 3 buzz: 2 fizzbuzz: 1 lucky: 2 integer: 7")]
        public void Should_return_string_for_range(int lowerBound, int upperBound, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            fizzBuzz.Generate(lowerBound, upperBound).ShouldBe(expected);
        }
    }
}
