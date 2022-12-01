using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Operator
{
    class DivisibleFive
    {
        public static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter a NUmber Please");
            num = int.Parse(Console.ReadLine());
            string result;
            if(num>=0)
            {
                Console.WriteLine("ip is +");

            }
            else
            {
                Console.WriteLine("ip is -");

            }
            result = (num >= 0) ? "+" : "-";
            /*if(num%5==0)
            {
                Console.WriteLine("5 divisible");

            }
                else if(num%11==0)
            {
                Console.WriteLine("11 divisible");
            }
            result = (num % 5 == 0)?"true" : "false";
           
            result = (num % 11 == 0) ? "TRUE" : "FALSE";*/
            


        }
    }
}
