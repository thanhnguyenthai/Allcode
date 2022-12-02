using System;
namespace Typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting  = converting a value to a diff data type 
            // Useful when we accept user input (string)
            // Diff data types can do diff things

            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c);

            Console.WriteLine(b.GetType()); 
            Console.WriteLine(d);
        
            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(f);

            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);

            String i ="true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);


            Console.ReadKey();
        }
    }
}