using System;
namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true

            
            String name = ""; 

            while (name == "")
            {
                System.Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }
            System.Console.WriteLine("Hello "+ name);   

            Console.ReadKey();
        }
    }
}