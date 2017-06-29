using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Check
    {
        public bool Result(bool repeatInput, string[] StringNumbers)
        {
            bool counter = false;
            if (!repeatInput)
            {
                int[] sequence = new int[StringNumbers.Length];
                for (int i = 0; i < StringNumbers.Length; i++)
                {
                    sequence[i] = int.Parse(StringNumbers[i]);
                }

                //bool counter = false;
                for (int j = 1; j < StringNumbers.Length; j++)
                {
                    if (sequence[j] < sequence[j - 1])
                    {
                        counter = true;
                        break;
                    }
                }
            }
            return counter;
        }
    }
}
