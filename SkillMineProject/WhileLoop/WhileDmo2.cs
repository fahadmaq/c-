using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class WhileDmo2

    {
        //sum  of odd number between 1-20
        static void Main(string[] args)
        {

            int i, num, sum = 0;

            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all odd numbers between 1 to " + num + " = " + sum);

            Console.ReadLine();
        }
    }
}
