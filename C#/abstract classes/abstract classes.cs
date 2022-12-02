using System;

namespace abstractclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates missing components or incomplete implementation
            // lớp trừu tượng = công cụ sửa đổi cho biết các thành phần bị thiếu hoặc triển khai không đầy đủ

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle();


            Console.ReadKey();
        }
    }

    abstract class Vehicle
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

