using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.LoopDemo
{
    class Table
    {
        static void Main(string[] args) 
        {
            int table = 9;
            int length = 10;
            int i = 1;

            Console.WriteLine("Multiplication table: " +table);
            for (i = 1; i <= length; i++)
            {

                Console.WriteLine("{0, 2} * {1, 2} = {2}", i, table, i * table);

            }
        }  
    }
}
