using System;

namespace Triangle
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double[] sides) : base(sides)
        {
            if (Math.Abs(sideA - sideB) < EPSILON && Math.Abs(sideB - sideC) < EPSILON)
            {
                typeDefinition = "\nYour triangle is equilateral.";
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