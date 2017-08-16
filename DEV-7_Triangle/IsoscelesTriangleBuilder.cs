using System;

namespace Triangle
{
    class IsoscelesTriangleBuilder : Builder
    {
        const string message = "Cannot create isosceles triangle. Trying to create ordinary triangle...";

        public IsoscelesTriangleBuilder(Builder successor)
        {
            this.successor = successor;
        }

        public override Triangle Build(double[] data)
        {
            try
            {
                return new IsoscelesTriangle(data);
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