using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class ArrayInLoops
    {   
        public static void Main(string[] args)
        {
            #region for/foreach
            //int[] numArray1 = { 1, 2, 3, 4, 5, 6,7,8};
            //int sum = 0;

            //foreach (int num in numArray1) sum += num;
            //Console.WriteLine(sum);

            //for (int i = 0; i < numArray1.Length; i++) sum += numArray1[i];
            //Console.WriteLine(sum);

            #endregion

            #region Determine if the numbers are negative or positive
            //int[] nums = { 1, -2, 3, -4, -5, 0, 6, 7, -8, 9, 10 };
            //foreach (int num in nums)
            //    if (num > 0) Console.WriteLine($"{num}\tpositive\n");
            //    else if (num == 0) Console.WriteLine($"{num}\tneutral\n");
            //    else Console.WriteLine($"{num}\tnegative\n");

            #endregion
            #region Classify numbers as negative or positive and display their amount
            //int[] nums = { 1, -2, 3, -4, -5, 0, 6, 7, -8, 9, 10 };
            //int n = 0, p = 0, z = 0;
            //foreach (int num in nums)
            //{
            //    if (num > 0)
            //    {
            //        Console.WriteLine($"{num}\tpositive\n");
            //        p++;
            //    }
            //    else if (num == 0)
            //    {
            //        Console.WriteLine($"{num}\tneutral\n");
            //        z++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num}\tnegative\n");
            //        n++;
            //    }
            //}
            //Console.WriteLine($"positive:\t{p}\nnegative:\t{n}\nneutral:\t{z}");

            #endregion
            #region Find vowel numbers and put them into a new array
            //char[] vows = ['a','e','i','o','u'];
            //char[] myVows=new char[char.MaxValue];
            //int index = 0;
            //int amount = 0;

            //Console.WriteLine("Text: ");
            //string text= Console.ReadLine().ToLower();

            //foreach (char l in text)
            //{
            //    foreach (char c in vows)
            //    {
            //        if (l == c)
            //        {
            //            myVows[index] = l;
            //            index++;
            //            amount++;
            //        }
            //    }
            //}

            ////for(int i=0; i < text.Length; i++)
            ////{
            ////    for(int j = 0; j < vows.Length; j++)
            ////    {
            ////        if (text[i] == vows[j])
            ////        {
            ////            myVows[index] = text[i];
            ////            index++;
            ////            amount++;
            ////        }
            ////    }
            ////}

            //Console.WriteLine(myVows);
            //Console.WriteLine("Amount of vowels: "+ amount);

            #endregion
        }
    }
}
