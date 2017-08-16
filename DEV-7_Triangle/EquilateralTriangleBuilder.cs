using System;

namespace Triangle
{
    class EquilateralTriangleBuilder : Builder
    {
        const string message = "Cannot create an equilateral triangle. Trying to create an isosceles triangle...";

        public EquilateralTriangleBuilder(Builder successor)
        {
            this.successor = successor;
        }

        public override Triangle Build(double[] data)
        {
            try
            {
                return new EquilateralTriangle(data);
            }
            catch (TriangleTypeException)
            {
                if (successor != null)
                {
                    return successor.Build(data);
                }
                throw new TriangleTypeException(message);
            }
        }
    }
}