using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int x; // declaration tờ khai
            x = 123; // intialization  sự khởi tạo
            int y = 321; // intialization  + declaration

            int z = x + y;
          
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            int age = x + y; // Whole integer
            double height= y-x;
            bool alive = true; // true / false
            char symbol = '#';
            String name ="WinKey";

            
            Console.WriteLine("Hello " +name);
            Console.WriteLine("Your ages is :" + age );
            Console.WriteLine("Your height is :" + height + "cm");
            Console.WriteLine("R you alive?" + alive);
            Console.WriteLine("Your symbol is :" + symbol);

            String username = symbol +name;
            Console.WriteLine("Your username is :" + username);
            Console.ReadKey();
        }
    }
}