using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class ArrayBasics
    {
        public static void main(string[] args)
        {
            #region Intro
            int[] ar1 = new int[5];
            string[] arName = new string[5];

            ar1[2] = 3;
            arName[2] = "three";

            string name="abcdefg";
            Console.WriteLine(name[2]);

            int[,] ma1 = new int[3, 3];
            ma1[2,3] =1;
            int[,] ma2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            #endregion



        }
    }
}
