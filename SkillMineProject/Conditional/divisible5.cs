using System;

namespace SkillMineProject.Conditional
{
    class Divisible5
    {
        public static void Main(string[] args)
        {
            int num1;
          
            Console.WriteLine("Enter your Number");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }
            else 
            {
                Console.WriteLine("Not divisible by 5");

                   
            }

            

        }
            



    }
}
