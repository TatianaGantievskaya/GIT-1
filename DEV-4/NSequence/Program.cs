using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool check = false;
                Console.WriteLine("Enter a sequence of numbers:");
                string[] numbers = Console.ReadLine().Split();
                int n = numbers.Length;
                if (n >= 2)
                {
                    check = true;
                }
                while (check != true)
                {
                    if (n < 2)
                    {
                        Console.WriteLine("This is not a sequence. You must enter more than one number. If you want to enter numbers again, type 'continue'. Also you can type anything to exit.");
                        string choice = Console.ReadLine();
                        if (choice == "continue")
                        {
                            Console.WriteLine("\nEnter a sequence of numbers:");
                            numbers = Console.ReadLine().Split();
                            n = numbers.Length;
                        }
                        else
                        {
                            return;
                        }
                        if (n >= 2)
                        {
                            check = true;
                        }
                    }
                }
                int[] sequence = new int[n];
                for (int i = 0; i < n; i++)
                {
                    sequence[i] = int.Parse(numbers[i]);
                }
                int counter = 0;
                for (int j = 1; j < n; j++)
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
