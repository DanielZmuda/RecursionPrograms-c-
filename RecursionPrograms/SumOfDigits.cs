using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RecursionPrograms
{
    class SumOfDigits
    {
        public static int Sum(int x)
        {
            if(x != 0)
            {
                return (x % 10 +    Sum(x / 10));
            }
            else
            {
                return 0;
            }
 
            
        }
    }
}
