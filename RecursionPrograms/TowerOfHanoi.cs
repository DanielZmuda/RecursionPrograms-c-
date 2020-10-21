using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPrograms
{
    class TowerOfHanoi
    {
        public static void SolvePuzzle(int n, char startPeg = 'A', char endPeg = 'C',char tempPeg = 'B')
        {
            if (n > 0)
            {
                SolvePuzzle(n - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
                SolvePuzzle(n - 1, tempPeg, endPeg, startPeg);
            }
        }
    }
}
