using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
