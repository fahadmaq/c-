using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.SwitchCase
{
    class OdEv
    {
        public static void Main(string[] args)
        {

            int num;
            Console.Write("Enter any number to check even or odd");
            num = int.Parse(Console.ReadLine());

            switch (num % 2)
            {

                case 1:
                    Console.WriteLine(  " is even number"+num);
                    break;

                case 2:
                    Console.WriteLine(" is odd number"+num);
                    break;
            }

        }
    }
}

