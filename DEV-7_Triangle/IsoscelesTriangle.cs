using System;

namespace Triangle
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double[] sides) : base(sides)
        {
            if (Math.Abs(sideA - sideB) < EPSILON || Math.Abs(sideB - sideC) < EPSILON || Math.Abs(sideC - sideA) < EPSILON)
            {
                typeDefinition = "\nYour triangle is isosceles.";
            }
            else
            {
                throw new TriangleTypeException();
            }
        }

        public override string Result()
        {
            return typeDefinition;
        }
    }
}