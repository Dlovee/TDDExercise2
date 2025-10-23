using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests;

public class UnitTest1
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("John", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void IsAPalindromeTest(string word, bool expected)
    {
        var ws = new WordSmith();
        var actual = ws.IsAPalindrome(word);
        Assert.Equal(expected, actual);
    }
}