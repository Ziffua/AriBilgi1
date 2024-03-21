namespace P02_VariableWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c, d;
            //int f = 10, g, h = 5;

            //var x = 15;
            //var y = 'A';
            //var z = "Yoo";
            //var t = h;

            //int toplam = f + h + x;

            //Console.WriteLine(z+toplam.ToString()+toplam);
            //Console.WriteLine(toplam+toplam+"\n"+toplam.ToString()+toplam.ToString());

            
            //TESTS-------------------------------

            int a = 5;
            string b = "10";
            string c = "Yoo";
            //int d = null;
            string e = null;
            string? g = null;
            int? f = null;

            //int iTOs = b;
            //int iTOs = (int)b;
            //int iTOs = b as int;
            //int iTOs = int.Parse(b); // works
            //int iTOs = Convert.ToInt32(b); // works
            //int iTOs = Convert.ToInt32(c); // works


            //string sTOi = a;
            //string sTOi = (string)a;
            //string sTOi = a as string;
            //string sTOi = Convert.ToString(a); //works
            //string sTOi = a.ToString(); //works
            //string sTOi = string.Format("{0}",a); //works **

            void nullableParameter(int? a)
            {
                Console.WriteLine("Hi, " + a);
            }

            void withDefaultValue(int b = 0, int c = 1)
            {
                Console.WriteLine("Hi, " + b + " " + c);
            }

            nullableParameter(null);
            withDefaultValue();
            withDefaultValue(5);
            withDefaultValue(5, 10);
           
            /* Hi,
               Hi, 0 1
               Hi, 5 1
               Hi, 5 10 */


            string iAmNull = null;
            //string iAmNull = "Potato";

            Console.WriteLine(iAmNull ?? "That is null");
            //Console.WriteLine(iAmNull ??= "That is null");
             Console.WriteLine(iAmNull);

            //Console.WriteLine(iAmNull.ToString()); //null olduğu için ToString hata veriyor
            Console.WriteLine(iAmNull?.ToString()); //? sayesinde önemsemeyip null döndürüyor
            Console.WriteLine(iAmNull?.ToString() ?? "triple question mark");


        }
    }
}
