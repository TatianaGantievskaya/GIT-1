using System;

namespace LineModification
{
  /// <summary>
  /// This class was made for an unexpected exception.
  /// </summary>
  class IncorrectStringException : Exception
  {
    public override string Message
    {
      get
      {
        return "One or more of your strings were incorrect. Check out your strings and make sure they are not null or empty.";
      }
    }
  }
}