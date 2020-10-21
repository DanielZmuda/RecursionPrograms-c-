using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPrograms
{
    class DecimalToBinary
    {
        public static int ToBinary(int x)
        {
            if (x != 0)
            {
                return (x % 2 + 10 * ToBinary(x / 2));
            }
            else { return 0; }
        }
    }
}
