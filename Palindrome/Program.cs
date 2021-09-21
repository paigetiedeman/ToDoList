using System;
using System.Collections.Generic;
using Palindrome.Models;

namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      PalindromeTest palindromeTest = new PalindromeTest();
      Console.WriteLine("Welcome to the Palindrome Checker");
      Console.WriteLine("------------");
      Console.WriteLine("Please enter a word:");
      string word = Console.ReadLine();
      if(word == "")
      {
        Console.WriteLine("Input cannot be blank.");
        Main();
      }
      else
      {
        if(palindromeTest.IsAPalindrome(word))
        {
          Console.WriteLine($"{word} is a Palindrome!");
        }
        else 
        {
          Console.WriteLine($"{word} is not a Palindrome! Try another");
        }
      }
    }
  }
}