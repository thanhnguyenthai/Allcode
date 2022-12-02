using System;
namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size
          //  String[] cars = {"1", "2","3"};

        /*
            cars[3]= "4";
            System.Console.WriteLine(cars[0]);
            System.Console.WriteLine(cars[1]);
            System.Console.WriteLine(cars[2]);
            System.Console.WriteLine(cars[3]);
        */



String[] cars = new string[3];
cars[0] = "1";
cars[1] = "2";
cars[2] = "3";
            for (int i = 0; i <cars.Length; i++)
            {
                System.Console.WriteLine(cars[i]);
            }

        
            Console.ReadKey();
        }
    }
}