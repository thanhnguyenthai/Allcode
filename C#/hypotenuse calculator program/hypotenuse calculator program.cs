using System;
namespace hypotenusecalculatorprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter side A");
            double a = Convert.ToDouble(Console.ReadLine());


            System.Console.WriteLine("Enter side B");
            double b = Convert.ToDouble(Console.ReadLine());
           
            double c = Math.Sqrt((a * a) + (b * b));
            System.Console.WriteLine("The hypotenue is: " + c);

            Console.ReadKey();
        }
    }
}