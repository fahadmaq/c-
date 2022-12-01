using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern4
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    if (y == 1 || y == x || x == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
