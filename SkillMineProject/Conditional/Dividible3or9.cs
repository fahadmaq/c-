using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Conditional
{
    class Dividible3or9
    {
        public static void Main(string[]args)
        {
            int number;
            Console.WriteLine("Input Number");
            number = int.Parse(Console.ReadLine());
            if (number %3==0)
            {
                Console.WriteLine("IT is divisible by 3");
            }
            else if(number %9==0)
            {
                Console.WriteLine("It is divisible by 9");
            }
        else
            {
                Console.WriteLine("Not divisible by either");

            }
        }
    }
}
