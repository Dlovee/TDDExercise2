using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsAPalindrome(string word)
            {
                if (word == null || word.Length == 0)
                {
                    return false;
                }

                string wordLowered = word.ToLower();
                string backwards = "";

                for (int i = wordLowered.Length - 1; i >= 0; i--)
                {
                    backwards += wordLowered[i];
                }
        
                return wordLowered == backwards;

                // if (wordLowered == backwards)
                // {
                //     return true;
                // }
                // else
                // {
                //     return false;
                // }

            }
        }
    }
}
