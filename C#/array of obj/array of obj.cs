using System;
namespace arrayofobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            

         
            Car[] garage ={new Car("1"), new Car("2"), new Car("3")};
            foreach (Car car in garage)
            {
                System.Console.WriteLine(car.model);
            }
            Console.ReadKey();            
    
        }
    }
    class Car
    {
        public String model;
        public Car (String model)
        {
            this.model = model;
        }
    }
}