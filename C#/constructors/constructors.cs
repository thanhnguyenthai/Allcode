using System;

namespace constructors
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



            Human human1 = new Human("Winkey", 22);
            Human human2 = new Human("WinKey2 ", 23);


            
        
            human1.Eat();
            human1.Sleep();



            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

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