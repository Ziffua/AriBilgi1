using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Opertators
{
    internal class Bitwise
    {
        public static void BitwiseMain() {

            byte a = 14; // 0000 1110
            byte b = 9; // 0000 1001 
            float e = 9f; // 0000 1001 
            byte c = 16; // 0001 0000
            byte d = 4; // 0000 0100
            sbyte f = -5;
            

            Console.WriteLine(16<<1);
            Console.WriteLine(16>>1);
            Console.WriteLine(a>>1);

            // << multipies by 2; << n multipies by 2^n
            // >> divides by 2; >> n divides by 2^n

            Console.WriteLine(a | 3);
            Console.WriteLine(a & b);


            Console.WriteLine(~b);
            Console.WriteLine(~c);
            Console.WriteLine(~d);
            Console.WriteLine(~f);

        }
    }
}
