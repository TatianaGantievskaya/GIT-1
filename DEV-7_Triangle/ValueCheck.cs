using System;

namespace Triangle
{
    class ValueCheck
    {
        public bool CheckTheValue(double[] sides)
        {
            bool status = true;
            for (int k = 0; k < 3; k++)
            {
                if (sides[k] <= 0)
                {
                    status = false;
                    break;
                }
            }
            return status;
        }
    }
}