using System;

namespace Triangle
{
    class MainPart
    {
        static void Main(string[] args)
        {
            Input inputNumbers = new Input();
            inputNumbers.ToInput();
            double[] data = inputNumbers.ReturnValues();
            Builder[] builders = new Builder[3];
            builders[0] = new EquilateralTriangleBuilder(null);
            builders[1] = new IsoscelesTriangleBuilder(null);
            builders[2] = new OrdinaryTriangleBuilder(null);
            Triangle triangle;
            foreach (var build in builders)
            {
                try
                {
                    triangle = build.Build(data);
                }
                catch (TriangleTypeException ex)
                {
                    Console.Write("\nMessage: " + ex.Message);
                    continue;
                }
                Console.WriteLine(triangle.Result());
                break;
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}