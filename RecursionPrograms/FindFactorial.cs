using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPrograms
{
    class FindFactorial
    {
        public static int Factorial(int x)
        {
            int factorial = 1;
            while (x > 0)
            {
                factorial = factorial * x;
                x--;
                Factorial(x);
            } 
            return factorial;
        }
    }
}
