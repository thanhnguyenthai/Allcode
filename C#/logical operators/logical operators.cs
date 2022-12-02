using System;
namespace logicaloperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators= Can be used to check if more than 1 condition is true/false

            // $$ (AND)
            // || (OR)
            
            System.Console.WriteLine("What is the temp? ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                System.Console.WriteLine("Its warm outside");
            }

            else if  (temp <= -50 || temp >= 50 )
            {
                System.Console.WriteLine("Its dangerous outside");
            }


            Console.ReadKey();
        }
    }
}