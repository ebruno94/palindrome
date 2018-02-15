using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PalindromeProject.TestTools
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void IsPalindrome_CheckIfWordIsPalindrome_True()
        {
            string word1 = "gas";
            string word2 = "sag";
            char[] firstArr  = word1.ToCharArray();
            char[] secondArr = word2.ToCharArray();
            Array.Reverse(secondArr);
            CollectionAssert.AreEqual(firstArr, secondArr);
        }
    }
}
