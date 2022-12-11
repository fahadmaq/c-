﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Stdclass
    {
        // members --> field / variable/ data member
        // method, constructor, property, idexer, event
        // default access is private
        private int roll;
        private string stdname;
        private int sub1;
        private int sub2;
        private int sub3; 
        private int sub4;
        private int sub5;
        private float percentage;
        private double average;

        public Stdclass(int roll, string stdname, int sub1,int sub2, int sub3, int sub4, int sub5, float percentage, double average)
        {
            this.roll = roll; // this refers to the data member
            this.stdname = stdname;
            this.percentage = percentage;
            this.average = average;

        }
        public void CalculatePercentage()
        {
            percentage = (sub1 + sub2 + sub3 + sub4 + sub5) * 100 / 500;
        }
        // ToString() --> string representation of an object
        public void CalculateAverage()
        {
            average = sub5 + sub4 + sub3 + sub2 + sub1;
        }
        public override string ToString()
        {
            return $"Stdclass rollno {roll}, Student name {stdname} & percentage of std {percentage}";
        }

        //public string Print()
        //{
        //    return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
        //}
        public double GetAveragey()
        {
            return average;
        }
    }
}

   
