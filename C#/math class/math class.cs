using System;
namespace mathclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14;
            double y = 5;

            double a = Math.Pow(x, 3);
            System.Console.WriteLine(a);

            double b = Math.Sqrt(x);
            System.Console.WriteLine(b);

            double c = Math.Abs(x);
            System.Console.WriteLine(c);

            double d = Math.Round(x);
            System.Console.WriteLine(d);

            double e = Math.Ceiling(x);
            System.Console.WriteLine(e);

            double f = Math.Floor(x);
            System.Console.WriteLine(f);

            double g = Math.Max(x,y);
            System.Console.WriteLine(g);

            double h = Math.Min(x,y);
            System.Console.WriteLine(h);
            
            Console.ReadKey();
        }
    }
}