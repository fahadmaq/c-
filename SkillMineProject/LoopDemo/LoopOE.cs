using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.LoopDemo
{
    class LoopOE
    {
        public static void Main(string[]args)
        {
            for (int input = 81; input <= 120; input++)
            {
                if(input%2!=0)
                {
                    Console.WriteLine(input);
                } 

            }
        }
    }
}
