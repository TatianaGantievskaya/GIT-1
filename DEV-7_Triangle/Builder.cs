using System;

namespace Triangle
{
    abstract class Builder
    {
        protected Builder successor;

        public abstract Triangle Build(double[] data);
    }
}