using System;

namespace constructorscars
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructors = A special method in a class
            // same name as the class name
            // can be used to assign arguments to fields when creating an object

            // constructors = Một phương thức đặc biệt trong một lớp
            // tên giống tên lớp
            // có thể được sử dụng để gán đối số cho các trường khi tạo một đối tượng


            Car car1 = new Car("For","Mustang", 2022, "red");
            Car car2 = new Car("asdasd", "Masdasdasdg", 2222, "adsfd");
            car1.Drive();
            car2.Drive();

            
            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make= make;
            this.model= model;
            this.year= year;
            this.color= color;
        }

        public void Drive()
        {
            System.Console.WriteLine("you drive the " + make + " " + model );
        } 
    }

   
}


