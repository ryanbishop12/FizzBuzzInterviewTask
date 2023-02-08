namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsAString()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(1);

            //assert
            output.GetType().Should().Be(typeof(string));
        }

        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsNumberAString()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(1);

            //assert
            output.Should().Be("1");
        }

        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAThree_ReturnsFizz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(3);

            //assert
            output.Should().Be("Fizz");
        }

        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAFive_ReturnsBuzz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(5);

            //assert
            output.Should().Be("Buzz");
        }

        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAFifteen_ReturnsFizzBuzz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(15);

            //assert
            output.Should().Be("FizzBuzz");
        }

        [Fact]
        public void FizzBuzzValuesForRange_WhenPassedAFifteen_ReturnsFizzBuzz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzValuesForRange(1, 20);

            //assert
            output.Should().Equal(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz" });
        }
    }
}
