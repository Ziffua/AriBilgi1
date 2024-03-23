using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class LoopBasics
    {

        public static void Main(string[] args)        
       {

            #region
            //int amount = 0;
            //Console.WriteLine("Enter the desired amount of the messages: ");
            //amount = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= amount; i++)
            //{
            //    Console.WriteLine(j + "- Yoo.. Wazzup??\n" );
            //}
            #endregion

            #region
            //int num1, num2;

            //Console.WriteLine("The first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = num1; i <= num2; i++)
            //{
            //    Console.WriteLine("Number - "+ i.ToString() + "\n");
            //}
            #endregion

            #region
            //int num3, num4, sum=0;

            //Console.WriteLine("The first number: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The second number: ");
            //num4 = Convert.ToInt32(Console.ReadLine());

            //for (int i = num3; i <= num4; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);
            #endregion

            #region multipy numbers by adding

            //int num11, num22, product=0;

            //Console.WriteLine("The first number: ");
            //num11 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The second number: ");
            //num22 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < num22; i++)
            //{
            //    product += num11;
            //}

            //Console.WriteLine(product);
            #endregion

            #region 6 signed numbers, add possitives and negatives separately
            //int number;
            //int sumPossitive = 0;
            //int sumNegative = 0;

            //Console.WriteLine("Please enter 6 numbers: ");
            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.WriteLine("Number " + i.ToString() + ": ");
            //    number = int.Parse(Console.ReadLine());
            //    if (number>0)
            //    {
            //        sumPossitive += number;
            //    }
            //    else sumNegative += number;
            //}

            //Console.WriteLine($"Sum of Possitives: {sumPossitive} \nSum of Negatives: "+ sumNegative);
            #endregion

            #region While
            //add numbers between 1-100

            //int num = 1, sum = 0;
            //while (num <= 100) sum += num++;
            //Console.WriteLine(sum);
            #endregion

            #region
            //digits of a number

            //Console.WriteLine("Enter a number to find its digit number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int digit = 0;
            //while (num > 0)
            //{
            //    digit++;
            //    num/= 10;
            //}
            //Console.WriteLine(digit.ToString());

            #endregion

            #region
            //Console.WriteLine("Enter a number to find its digit number");
            //ulong sayi = Convert.ToUInt64(Console.ReadLine());
            ////ulong sayi2 = ulong.Parse((Console.ReadLine()));
            //int digit2 = 0;
            //while (sayi > 0)
            //{
            //    digit2++;
            //    sayi /= 10;
            //}
            //Console.WriteLine(digit2.ToString());

            #endregion

            #region Do While
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);
            #endregion

            #region Do While2

            //char choice = 'c';
            //int num1, res = 0;
            //do
            //{
            //    Console.WriteLine("Enter a number: ");
            //    num1 = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case '+':
            //            res += num1;
            //            break;
            //        case '-':
            //            res -= num1;
            //            break;
            //        case 'x':
            //            res *= num1;
            //            break;
            //        case '/':
            //            res /= num1;
            //            break;
            //        default:
            //            res = num1;
            //            break;
            //    }
            //    Console.WriteLine("Select the operation (+, -, x, /, =): ");
            //    choice = char.Parse(Console.ReadLine());
            //} while (choice != '=');
            //Console.WriteLine($"Result: {res}");

            #endregion

            #region nested do while
            //char choice;
            //int num1, num2, resl = 0;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("+, -, *, /\n");
            //    choice = Convert.ToChar(Console.ReadLine());

            //    Console.WriteLine("\nFirst number: ");
            //    num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("\nSecond number: ");
            //    num2 = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case '+':
            //            Console.WriteLine("\nresult= " + (num1 + num2));
            //            break;
            //        case '-':
            //            Console.WriteLine("\nresult= " + (num1 - num2));
            //            break;
            //        case '*':
            //            Console.WriteLine("\nresult= " + (num1 * num2));
            //            break;
            //        case '/':
            //            Console.WriteLine("\nresult= " + (num1 / num2));
            //            break;
            //        default:
            //            Console.WriteLine("\nDefault");
            //            break;
            //    }
            //    Console.WriteLine("\nAgain? (y): ");
            //    choice = Convert.ToChar(Console.ReadLine());
            //} while (choice == 'y');

            #endregion

            //Console.ReadKey();
        }

    }
}
