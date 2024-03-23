using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TypeConversion
{
    internal class Implicit
    {
        public static void Main(string[] args)
        {
            byte a = 10;
            short b = 20;
            sbyte c = -5;

            int sum = a + b + c; // implicit type conversion

            string e = "An interesting text";
            char f = 'A';

            object g = e + " " + f + " " + sum;
            var v = e + " " + f + " " + sum;

            long h = sum;
            float i = h;

            double j = i;
            double k = 21.6;

            Console.WriteLine("First: " + sum);
            Console.WriteLine("Second: " + g +" " + v);
            Console.WriteLine("Third: "+k+h);
            Console.WriteLine("Fourth: ",k);
            Console.WriteLine("Fifth: " + k);

        }
    }
}
