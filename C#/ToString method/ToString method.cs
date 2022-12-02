using System;
namespace ToStringmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = converts an object to its string representation so that it is suitable for display .
            // ToString() = chuyển đổi một đối tượng thành biểu diễn chuỗi của nó sao cho phù hợp để hiển thị
            Car car = new Car("1","2",2022,"Red");

            System.Console.WriteLine(car);
            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model,int year,String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            // way 1: 
            /*
            String massage = "This is a " + make + " " + mode;
            return base.ToString();
            */
            //Way 2:
            return "This is a " + make + " vs " + model;
        }
    }
}