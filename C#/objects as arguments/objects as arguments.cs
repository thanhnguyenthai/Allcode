using System;
namespace objectsasarguments2
{
    class Program
    {
        static void Main(string[] args)
        {
                 
           Car car1 = new Car("1","red");
            
            Car car2 = Copy(car1);
            System.Console.WriteLine(car2.color + " " + car2.model);
            Console.ReadKey();            
    
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
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