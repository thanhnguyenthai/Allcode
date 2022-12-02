using System;
namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {

            // constants = immutable values which are known at compile time and dont change for the life of the program
            // các giá trị không thay đổi được biết đến tại thời điểm biên dịch và không thay đổi đối với vòng đời của chương trình
            const double pi = 3.14159;

            Console.WriteLine(pi);
            
            Console.ReadKey();
        }
    }
}