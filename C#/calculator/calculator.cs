using System;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do 
            {

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                System.Console.WriteLine("Enter number 1:");
                num1 = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Enter number 2:");
                num2 = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Enter an option:");
                System.Console.WriteLine(" \t+  ");
                System.Console.WriteLine(" \t-  ");
                System.Console.WriteLine(" \t*  ");
                System.Console.WriteLine(" \t/  ");
                System.Console.WriteLine("ENTER AN OPTION: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        System.Console.WriteLine($"Your result: {num1}+{num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        System.Console.WriteLine($"Your result: {num1}-{num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        System.Console.WriteLine($"Your result: {num1}*{num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        System.Console.WriteLine($"Your result: {num1}/{num2} = " + result);
                        break;
                    default:
                            Console.WriteLine("That was not a valid option");
                            break;      
                }
                System.Console.WriteLine("Would you wanna play again?: (Y/N): ");
                
            }while(Console.ReadLine().ToUpper()== "Y");
            System.Console.WriteLine("Bye");
            
            Console.ReadKey();
        }
    }
}