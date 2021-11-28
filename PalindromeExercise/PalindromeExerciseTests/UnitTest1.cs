using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("Olumide", false)]
        [InlineData("rotor", true)]
        [InlineData("civic", true)]



        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmithcs();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
