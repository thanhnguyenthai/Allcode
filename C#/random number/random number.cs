using System;
namespace randomnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //int num = random.Next(1, 21) + 100;

            //int num = random.Next(1, 21);
            // double num = random.NextDouble();


            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            System.Console.WriteLine(num1);
            System.Console.WriteLine(num2);
            System.Console.WriteLine(num3);
            Console.ReadKey();
        }
    }
}