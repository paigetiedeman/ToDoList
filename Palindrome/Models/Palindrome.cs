using System;

namespace Palindrome.Models
{
  public class PalindromeTest
  {
    public bool IsAPalindrome(string word)
    {
      string lowerWord = word.ToLower();
      char[] array = lowerWord.ToCharArray();
      Array.Reverse(array);
      string reverseWord = string.Join("", array);
      if (lowerWord == reverseWord)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
