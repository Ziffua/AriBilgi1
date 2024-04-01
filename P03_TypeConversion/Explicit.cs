using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TypeConversion
{
    internal class Explicit
    {
        public static void Main(string[] args)
        {
            #region Intro
            //int r = 15;
            //byte s = (byte)r;

            //Console.WriteLine("Sum : "+(s+r).ToString());

            //Console.WriteLine(r.ToString());

            //double myDouble = 9.78;
            //int myInt = (int)myDouble;    // Manual casting: double to int

            //Console.WriteLine(myDouble);   // Outputs 9.78
            //Console.WriteLine(myInt);      // Outputs 9

            //int i1 = 5;
            //double d1 = 6.7;
            //long l1 = 33;
            ////int i2 = d1;
            //int i3 = (int)d1;
            ////int i4 = l1;
            //int i5 = (int)l1;

            //double d2 = i1;

            //long l2 = i1;

            //Console.WriteLine(i3);
            //Console.WriteLine(d2);
            //Console.WriteLine(i5);

            #endregion

            #region Char and String
            char c1 = 'C';
            string s1 = "S";
            string s2 = "LongString";

            //char c2 = s1;
            //char c3 = (char) s1;
            //char c4 = s1 as char;
            char c5 = s1[0];
            char c7 = char.Parse(s1);
            char c8 = Convert.ToChar(s1);

            Console.WriteLine(c5);
            try
            {
                char c6 = s1[1];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            //char c9 = Convert.ToChar(s2); // FormatException

            //string s3 = c1;
            //string s4 = (string)c1;
            string s5 = c1.ToString();
            s1 = s2;

            #endregion

            

        }
    }
}
