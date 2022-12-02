using System;

namespace statickkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            // rather than to any specific object

            // static = công cụ sửa đổi để khai báo một thành viên tĩnh, thuộc về chính lớp đó
            // thay vì bất kỳ đối tượng cụ thể nào




            Car car1 = new Car("Mustang" );
            Car car2 = new Car( "Masdasdasdg");

            Car car3 = new Car("Mfgshasdasdg");

            Car car4 = new Car("Masdsdfgsdfgsdfgsdfgasdasdg");


            System.Console.WriteLine(Car.numberOfCars);
            Car.StartRace();
 
            Console.ReadKey();
        }
    }
    class Car
    {
       
        String model;
        public static int numberOfCars;
        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            System.Console.WriteLine("The race has begun");
        }
    }
      


}

