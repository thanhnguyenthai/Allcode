using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. From a common parent 
            // kế thừa = 1 hoặc nhiều lớp con nhận các trường, phương thức, v.v. Từ một cha chung
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            System.Console.WriteLine(car.speed);
            System.Console.WriteLine(car.wheels);
            car.go();


            System.Console.WriteLine(bicycle.speed);
            System.Console.WriteLine(bicycle.wheels);
            bicycle.go();


            System.Console.WriteLine(boat.speed);
            System.Console.WriteLine(boat.wheels);
            boat.go();
        
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            System.Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}

