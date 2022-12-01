using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Conditional
{
    class NestedConditions
    {
        public static void Main(string[]args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                if (num1 > num3)
                    Console.WriteLine("num1 is  largst");
                else
                    {
                    Console.WriteLine("num3 is largest");
                    }
                if (num2>num3)
                {
                    if (num2 > num1)
                        Console.WriteLine("Num 2 is large");
                    else

                    {
                        Console.WriteLine("Num 3 is large");
                    }
                }
            }
        }
    }
}
