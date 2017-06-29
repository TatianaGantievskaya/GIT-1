using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Input
    {
        public string[] EnterNumbers(bool repeatInput)
        {
            //repeatInput = true;
            string[] StringNumbers = null;
            while (repeatInput)
            {
                Console.WriteLine("Enter a sequence of numbers:");
                StringNumbers = Console.ReadLine().Split();
                if (StringNumbers.Length > 1)
                {
                    repeatInput = false;
                }
            }
            return StringNumbers;
        }
    }
}
