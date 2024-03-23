using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace P02_VariableWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            //int a, b, c, d;
            //int f = 10, g, h = 5;

            //var x = 15;
            //var y = 'A';
            //var z = "Yoo";
            //var t = h;
            //bool bo = 5 < 4; // false
            //string s = y + z + f;

            //int toplam = f + h + x;

            //Console.WriteLine(z + toplam.ToString() + toplam);
            //Console.WriteLine(z + toplam + toplam);
            //Console.WriteLine(toplam + toplam + "\n" + toplam.ToString() + toplam.ToString());
            //Console.WriteLine(toplam + toplam + "\n" + toplam + toplam);
            ////if there is a string before the number, it converts all the following numbers into string
            #endregion

            #region Constant
            //use PascalCase to name
            const float Pi = 3.14f;
            const string PrgName = "P02_VariableWorld";

            #endregion

            #region Variables and their size
            //a byte is 8 bits; byte 5 -> 0000 0101; int 5 (32 bits)-> 0000 0000 0000 0000 0000 0000 0000 0101 
            //all the 28 bits occupies space in the memory without contributing storage of value 5
            byte bytie = 255; // 0-255; 8 bit (1 byte); unsigned so all bits are used to represent the magnitude
            sbyte sbytie = -128; // (-128)-127; 7 bits are used for the magnitude and the leftmost bit for the sign (0 positive, 1 negative) 
            int intie = 2000000000; //-2bil-2bil; 32 bit; leftmost bit is used for sign 
            float floating = 15.7f; // 32 bit
            uint unsigned = (-2000000000)*(-1);//0-4bil; 32 bits all representing the magnitude
            double doubbie = 1319.5; //64 bit; signed
            decimal decie = 5.5m; // 128 bit; smaller value than double but more precise. Used for financial and monetary calculations requiring high precision
            char charizard = '\0';// 16 bit; \0 represents a null character
            string sting = "First Part \0 Second part";// 16 bit;
            //Console.WriteLine(sting);
            bool boo= false; // 8 bits

            #endregion

            #region Test
            //int a = 5;
            //string b = "10";
            //string c = "Yoo";
            ////int d = null;
            //string e = null;
            //string? g = null;
            //int? f = null;

            ////int iTOs = b;
            ////int iTOs = (int)b;
            ////int iTOs = b as int;
            ////int iTOs = int.Parse(b); // works
            ////int iTOs = Convert.ToInt32(b); // works
            ////int iTOs = Convert.ToInt32(c); // works


            ////string sTOi = a;
            ////string sTOi = (string)a;
            ////string sTOi = a as string;
            ////string sTOi = Convert.ToString(a); //works
            ////string sTOi = a.ToString(); //works
            ////string sTOi = string.Format("{0}",a); //works **

            //void nullableParameter(int? a)
            //{
            //    Console.WriteLine("Hi, " + a);
            //}

            //void withDefaultValue(int b = 0, int c = 1)
            //{
            //    Console.WriteLine("Hi, " + b + " " + c);
            //}

            //nullableParameter(null);
            //withDefaultValue();
            //withDefaultValue(5);
            //withDefaultValue(5, 10);

            ///* Hi,
            //   Hi, 0 1
            //   Hi, 5 1
            //   Hi, 5 10 */


            //string iAmNull = null;
            ////string iAmNull = "Potato";

            //Console.WriteLine(iAmNull ?? "That is null");
            ////Console.WriteLine(iAmNull ??= "That is null");
            // Console.WriteLine(iAmNull);

            ////Console.WriteLine(iAmNull.ToString()); //null olduğu için ToString hata veriyor
            //Console.WriteLine(iAmNull?.ToString()); //? sayesinde önemsemeyip null döndürüyor
            //Console.WriteLine(iAmNull?.ToString() ?? "triple question mark");
            #endregion

            #region MyRegion
            //int a = 5,b=6,c=a+b;
            //Console.WriteLine("Sum: "+a+b);
            //Console.WriteLine("Sum: "+(a+b));
            //Console.WriteLine("Sum: "+c);
            #endregion

        }
    }
}
