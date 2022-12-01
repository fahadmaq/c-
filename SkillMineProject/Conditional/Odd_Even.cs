using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Conditional
{
    class Oddven
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number");
            i = int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine("NUMBER IS EVEN");
            }
            else
            {
                Console.WriteLine("NUMBER IS ODD");
            }

        }


    }
}
