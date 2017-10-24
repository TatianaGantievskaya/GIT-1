using System.Collections.Generic;
using System.Text;

namespace CommonSubstringSearchViaCollection
{
  /// <summary>
  /// This class is made for the search common substrings in two strings.
  /// </summary>
  class CommonSubstringsSearch
  {
    private string firstString;
    private string secondString;

    /// <summary>
    /// Class constructor, which initialize strings or throws the exception if one or both the strings are empty.
    /// </summary>
    /// <param name="firstData"> Input parameter, first string. </param>
    /// <param name="secondData"> Input parameter, second string. </param>
    public CommonSubstringsSearch(string firstData, string secondData)
    {
      if (string.IsNullOrEmpty(firstData) || string.IsNullOrEmpty(secondData))
      {
        throw new NullStringException();
      }
      firstString = firstData;
      secondString = secondData;
    }

    /// <summary>
    /// This method was created for searching the common substrings in two strings.
    /// </summary>
    /// <returns> It returns a list of common substrings. </returns>
    public List<string> SearchCommonSubstrings()
    {
      List<string> commonSubstrings = new List<string>();
      int fIndex, sIndex;
      for (int i = 0; i < firstString.Length; i++)
      {
        for (int j = 0; j < secondString.Length; j++)
        {
          StringBuilder commonSubstringCreation = new StringBuilder();
          fIndex = i;
          sIndex = j;
          while (firstString[fIndex].Equals(secondString[sIndex]))
          {
            if (fIndex < firstString.Length && sIndex < secondString.Length)
            {
              commonSubstrings.Add(commonSubstringCreation.Append(secondString[sIndex]).ToString());
              fIndex++;
              sIndex++;
              if (fIndex.Equals(firstString.Length) || sIndex.Equals(secondString.Length))
              {
                break;
              }
            }
          }
        }
      }
      return commonSubstrings;
    }
    
    /// <summary>
    /// This method finds the same strings in list and then delete the repeated.
    /// </summary>
    /// <param name="commonSubstrings"> Input parameter, list of common strings. </param>
    /// <returns> It returns the list without repeating strings. </returns>
    public List<string> CorrectTheListOfCommonSubstrings(List<string> commonSubstrings)
    {
      for (int c = 0; c < commonSubstrings.Count; c++)
      {
        for (int n = 0; n < commonSubstrings.Count; n++)
        {
          if (commonSubstrings[c].Equals(commonSubstrings[n]) && c != n)
          {
            commonSubstrings.Remove(commonSubstrings[n]);
          }
        }
      }
      return commonSubstrings;
    }

    /// <summary>
    /// This method search the longest string in list of common strings.
    /// </summary>
    /// <param name="commonSubstrings"> Input parameter, list without repeating strings. </param>
    /// <returns> It returns the last longest common substring. </returns>
    public string FindTheLongestCommonSubstring(List<string> commonSubstrings)
    {
      int substringLength = commonSubstrings[0].Length;
      int positionInList = 0;
      for (int l = 1; l < commonSubstrings.Count; l++)
      {
        if (substringLength < commonSubstrings[l].Length)
        {
          substringLength = commonSubstrings[l].Length;
          positionInList = l;
        }
      }
      return commonSubstrings[positionInList];
    }

    /// <summary>
    /// This method was created for encapsulation all the previous methods.
    /// </summary>
    /// <returns> It returns the result: the last longest common substring. </returns>
    public string DoTheSearchOfTheLongestCommonSubstring()
    {
      return FindTheLongestCommonSubstring(CorrectTheListOfCommonSubstrings(SearchCommonSubstrings()));
    }
  }
}