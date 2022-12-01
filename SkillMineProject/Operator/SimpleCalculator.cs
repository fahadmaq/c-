using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Operator
{
    class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = int.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Addition = {0} ", c);
                    break;
                case 2:
                    Console.Write("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Substraction = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Mulltiplication = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Division is={0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
