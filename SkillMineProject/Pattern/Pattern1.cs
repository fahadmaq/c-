using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= 5; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
