using System;

namespace LineModification
{
  /// <summary>
  /// This class was made for a string modification.
  /// </summary>
  class RandomLineModification
  {
    private Random position = new Random(DateTime.Now.Millisecond);
    private string changingString;
    private string replacingString;

    /// <summary>
    /// Here is the constructor with the check.
    /// </summary>
    /// <param name="firstString"> Input parameter, string which changes. </param>
    /// <param name="secondString"> Input parameter, string which replaces. </param>
    public RandomLineModification (string firstString, string secondString)
    {
      if (string.IsNullOrEmpty(firstString) == true || string.IsNullOrEmpty(secondString) == true)
      {
        throw new IncorrectStringException();
      }
      changingString = firstString;
      replacingString = secondString;
    }

    /// <summary>
    /// The method for generating the starting positions.
    /// </summary>
    /// <param name="line"> Input parameter, it can be changing string or replacing string. </param>
    /// <returns> It returns number of starting position. </returns>
    public int GenerateStartingPosition(string line)
    { 
      return position.Next(line.Length);
    }

    /// <summary>
    /// The method for generating the length of parts.
    /// </summary>
    /// <param name="line"> Input parameter, it can be changing string or replacing string. </param>
    /// <param name="startingPosition"> Position from which a length of part is generating. </param>
    /// <returns> It returns length of part. </returns>
    public int GenerateLengthOfPart(string line, int startingPosition)
    {
      return position.Next(1, line.Length - startingPosition);
    }

    /// <summary>
    /// The method for allocating a substring.
    /// </summary>
    /// <param name="line"> Input parameter, it is replacing string. </param>
    /// <param name="startingPosition"> Position from which a part of string is allocating. </param>
    /// <param name="lengthOfThePart"> Length of fragment which must be allocated. </param>
    /// <returns> It returns an allocated substring. </returns>
    public string AllocateTheSubstring(string line, int startingPosition, int lengthOfThePart)
    {
      return line.Substring(startingPosition, lengthOfThePart);
    }

    /// <summary>
    /// The method for modification the changing string.
    /// </summary>
    /// <returns> It returns a modificated string. </returns>
    public string ModificateString()
    {
      int startingPositionInChangingString = GenerateStartingPosition(changingString);
      int startingPositionInReplacingString = GenerateStartingPosition(replacingString);
      string lineReplacingPartOfTheFirstLine = AllocateTheSubstring(replacingString, startingPositionInReplacingString, GenerateLengthOfPart(replacingString, startingPositionInReplacingString));
      string preparedChangingString = changingString.Remove(startingPositionInChangingString, GenerateLengthOfPart(changingString, startingPositionInChangingString));
      return preparedChangingString.Insert(startingPositionInChangingString, lineReplacingPartOfTheFirstLine);
    }
  }
}