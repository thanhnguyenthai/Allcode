using System;
namespace objectsasarguments
{
    class Program
    {
        static void Main(string[] args)
        {
                 
           Car car1 = new Car("1","red");
            
            Changecolor(car1,"Silver");
            System.Console.WriteLine(car1.color + " " + car1.model);
            Console.ReadKey();            
    
        }

        public static void Changecolor(Car car, String color)
        {
            car.color = color ;
        }
    }
    class Car
    {
        public String model;
        public String color;
        public Car (String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}