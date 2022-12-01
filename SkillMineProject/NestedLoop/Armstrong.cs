using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            int rem;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }
            if (sum == num)
            {
                Console.Write("Armstrong Number");
            }
            else
            {
                Console.Write("Not an Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
