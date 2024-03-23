using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Opertators
{
    internal class Logical
    {
        public static void LogicalMain() 
        {
            bool a = 35 > 10 && 10 == 50; // 1 AND 0 = false
            bool b = 35 > 10 && 10 != 50; // 1 AND 1 = true
            bool c = 35 > 10 || 10 == 50; // 1 OR 0 = true
            bool d = 5 is int || 10 * 3 == 5; // 1 OR 0 = true
            bool e = "Text" is int || 10 * 3 == 5; // 0 OR 0 = false

            Console.WriteLine("Result: \n{0},\n{1},\n{2},\n{3},\n{4}",a,b,c,d,e);

            //Tenary
            Console.WriteLine("Enter 5");
            string key = Console.ReadLine();
            string text = int.Parse(key) == 5 ? "good" : 5.ToString();
            Console.WriteLine(text == "good"?"It is 5":"So bad");

        }
    }
}
