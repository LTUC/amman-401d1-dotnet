using System;
using Xunit;
using UnitTesting;

namespace TestFizzBuzz
{
    public class UnitTest1
    {
        [Fact]                          //annotation
        public void CanConvrtToString()
        {
            Assert.Equal("1", FizzBuzz.Convert(1));
        }

        [Fact]
        public void CanConvertFizz()
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(3));
        }

        [Fact]
        public void CanConvertBuzz()
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(5));
        }

        [Fact]
        public void CanConvertFizzBuzz()
        {
            Assert.Equal("FizzBuzz", FizzBuzz.Convert(15));
        }

        [Theory]
        [InlineData(1,"1")]
        [InlineData(4, "4")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        public void testMultiValues(int inputValue, String expectedValue)
        {
            Assert.Equal(expectedValue, FizzBuzz.Convert(inputValue));
        }
    }
}
