using System;

namespace Triangle
{
    class OrdinaryTriangleBuilder : Builder
    {
        const string message = "\nYour triangle doesn't exist.\n";

        public OrdinaryTriangleBuilder(Builder successor)
        {
            this.successor = successor;
        }

        public override Triangle Build(double[] data)
        {
            try
            {
                return new OrdinaryTriangle(data);
            }
            catch (TriangleTypeException ex)
            {
                if (successor != null)
                {
                    return successor.Build(data);
                }
                throw new TriangleTypeException(ex.Message + message);
            }
        }
    }
}