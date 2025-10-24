using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            string wordLowered = word.ToLower();
            string backwards = "";

            for (int i = wordLowered.Length - 1; i >= 0; i--)
            {
                backwards += wordLowered[i];
            }

            return wordLowered == backwards;
        }
    }
}