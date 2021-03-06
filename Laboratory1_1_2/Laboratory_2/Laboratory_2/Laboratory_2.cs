﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_2
{
    class Laboratory_2
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, sb, sh, ush, i, ui, l, ul, de, fl, do
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)
            bool boo = true;
            char ch= 'c';
            byte b=1;
            sbyte sb=3;
            short sh=12;
            ushort ush=13;
            int i=16;
            uint ui=17;
            long l=1876763;
            ulong ul=1289312;
            decimal de=51.0M;
            float fl=1.2f;
            double db=1.23; // cannot named do
            //2) declare constants of int and double. Try to change their values.

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
            var vr = 20;
            var vb = 20.5;
            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and do. Is it possible?
            System.Int32 ii= 14;//exsist
            System.Double dbb = 20.2;//do is C# keyword
            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
                //int i = 16; exsist
                //do is C# keyword
                // 6) change values of variables from 1)
                i = 500;
            }

            // 7)check values of variables from 1). Are they changed? Think, why
            Console.WriteLine("Variable is:{0}", i);
            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            // Fix compilation errors (in case of impossible conversion commemt that line).
            i = (int)ch;
            //boo = (bool)sh; //cannot convert
            //do = l; //error
            fl = ch;
            //de = do; error
            b = (byte)ui; //can loose data
            ul = (ulong)sb;
            // 9) and reverse conversion with fixing compilation errors.

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int? nuulType = null;
            // i =nuul,error because i is int;
        }
    }
}
