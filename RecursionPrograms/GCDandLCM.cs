using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPrograms
{
    class GCDandLCM
    {
        public static int FindGreatestCommonDivisor(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 % 2 == 0)
                    num1 = num1 / 2;

                if (num2 % 2 == 0) 
                    num2 = num2 / 2;

                if (num1 > num2)
                    num1 = num1 - num2;

                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num2;
        }
        static int FindLowestCommonMultiple(int a, int b)
        {
            return (a * b) / FindGreatestCommonDivisor(a, b);
        }

    }
}
