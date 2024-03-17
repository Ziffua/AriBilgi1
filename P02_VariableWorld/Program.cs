namespace P02_VariableWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int f = 10, g, h = 5;

            var x = 15;
            var y = 'A';
            var z = "Yoo";
            var t = h;

            int toplam = f + h + x;

            Console.WriteLine(z+toplam.ToString()+toplam);
            Console.WriteLine(toplam+toplam+"\n"+toplam.ToString()+toplam.ToString());


        }
    }
}
