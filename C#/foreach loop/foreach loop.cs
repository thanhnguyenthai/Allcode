using System;
namespace foreachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            // for each loop  = a simpler way to iterate over an array, but its less flexible
            String[] cars = {"1","2","3"};
        /*
            for (int i = 0; i <cars.Length; i++)
            {
                 System.Console.WriteLine(cars[i]);
            }
        */    
            foreach(String car in cars)
            {
                    System.Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}