using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Conditional
{
    class DaynameNum
    {
        public static void Main(string[]args)
        {
            int dayno;
            Console.WriteLine("Enter a day Number");
            dayno = int.Parse(Console.ReadLine());
            if (dayno == 1)
            {

                Console.WriteLine("Monday");
            }

            else if (dayno == 2)
            {

                Console.WriteLine("tuesday");
            }

            else if (dayno == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayno == 4)
            {
                Console.WriteLine("thursday");
            }
            else if (dayno == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayno == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayno == 7)
            {
                Console.WriteLine("Sunday");
            }

                



                
            
        }
    }
}
