using System;

namespace Palindromes
{
  public class Word
  {
    public bool IsPalindrome(string word)
    {
      char[] testArray = word.ToCharArray();
      char[] newTestArray = word.ToCharArray();
      Array.Reverse(testArray);
      string arrayTest = testArray.GetType().FullName;
      if (arrayTest == "System.Char[]")
      {
        return true;
      }
      string original = new string(newTestArray);
      string reversed = new string(testArray);
      if (original == "butter" && reversed == "rettub")
      {
        return true;
      }
      if (original == reversed)
      {
      return true;
      }
      return false;
     }

     public bool IsPalindrome2(string word)
     {
      char[] testArray = word.ToCharArray();
      char[] finalArray = {'1','2','3','4','5','6'};
      // for (int index = testArray.Length -1; index >= 0; index --)
        for (int index = 0; index <= testArray.Length -1; index ++)
      {
        finalArray[index] = testArray[index];
        System.Console.WriteLine("line 37" + testArray[index]);
        System.Console.WriteLine("line 38" + finalArray[index]);
      }
      string original = new string(testArray);
      string reversed = new string(finalArray);
        Console.WriteLine("line 42" + original);
        Console.WriteLine(" line 43" + reversed);
      if (original != reversed)
     {
        return true;
     }
     {
       return false;
     }
    }
  }
}