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
            int r = 15;
            byte s = (byte)r;

            Console.WriteLine("Sum : "+(s+r).ToString());

            Console.WriteLine(r.ToString());



        }
    }
}
