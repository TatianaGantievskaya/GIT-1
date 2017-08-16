using System;

namespace Triangle
{
    class Input
    {
        private double[] sidesArray = new double[3];

        const string messageForUser = "\nEnter the sides of your triangle:";
        const string wrongValues = "\nYou entered wrong values, it's impossible to create a triangle.\n";
        const string userInputError = "\nImpossible to create a triangle, 'cause if you want to create triangle, you must enter 3 positive numbers. Try again:";

        public void ToInput()
        {
            Console.WriteLine(messageForUser);
            bool goodinput = false;
            string[] inputStringNumbers;
            while (!goodinput)
            {
                try
                {
                    inputStringNumbers = Console.ReadLine().Split();
                    if (inputStringNumbers.Length == 3)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            sidesArray[i] = double.Parse(inputStringNumbers[i]);
                        }
                        ValueCheck check = new ValueCheck();
                        bool correctInput = check.CheckTheValue(sidesArray);
                        if (correctInput)
                        {
                            goodinput = true;
                        }
                        else
                        {
                            Console.WriteLine(wrongValues + messageForUser);
                        }
                    }
                    else
                    {
                        Console.WriteLine(userInputError);
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine('\n' + fex.Message + messageForUser);
                    goodinput = false;
                }
            }
        }

        public double[] ReturnValues()
        {
            return sidesArray;
        }
    }
}