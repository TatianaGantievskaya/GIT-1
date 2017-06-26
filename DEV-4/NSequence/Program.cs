using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool repeatInput = true;
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
                
                int[] sequence = new int[StringNumbers.Length];
                for (int i = 0; i < StringNumbers.Length; i++)
                {
                    sequence[i] = int.Parse(StringNumbers[i]);
                }

                int counter = 0;
                for (int j = 1; j < StringNumbers.Length; j++)
                {
                    if (sequence[j] < sequence[j - 1])
                    {
                        counter++;
                    }
                }
                if (counter != 0)
                {
                    Console.WriteLine("\nYour sequence is not non-decreasing.");
                }
                else
                {
                    Console.WriteLine("\nYour sequence is non-decreasing.");
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("\nError " + ex.Message);
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}