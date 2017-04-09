using Xunit;

namespace fizzbuzz_tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_return_numbers()
        {
            var something = "this";

            Assert.Equal(something, "thisd");
        }
    }
}

// for numbers that are multiples of 3 write fizz
// for numbers that are multiples of 5 write buzz
// for numbers that are multiples of both 3 and 5 write fizzbuzz
// for all other numbers write the number 
