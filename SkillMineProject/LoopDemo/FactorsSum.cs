using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.LoopDemo
{
    class FactorsSum
    {
        public static void Main(string[] args)
        {
            int num, x;
            int sum=0;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    sum=sum+num;
                }
                Console.WriteLine("Sum="+sum);
            }
			
		}
    }
}
