using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern6
    {
        public static void Main(string[]arg)
        {
            int num= 5;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
