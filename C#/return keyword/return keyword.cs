using System;
namespace returnkeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // return = return data back to the place where a method is invoked

            double x ;
            double y;
            double result;

            System.Console.WriteLine("Enter in num1: ");
            x = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Enter in num2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiline(x,y);
            System.Console.WriteLine(result);
            Console.ReadKey();
        }
        static double Multiline(double x , double y )
        {
            double z = x * y;
            return z; 
        }
    }
}