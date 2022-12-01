using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class Trimorphic
    {
        static bool isTrimorphic(int N)
        {
            int cube = N * N * N;

            // Start Comparing digits
            while (N > 0)
            {

                // Return false, if any digit
                // of N doesn't match with
                // its cube's digits from last
                if (N % 10 != cube % 10)
                    return false;

                // Reduce N and cube
                N /= 10;
                cube /= 10;
            }

            return true;
        }

        // Driver code
        public static void Main()
        {
            int N = 24;

            if (isTrimorphic(N) == true)
                Console.Write("trimorphic");
            else
                Console.Write("not trimorphic");
        }
    }
}
