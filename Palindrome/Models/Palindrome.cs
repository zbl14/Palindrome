namespace Palindrome
{
  public class Palindrome
  {
    public bool IsPalindromeWord(string word)
    {
      string NewWord = word;
      string Reverse = string.Empty;

      for (int i = NewWord.Length - 1; i >= 0; i--)
      {
        Reverse += NewWord[i];
      }

      if (NewWord == Reverse)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsPalindromeNum(int n)
    {
      string NumString = n.ToString();
      bool CheckNum = IsPalindromeWord(NumString);

      if (CheckNum == true)
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