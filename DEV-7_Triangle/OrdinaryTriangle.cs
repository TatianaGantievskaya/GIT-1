using System;

namespace Triangle
{
    class OrdinaryTriangle : Triangle
    {
        public OrdinaryTriangle(double[] sides) : base(sides)
        {
            if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
            {
                typeDefinition = "\nYour triangle is ordinary triangle.";
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