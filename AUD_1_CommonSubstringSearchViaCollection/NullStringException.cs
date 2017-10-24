using System;

namespace CommonSubstringSearchViaCollection
{
  /// <summary>
  /// This class was created for the case of unexpected exception.
  /// </summary>
  class NullStringException : Exception
  {
    public string Message
    {
      get
      {
        return "One or more of your strings were incorrect. Check out your strings and make sure they are not null or empty.";
      }
    }
  }
}