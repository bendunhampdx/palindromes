using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class WordTests
  {
  
  [TestMethod]
  public void IsPalindrome_IsArray_True()
  {
    Word testWord = new Word();
    Assert.AreEqual(true, testWord.IsPalindrome("butter"));
  }

  [TestMethod]
  // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    public void IsPalindrome_IsSameReversed_True()
    {
    Word testWord = new Word();
    Assert.AreEqual(true, testWord.IsPalindrome("racecar"));
    }
  }
}
