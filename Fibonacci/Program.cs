using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please, enter your number:");
                int number = int.Parse(Console.ReadLine());
                bool check = false;
                if (number >= 0)
                {
                    check = true;
                }
                while (check != true)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Your number is negative. You can try again and enter a nonnegative number, or exit. Type 'continue' or 'exit':");
                        string choice = Console.ReadLine();
                        if (choice == "continue")
                        {
                            Console.WriteLine("\nPlease, enter your number:");
                            number = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        if (number >= 0)
                        {
                            check = true;
                        }
                    }
                }
                int F0, F1, FN;
                FN = 0;
                F1 = 1;
                for (F0 = 0; F0 <= number; F0 = FN)
                {
                    if (number == F0)
                    {
                        break;
                    }
                    FN = F0 + F1;
                    F1 = F0;
                }
                if (number == F0)
                {
                    Console.WriteLine("This is the Fibonacci number.");
                }
                else
                {
                    Console.WriteLine("This is not the Fibonacci number.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, this is not a number.");
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

