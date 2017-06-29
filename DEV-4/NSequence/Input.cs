using System;

namespace Sequence
{
    class Input
    {
        public string[] EnterNumbers(bool repeatInput)
        {
            string[] StringNumbers = null;
            while (repeatInput)
            {
                Console.WriteLine("Enter a sequence of numbers:");
                StringNumbers = Console.ReadLine().Split();
                if (StringNumbers.Length > 1)
                {
                    repeatInput = false;
                }
            }
            return StringNumbers;
        }
    }
}