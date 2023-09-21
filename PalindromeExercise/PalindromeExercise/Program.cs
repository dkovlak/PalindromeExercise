using System;
using System.Collections.Generic;
namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "racecar";
            word = word.ToLower();
            var reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            bool nswer = word == reversedWord;
            Console.WriteLine(nswer);
        }
    }
}
