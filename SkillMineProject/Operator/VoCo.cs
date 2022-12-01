using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Operator
{
    class VoCo
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the charachter");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("{0} is a vowel", ch);
                    break;
                default:
                    Console.WriteLine("{0} is not a vowel",  ch);
                    break;
            }
            
        }
    }
}
