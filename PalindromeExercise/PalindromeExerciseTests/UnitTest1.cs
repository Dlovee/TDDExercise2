using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("John", false)]
        [InlineData("Jose", false)]
        [InlineData("Amoriss", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var ws = new WordSmith();
            var actual = ws.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}