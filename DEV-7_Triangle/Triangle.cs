using System;

namespace Triangle
{
    abstract class Triangle
    {
        protected const double EPSILON = 10e-7;

        protected string typeDefinition;

        protected double sideA;
        protected double sideB;
        protected double sideC;

        public Triangle(double[] triangleSides)
        {
            sideA = triangleSides[0];
            sideB = triangleSides[1];
            sideC = triangleSides[2];
        }

        abstract public string Result();
    }
}