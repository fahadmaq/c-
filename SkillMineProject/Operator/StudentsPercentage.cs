using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Operator
{
    class StudentsPercentage
    {
        public static void Main(string[]args)
        {
            int  sub1, sub2, sub3, sub4, sub5, per;
            Console.WriteLine("Enter sub1 marks");
            sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sub2 marks");
            sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks for sub3");
            sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks for sub4");
            sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks for sub5");
            sub5 = int.Parse(Console.ReadLine());

            per = ((sub1 + sub2 + sub3 + sub4 + sub5) * 100) / 500;
                if (per >70 )
            {
                Console.WriteLine("Passed with distinction"+per);
            }
                else if (per>60 || per <=70)
            {
                Console.WriteLine("Passed with Firt Class"+per);

            }
                else if(per>50|| per<=60)
            {
                Console.WriteLine("Passed Second Class"+per);

            }
                else if(per>35|| per<=50)
            {
                Console.WriteLine("Just Passed"+per);
                
            }
                else  if (per>35)
            {
                Console.WriteLine("Better Luck Next time"+per);

            }

        }
    }
}
