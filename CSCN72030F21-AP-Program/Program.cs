﻿using System;
using CSCN72030F21_AP_Classes;

namespace CSCN72030F21_AP_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            const string dataFile = "..\\Data\\";   //"macro for file path
            Console.WriteLine("true = {0}, false = {1}", Convert.ToInt32(true), Convert.ToInt32(false));
            //testing for HardwareIO
            /*
            HardwareIO test = new HardwareIO((dataFile+"test.txt"), true);
            test.fileUpdate("testone\ntesttwo\ntestThree\n");

            Console.WriteLine("Line 2 is: {0}",test.fileGet(4));
            */
        }
    }
}