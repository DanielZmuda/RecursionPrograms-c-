using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RecursionPrograms
{
    class PowerOfNumber
    {
        public static int Power(int number, int power)
        {
           
            if (power > 0)
            {
                return (number*Power(number, power -1));
            } else
            {
                return 1;
            }
            

        }
    }
}
