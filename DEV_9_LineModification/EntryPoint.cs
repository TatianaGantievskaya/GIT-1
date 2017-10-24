using System;

namespace LineModification
{
  /// <summary>
  /// This is the entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string firstString = "he11oEvery1";
      string secondString = "g00dBy8";
      try
      {
        RandomLineModification changingString  = new RandomLineModification(firstString, secondString);
        string modificatedString = changingString.ModificateString();
        Console.WriteLine("Changing string: " + firstString + '\n' + "Replacing string: " + secondString);
        Console.WriteLine("\nResulting string: " + modificatedString);
      }
      catch (IncorrectStringException er)
      {
        Console.WriteLine(er.Message);
      }
      Console.ReadKey();
    }
  }
}