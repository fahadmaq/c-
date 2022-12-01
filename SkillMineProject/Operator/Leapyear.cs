using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Operator
{
    class Leapyear
{
        public static void Main(string[]args)
        {
            int year;
            Console.WriteLine("Enter Year");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("entered year is leap" + year);
            }
            else
            {
                Console.WriteLine("Entered year is not leap" + year);
            }
            Console.WriteLine();


        }
}
}
