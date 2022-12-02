using System;
namespace userinput
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            System.Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Hello "+ name);
            System.Console.WriteLine("Your age is: " + age + "years old");

            
            Console.ReadKey();
        }
    }
}