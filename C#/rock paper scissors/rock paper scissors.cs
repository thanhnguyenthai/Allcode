using System;
namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer1;
            String answer;

            
            while (playAgain)
            {
                player = " ";
                computer1 = " ";
                answer = " ";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter: ROCK, PAPER OR SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                
                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer1 = "ROCK";
                        break;
                    case 2:
                        computer1 = "PAPER";
                        break;
                    case 3:
                        computer1 = "SCISSOR";
                        break;
                }

                System.Console.WriteLine("PLayer: " + player);
                System.Console.WriteLine("Computer: " + computer1);
            
                switch (player)
                {
                    case "ROCK":
                        if (computer1 == "ROCK")
                        {
                            System.Console.WriteLine("ITS A DRAW");
                        }
                        else if (computer1 == "PAPER")
                        {
                            System.Console.WriteLine("YOU LOSE IT");
                        }
                        else
                        {
                            System.Console.WriteLine("YOU WIN");
                        }
                        break;
                    case "PAPER":
                        if (computer1 == "ROCK")
                        {
                            System.Console.WriteLine("YOU WIN");
                        }
                        else if (computer1 == "PAPER")
                        {
                            System.Console.WriteLine("ITS A DRAW");
                        }
                        else
                        {
                            System.Console.WriteLine("YOU LOSE IT");
                        }
                        break;

                    case "SCISSOR":
                        if (computer1 == "ROCK")
                        {
                            System.Console.WriteLine("YOU LOSE IT");
                        }
                        else if (computer1 == "PAPER")
                        {
                            System.Console.WriteLine("YOU WIN");
                        }
                        else
                        {
                            System.Console.WriteLine("ITS A DRAW");
                        }
                        break;
                }

                System.Console.WriteLine("Would you wanna play again? (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if(answer == "Y")
                {
                    playAgain = true;
                }  
                else {
                    playAgain = false;
                }
            }

            System.Console.WriteLine("Thanks for playing");

            Console.ReadKey();
        }
    }
}

