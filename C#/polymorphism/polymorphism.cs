using System;
namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism = Greek word that means to "have many forms"
            // objects can be identified by more than one type
            // Ex: A dog is also: Canine, Animal, Organism


            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
            Console.ReadKey();
        }
    }

    class Vehicle 
    {
       public virtual void Go()
       { }
    }

    class Car : Vehicle
    {
        public override void Go()
        {System.Console.WriteLine("The car is moving");}
    }
    class Bicycle : Vehicle
    {
public override void Go()
        { System.Console.WriteLine("The bicycle is moving"); }
    }
    class Boat : Vehicle
    {
public override void  Go()
        { System.Console.WriteLine("The boat is moving"); }
    }
}