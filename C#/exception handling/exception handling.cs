using System;
namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception = errors that occur during execution
            // try = try some code that is considered " dangerous " 
            // catch = cathes and handles exceptions when they occur 
            // finally = always executes regardless if exception is caught or not 
            ///Exception = lỗi xảy ra trong quá trình thực thi
            // thử = thử một số mã được coi là " nguy hiểm "
            // catch = cathes và xử lý ngoại lệ khi chúng xảy ra
            // cuối cùng = luôn thực thi bất kể ngoại lệ có bị bắt hay không


            double   x ; 
            double y; 
            double  result;
            try{
                System.Console.Write("Enter num1: ");
                x = Convert.ToInt32(Console.ReadLine());


                System.Console.Write("Enter num2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                System.Console.WriteLine("Result : " + result);
            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Enter only number plz");
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("You can't divide by zero'");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Something went wrong'");
            }
            finally
            {
                System.Console.WriteLine("Thanks for visiting");
            }



            Console.ReadKey();

        }
    }
}