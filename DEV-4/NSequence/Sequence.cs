using System;

namespace Sequence
{
    class SequenceOfNumbers
    {
        static void Main(string[] args)
        {
            bool repeatInput = true;
            string[] StringNumbers = null;
            bool counter = false;
            Input Line = new Input();
            Check Numbers = new Check();
            while (repeatInput)
            {
                try
                {
                    StringNumbers = Line.EnterNumbers(repeatInput);
                    if (StringNumbers != null)
                    {
                        repeatInput = false;
                    }
                    if (!repeatInput)
                    {
                        counter = Numbers.Result(repeatInput, StringNumbers);
                        if (counter)
                        {
                            Console.WriteLine("\nYour sequence is not non-decreasing.");
                        }
                        else
                        {
                            Console.WriteLine("\nYour sequence is non-decreasing.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nError: " + ex.Message);
                    repeatInput = true;
                }
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}