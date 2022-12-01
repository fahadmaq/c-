using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class DisariumNumber
    {
        public static void Main(string[]args)
        {
            {
                int num;
                Console.WriteLine("Enter num");

                num = int.Parse(Console.ReadLine());
                string numStr = num.ToString();
                int length = numStr.Length;
                int divide = 0, sum = 0, copy = num;
                while (copy > 0)
                {
                    divide = copy % 10;
                    sum = sum + (int)Math.Pow(divide, length);
                    length--;
                    copy = copy / 10;
                }
                if (sum == num)
                    Console.WriteLine("Disarium Number.");
                else
                    Console.WriteLine("Not a Disarium Number.");
                Console.ReadLine();

            }
            
        }
    }
}
