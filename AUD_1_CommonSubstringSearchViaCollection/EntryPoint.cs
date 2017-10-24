using System;
using System.Diagnostics;

namespace CommonSubstringSearchViaCollection
{
  /// <summary>
  /// Entry point. From here program starts working.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      /// At first, as the example strings firstString = "hellogoodbye" and secondString = "asdelddgodbjh" were used.

      StringCreation strings = new StringCreation();
      string firstString = strings.CreateRandomString(20);
      string secondString = strings.CreateRandomString(15);
      Console.WriteLine("First string: " + firstString + '\n' + "Second string: " + secondString);
      string theLongestSubstring = null;
      int numberOfStarts = 1000;
      try
      {
        CommonSubstringsSearch commonSubstrings = new CommonSubstringsSearch(firstString, secondString);
        Stopwatch checker = new Stopwatch();
        checker.Start();
        for (int r = 0; r < numberOfStarts; r++)
        {
          theLongestSubstring = commonSubstrings.DoTheSearchOfTheLongestCommonSubstring();
        }
        checker.Stop();
        Console.WriteLine("The longest substring in those two strings is: " + theLongestSubstring);
        Console.WriteLine("\nRunning time - " + checker.Elapsed.TotalSeconds);
        Console.WriteLine("Average running time - " + (checker.Elapsed.TotalSeconds / numberOfStarts));
      }
      catch (NullStringException ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.ReadKey();
    }
  }
}