using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPrograms
{
    class FibonacciSeries
    { 
        public static int Fibonacci( int length)
        {
            if (length == 0) return 0; 
            if (length == 1) return 1;
            return Fibonacci(length - 1) + Fibonacci(length - 2);

        }
    }
}
