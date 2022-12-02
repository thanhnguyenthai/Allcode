using System;
namespace arithmeticoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;
            double ok = 7;
            //friends = friends + 1;
            //friends += 1;
            //friends++;

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 1;
            //friends *= 1;

            //ok = ok / 2;
            //ok /= 2;

            int remainder = friends % 2;
            
            System.Console.WriteLine(remainder);

            System.Console.WriteLine(ok);

            System.Console.WriteLine(friends);
            
            Console.ReadKey();
        }
    }
}