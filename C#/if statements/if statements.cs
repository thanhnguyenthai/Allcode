using System;
namespace ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // If statement = a basic form of decision making

            /*

                System.Console.WriteLine("Please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    System.Console.WriteLine("You are adult");
                }
                else if (0 <= age)
                {
                    System.Console.WriteLine("You are a child");
             /   }
                else if (age < 0)
                {
                    System.Console.WriteLine("You havent been born yet");
                }
                else
                {
                    System.Console.WriteLine("PLease do it again");
                }

            */
//-----------------------------
            /*
                System.Console.WriteLine("Please enter your name");
                String name = Console.ReadLine();


                if (name == "")
                {
                    System.Console.WriteLine("You didnt enter your name");
                }
                else 
                {
                    System.Console.WriteLine("Hello " + name);
                }
            */
//----------------------------------------
                System.Console.WriteLine("Please enter your name");
                String name = Console.ReadLine();


                if (name != "")
                {
                System.Console.WriteLine("Hello " + name);
                    
                }
                else
                {
                System.Console.WriteLine("You didnt enter your name");
                }




            Console.ReadKey();
        }
    }
}