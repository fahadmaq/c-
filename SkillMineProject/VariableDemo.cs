using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class VariableDemo
    {
        static void Main(string[]args)
        {
            byte mybyte; // 1 byte ,127 to -127
            mybyte = 45;
            Console.WriteLine("My byte is" + mybyte);

            sbyte mybyte2 = -23; //1bit for sign and 7 bit are use to value
            Console.WriteLine("My sbite is" + mybyte2);
            short mys = 456; //2byte //32568 to -32567
            short mys2 = -7566;
            Console.WriteLine("My Short" + mys + mys2);

            int myint = 35642465; // 4byte//2^31to  2^-31
            Console.WriteLine("My int" + myint);

            long mylong = 901164051; //8byte 2^64
            Console.WriteLine("Mylong" + mylong);

            double myper = 65.32; //8byte
            Console.WriteLine("My percen" + myper);

            float myfloat = 45.65f; //4byte
            Console.WriteLine("Float is" + myfloat);
            Console.WriteLine("My Variables are.......");


        }
    }
}
