using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}

		public static bool IsAPalindrome(string word)
		{
			word = word.ToLower();
			var newWord = word.Replace(" ", "");
			var reversedWord = "";

			for (int i = word.Length - 1; i >= 0; i--)
			{
				reversedWord += word[i];
			}

			return word == reversedWord;
        }

    }
}

