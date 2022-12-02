using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            // can be used as a blueprint to create objects (OOP)
            // class = Một gói mã liên quan.
            // có thể được sử dụng làm bản thiết kế để tạo đối tượng

            
            Message.Hello();
            Message.Waiting();
            Message.Bye();
            Console.ReadKey();

        }
    }
    static class Message
    {
        public static void Hello()
        {
            System.Console.WriteLine("Hello my friend");
        }
        public static void Waiting()
        {
            System.Console.WriteLine("Im waiting for you");
        }
        public static void Bye()
        {
            System.Console.WriteLine("Goodbye");
        }
    }

}