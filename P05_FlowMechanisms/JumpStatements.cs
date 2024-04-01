using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class JumpStatements
    {

        public static void Main(string[] args)
        {
            // BREAK, CONTINUE, GOTO, RETURN

            #region for and while
            //    int x;

            //Input:
            //    Console.Write("Number : ");
            //    x = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < 15; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine("\nContinue " + i);
            //            continue;
            //            Console.WriteLine("Can't see this");
            //        }
            //        if (i == 11)
            //        {
            //            Console.WriteLine("\nBreaking Bad " + i);
            //            break;
            //            Console.WriteLine("Invisiblee...");
            //        }
            //        Console.WriteLine("\nUsual : " + i);
            //        Console.WriteLine("LastLine");

            //    }
            //    Console.WriteLine("\nOut of FOR");

            //    Console.WriteLine("While: ");
            //    while (x < 12)
            //    {
            //        if (x == 11)
            //        {
            //            Console.WriteLine($"\nX is {x}; GO TO Input and...");
            //            goto Input;
            //        }
            //        if (x == 3)
            //        {
            //            Console.WriteLine("RETURNN");
            //            return;
            //        }
            //        Console.WriteLine("Usual while : " + x);

            //        x++;
            //    }
            //    Console.WriteLine("Out of WHILE");

            #endregion

            #region switch goto

            //label1:
            //    Console.Write("Key : ");
            //    int a = Convert.ToInt32(Console.ReadLine());

            //    switch (a)
            //    {
            //        case 0:
            //            Console.WriteLine("End of the Program (RETURN)");
            //            return;
            //        case 1:
            //            Console.WriteLine("Case 1");
            //            break;
            //        case 2:
            //        case 3:
            //            Console.WriteLine("Case 2 or 3");
            //            break;
            //        case 4:
            //            Console.WriteLine("GOTO");
            //            goto label1;
            //        case 5:
            //            Console.WriteLine("Case 5");
            //            break;
            //        case 6:
            //            Console.WriteLine("Case 6 (goto case5)");
            //            goto case 5;
            //        default:
            //            Console.WriteLine("Try again (GOTO)");
            //            goto label1;
            //    }
            //    Console.WriteLine("Out of Switch");

            #endregion

            #region nested for
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("First : " + j);
            //        if (j == 1) break;
            //    }
            //    Console.WriteLine("\nSecond : " + i + "\n");
            //    break;
            //}
            //Console.WriteLine("I'm OUT");

            #endregion

            #region nested for 2
            //for (int outer = 0; outer < 5; outer++)
            //{
            //    for (int inner = 0; inner < 5; inner++)
            //    {
            //        if (inner > outer)
            //        {
            //            break;
            //        }

            //        Console.Write($"{inner} ");
            //    }
            //    Console.WriteLine();
            //}
            //// Output:
            //// 0
            //// 0 1
            //// 0 1 2
            //// 0 1 2 3
            //// 0 1 2 3 4

            #endregion

            #region Others 
            //Double zero = 0;
            //double a;
            //a = double.NaN;
            ////a = float.NaN;

            //Console.WriteLine(a);

            //if (0/zero  == double.NaN)
            //    Console.WriteLine("It's nan my dude");
            //else Console.WriteLine(a/2);

            #endregion

            #region Other 2
            //int[] xs = new int[] { 10, 20, 30, 40 };
            //ref int found = ref FindFirst(xs, s => s == 30);
            //found = 99;
            //Console.WriteLine(string.Join(" ", xs));  // output: 10 20 0 40

            //ref int FindFirst(int[] numbers, Func<int, bool> predicate)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (predicate(numbers[i]))
            //        {
            //            return ref numbers[i];
            //        }
            //    }
            //    throw new InvalidOperationException("No element satisfies the given condition.");
            //}

            #endregion


        }
    }
}
