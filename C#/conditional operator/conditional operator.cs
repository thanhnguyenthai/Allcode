using System;
namespace conditionaloperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true / false
            //toán tử điều kiện = được sử dụng trong phép gán điều kiện nếu điều kiện đúng / sai
            // (condition) ? x : y

            double temperature = 20;
            String message; 
/* // case1
            if ( temperature >= 15)
            {
                massage = "Its warm outside";
            }
            else {
                massage = "Its cold inside";
            }
            System.Console.WriteLine(massage);
*/
// case 2: 
            message = (temperature >= 15) ? "Its warm outside" : "Its cold outside";
            System.Console.WriteLine(message);

            Console.ReadKey();

        }
    }
}