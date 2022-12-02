using System;
namespace stringinterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            // precede a string literal with $
            // {} are placeholders

            // nội suy chuỗi = cho phép chúng ta chèn các biến vào một chuỗi ký tự
            // đứng trước một chuỗi ký tự bằng $
            // {} là phần giữ chỗ
            
            String fn = " Thai Thanh ";
            String ln = " Nguyen ";
            int age  = 22;

            System.Console.WriteLine("Hello "+ fn + " " + ln);
            System.Console.WriteLine("You are now "+ age + " years old");
            System.Console.WriteLine($"Hello {fn} {ln}.");
            System.Console.WriteLine($"You are {age, -10} years old" );
            Console.ReadKey();

        }
    }
}