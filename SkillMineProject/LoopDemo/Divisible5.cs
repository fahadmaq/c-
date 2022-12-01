using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.LoopDemo
{
    class Divisible5
    {
        public static void Main(string[] args)
        {
            int num;
            num = 0;

            Console.WriteLine("Number: " + num);
            num = int.Parse(Console.ReadLine());

            for (num = 1; num <= 150; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("Divisible by 3 and 5");
                }
                else
                {
                    Console.WriteLine("Not divisible by 3 and 5");
                }
            }
                
        }
    }
}
