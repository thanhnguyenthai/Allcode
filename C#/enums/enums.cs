using System;
using System.Collections.Generic;
namespace enums

{
    class Program
    {
        private const long V = 1000000000000;

        static void Main(string[] args)
        {

            // enums = special " class " that contains a set of named integer constants
            // use enums when you have values that you know will not change,
            // To get the integer value from an item, you must explicitly convert to an int

            // name = integer 

            //enums = " class " đặc biệt chứa một tập hợp các hằng số nguyên được đặt tên
            // sử dụng enums khi bạn có giá trị mà bạn biết sẽ không thay đổi,
            // Để lấy giá trị số nguyên từ một mục, bạn phải chuyển đổi rõ ràng thành int

            // tên = số nguyên



/*
            System.Console.WriteLine(Planets.Pluto+ " is a planet");
            System.Console.WriteLine(Planets.Pluto.ToString() + " is a planet");
            System.Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            System.Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
*/



        String name= PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;
        double volume = Volume(PlanetRadius.Earth);

        System.Console.WriteLine("Planet: " + name);
        System.Console.WriteLine("Radius: " + radius + " km ");
        System.Console.WriteLine("Volume: " + volume + " km^3");
            Console.ReadKey();
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius,3);
            return volume;
        }
    }
   enum Planets
   {
    Mercury = 1 , 
    Venus = 2 ,
    Earth = 3 , 
    Mars = 4 ,
    Jupiter = 5 ,
    Saturn = 6 ,
    Uranus = 7 ,
    Neptune = 8,
    Pluto = 9,
   }
   enum PlanetRadius
   {

        Mercury = 12,
        Venus = 23,
        Earth = 34,
        Mars = 45,
        Jupiter = 56,
        Saturn = 67,
        Uranus = 78,
        Neptune = 89,
        Pluto = 90,
   }
}
