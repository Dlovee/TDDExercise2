using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests;

public class WordSmithTest
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
        // Arrange
        var ws = new WordSmith();

        // Act
        var actual = ws.IsAPalindrome(word);

        // Assert
        Assert.Equal(expected, actual);

    }

}