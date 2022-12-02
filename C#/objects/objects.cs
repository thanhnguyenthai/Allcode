using System;

namespace objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class 
            // A class can be used as a blueprint to create objects (OOP)
            // Objects can have fields & methods (character & actions)
            // đối tượng = Một thể hiện của một lớp
            // Một lớp có thể được sử dụng làm bản thiết kế để tạo các đối tượng (OOP)
            // Đối tượng có thể có trường & phương thức (ký tự & hành động)

            Human human1 = new Human();

            Human human2 = new Human();


            
            human1.name = "WinKey";
            human1.age = 22;

            human1.Eat();
            human1.Sleep();


            human2.name = "WinKey2";
            human2.age = 23;

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            System.Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            System.Console.WriteLine(name + " is sleeping");
        }
    }


}