using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class Cc
    {
        int crnum;
        string crname;
        string crcolor;
        double crprice;
        
        public void AcceptDetails(int scrnum, string scrname, string scrcolor,double mcrprice)
        {
            crnum = scrnum;
            crname = scrname;
            crprice = mcrprice;
            crcolor = scrcolor;



        }
        public void Display()
        {
            Console.WriteLine("Model num is " + crnum);
            Console.WriteLine("Car name is " +  crname);
            Console.WriteLine("cAR PRICE IS " + crprice);
            Console.WriteLine("cAR Color IS " + crcolor);
        }
        static void Main(string[] args)
        {
            Cc car = new Cc();
            car.AcceptDetails(101, "tesla","White",5600);
            car.Display();

        }
    }
}
