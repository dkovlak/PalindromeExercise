using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("apPle", false)]
        [InlineData("lOl", true)]
        [InlineData("cIvic", true)]
        [InlineData("mam ba", false)]
        [InlineData("dei  fied", true)]

        public void IsAPalindrome_Test(string word, bool expected)
        {
            var actual = WordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
