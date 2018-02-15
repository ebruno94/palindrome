using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PalindromeProject.Models
{
    public class Palindrome
    {
        private static string _stringWord;
        private static Dictionary<char, char> dictionary = new Dictionary<char, char>()
        {
            {'A', 'A'},
            {'B', 'ᙠ'},
            {'C', 'Ɔ'},
            {'D', 'ᗡ'},
            {'E', 'Ǝ'},
            {'F', 'ᖷ'},
            {'G', 'Ꭾ'},
            {'H', 'H'},
            {'I', 'I'},
            {'J', 'Ⴑ'},
            {'K', 'ᐴ'},
            {'L', '⅃'},
            {'M', 'M'},
            {'N', 'И'},
            {'O', 'O'},
            {'P', 'ꟼ'},
            {'Q', 'Ọ'},
            {'R', 'Я'},
            {'S', 'Ƨ'},
            {'T', 'T'},
            {'U', 'U'},
            {'V', 'V'},
            {'W', 'W'},
            {'X', 'X'},
            {'Y', 'Y'},
            {'Z', 'Ƹ'},
            {' ', ' '},
            {'.', '.'},
            {'!', '!'}

        };

        public static void SetWord(string newWord)
        {
            _stringWord = newWord.ToUpper();
        }

        public static string GetWord()
        {
            return _stringWord;
        }

        public static bool IsPalindrome()
    	{
    		char[] charArray = _stringWord.ToCharArray();
    		char[] tempArray = new char[_stringWord.Length];
    		charArray.CopyTo(tempArray, 0);
    		Array.Reverse(tempArray);
    		string charString = "";
    		string tempString = "";
    		foreach (char character in charArray)
    		{
    			charString += character;
    		}
    		foreach (char character in tempArray)
    		{
    			tempString += character;
    		}
    		return charString.Equals(tempString);
    	}

        public static string GetMirroredString()
        {
            string mirroredString = "";
            for (int i = 0; i < _stringWord.Length; i++)
            {
                mirroredString += dictionary[_stringWord[i]];
            }
            return mirroredString;
        }

        public static string GetFrontHalfString(string word)
        {
            string frontHalf = "";
            double wordLength = word.Length;

            for (int i = 0; i < Math.Ceiling(wordLength / 2); i++)
            {
                frontHalf += word[i];
            }

            return frontHalf;
        }

        public static string GetBackHalfString(string word)
        {
            string backHalf = "";
            double wordLength = word.Length;

            for (int i = word.Length-1; i >= Math.Floor(wordLength / 2); i--)
            {
                backHalf += word[i];
            }

            return backHalf;
        }
    }
}
