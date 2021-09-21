using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void Palindrome_IsMomAPalindrome_True()
    {
      PalindromeTest palindrome = new PalindromeTest();
      Assert.AreEqual(true, palindrome.IsAPalindrome("mom"));
    }

    [TestMethod]
    public void Palindrome_IsEpicodusAPalindrome_False()
    {
      PalindromeTest palindrome = new PalindromeTest();
      Assert.AreEqual(false, palindrome.IsAPalindrome("epicodus"));
    }

    [TestMethod]
    public void Palindrome_IsCapitalizedMomAPalindrome_True()
    {
      PalindromeTest palindrome = new PalindromeTest();
      Assert.AreEqual(true, palindrome.IsAPalindrome("Mom"));
    }
  }
}