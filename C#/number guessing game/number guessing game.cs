using System;
namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            String response;


            while (playagain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min,max+1);

                while (guess != number)
                {
                    System.Console.WriteLine("Guess a number between" + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Guess : "+ guess);

                    if ( guess > number)
                    {
                        System.Console.WriteLine(guess + " is too high");
                    }
                    else if ( guess < number)
                    {
                        System.Console.WriteLine(guess + " is too low");
                    }

                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                System.Console.WriteLine("You Win");
                System.Console.WriteLine("Guesses " + guesses);

                System.Console.WriteLine("Would you wanna play again? (y/n)");
                response = Console.ReadLine();
                response = response.ToUpper();
                
                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }
                
            }
            
            System.Console.WriteLine(" Thanks for playing");
            Console.ReadKey();
        }
    }
}