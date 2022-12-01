using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class traianglearea
    {
        public static void Main(string[]args)
        {
            int height, breadth;
            Console.WriteLine("Enter value of Height");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of breadth");
            breadth = int.Parse(Console.ReadLine());

            float b = breadth, h = height;
            double area = (breadth * height) *0.5;
            Console.WriteLine("Area of triangle"+area);



        }
    }
}
