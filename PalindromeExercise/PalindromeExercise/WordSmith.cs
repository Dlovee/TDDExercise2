using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            string lowered = word.ToLower();
            string reversed = new string(lowered.Reverse().ToArray());

            return lowered == reversed;
        }
    }
}