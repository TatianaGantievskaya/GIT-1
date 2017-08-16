using System;

namespace Triangle
{
    class TriangleTypeException : Exception
    {
        private string message;

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                Message = message;
            }
        }

        public TriangleTypeException()
        {
            message = "Impossible to create triangle.\n";
        }

        public TriangleTypeException(string text)
        {
            message = text;
        }
    }
}