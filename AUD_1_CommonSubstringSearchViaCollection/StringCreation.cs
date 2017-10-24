using System;

namespace CommonSubstringSearchViaCollection
{
  /// <summary>
  /// In this class our strings are generated.
  /// </summary>
  class StringCreation
  {
    /// <summary>
    /// Here a random string is generated.
    /// </summary>
    /// <param name="stringLength"> Input parameter which sets string length. </param>
    /// <returns> This method returns our string. </returns>
    public string CreateRandomString(int stringLength)
    {
      Random letter = new Random(DateTime.Now.Millisecond);
      char[] stringArray = new char[stringLength];
      for (int e = 0; e < stringArray.Length; e++)
      {
        stringArray[e] = (char)letter.Next(97, 122);
      }
      return new string(stringArray);
    }
  }
}