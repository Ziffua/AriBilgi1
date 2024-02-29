using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class ConditionBasics
    {
        public static void Main(string[] args)
        {
            #region User Authentication

            //Get two authentication information from the user and compare them with the predefined one
            //If both of them are matching then show welcome screen. Otherwise, show the unmatching information

            //string myUserName = "Admin";
            //string myPassword = "1234";

            //string userName;
            //string userPasword;

            //Console.WriteLine("Username: ");
            //userName = Console.ReadLine();

            //Console.WriteLine("Password" );
            //userPasword = Console.ReadLine();

            //if (userName == myUserName)
            //{
            //    if (userPasword == myPassword)
            //    {
            //        Console.WriteLine("Welcome, " + userName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password is incorrect, please try again");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Username is NOT correct");
            //}
            #endregion

            #region
            //Find the bigger number among two numbers read from the user

            //int num1;
            //int num2;

            //Console.WriteLine("Enter a number: ");
            //num1 = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));

            //Console.WriteLine("Enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine("The first number, " + num1 + ", is greater than " + num2);
            //}
            //else if (num2 > num1) Console.WriteLine("The second number, " + num2 + ", is greater than " + num1);
            //else Console.WriteLine("The numbers are equal");
            #endregion

            #region Daily Workout
            //Compare 3 numbers to find the greatest
            //int number, greater=0;

            //Console.WriteLine("First number: ");
            //number = int.Parse(Console.ReadLine());
            //greater = number;

            //Console.WriteLine("Second number: ");
            //number = int.Parse(Console.ReadLine());
            //if(number > greater) greater = number;

            //Console.WriteLine("Third number");
            //number = int.Parse(Console.ReadLine()) ;
            //if (number > greater) greater= number;

            //Console.WriteLine(greater);

            //Alternative
            //int sayi1, sayi2, sayi3;

            //Console.WriteLine("Sayi 1:");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sayi 1:");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sayi 1:");
            //sayi3 = int.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    if (sayi1 > sayi3)
            //    {
            //        Console.WriteLine($"En büyük sayi1: {sayi1}");
            //    }
            //}

            //if (sayi2 > sayi1 && sayi2 > sayi3)
            //{
            //    Console.WriteLine($"en büyük sayi2: {sayi2}");
            //}

            //if (sayi3 > sayi1 && sayi3 > sayi2)
            //{
            //    Console.WriteLine($"en büyük sayi3: { sayi3}");
            //}

            //smallest one
            //int number, smallest = 0;

            //Console.WriteLine("First number: ");
            //number = int.Parse(Console.ReadLine());
            //smallest = number;

            //Console.WriteLine("Second number: ");
            //number = int.Parse(Console.ReadLine());
            //if (number < smallest) smallest = number;

            //Console.WriteLine("Third number");
            //number = int.Parse(Console.ReadLine());
            //if (number < smallest) smallest = number;

            //Console.WriteLine(smallest);

            #endregion

            #region Switch   
            //while (true)
            //{
            //    Console.WriteLine("Choose a letter between a-e");
            //    char x = char.Parse(Console.ReadLine());

            //    switch (x)
            //    {
            //        case 'a':
            //            Console.WriteLine("Action A");
            //            break;
            //        case 'b':
            //            Console.WriteLine("Action B");
            //            break;
            //        case 'c':
            //            Console.WriteLine("Action C");
            //            break;
            //        case 'd':
            //            Console.WriteLine("Action D");
            //            break;
            //        case 'e':
            //            Console.WriteLine("Action E");
            //            break;
            //        case 'f':
            //            Console.WriteLine("Directing to Case D...");
            //            goto case 'd';
            //        case 'g':
            //        case 'h':
            //        case 'i':
            //            Console.WriteLine("Selected G/H/I");
            //            break;
            //        default:
            //            Console.WriteLine("Please choose a character between the interval");
            //            break;
            //    }
            //}
            
            #endregion
            //https://github.com/UCC12-AriBilgi/CS101-Live

            #region

            #endregion

        }
    }
}
