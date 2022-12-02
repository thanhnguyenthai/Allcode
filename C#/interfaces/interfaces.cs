using System;
namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //  interface = defines a "contract " that all the classes inheriting from should follow 
            // An inheriting class defines " How it should do it "
            // benefit = security +multiple inheritance + " plug - and - play " 

            // giao diện = định nghĩa một "hợp đồng" mà tất cả các lớp kế thừa phải tuân theo
            // Lớp kế thừa định nghĩa " Nó nên làm như thế nào "
            // lợi ích = bảo mật + nhiều kế thừa + " plug - and - play "


            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            { System.Console.WriteLine("The rabbit runs away!"); }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            { System.Console.WriteLine("The Hawk fly away!"); }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            { System.Console.WriteLine("The fish swim away!"); }
        
            public void Hunt()
            { System.Console.WriteLine("The fish eat other thing!"); }
        }
    }
    
}
