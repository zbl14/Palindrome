using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void PalindromeTests_IsWordPalindrome_True()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(true, testPalindrome.IsPalindromeWord("racecar"));
    }
    [TestMethod]
    public void PalindromeTests_IsWordPalindrome_False()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(false, testPalindrome.IsPalindromeWord("hello"));
    }
    [TestMethod]
    public void PalindromeTests_IsNumberPalindrome_True()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(true, testPalindrome.IsPalindromeNum(101));
    }
    [TestMethod]
    public void PalindromeTests_IsNumberPalindrome_False()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(false, testPalindrome.IsPalindromeNum(123));
    }
  }
}