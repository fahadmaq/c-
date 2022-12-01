using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Conditional
{
    class Zeropositivenegative
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            if (number<0)
            {
                Console.WriteLine("It is a NEGATIVE number");
            }
            else if(number==0)
            {
                Console.WriteLine("It is ZERO");
            }
            else if(number>0)

            {
                Console.WriteLine("ITIS A POSITIVE NUMBER");

            }
            Console.ReadLine();

                
        }
    }
}
