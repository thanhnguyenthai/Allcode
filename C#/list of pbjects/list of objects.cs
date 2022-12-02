using System;
using System.Collections.Generic;
namespace listofobject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Player> players = new List<Player>();

          
            players.Add(new Player("Winkey"));
            players.Add(new Player("hahahah"));
            players.Add(new Player("hahahah"));

            foreach (Player player in players)
            {
                System.Console.WriteLine(player.username);
            }

            Console.ReadKey();  
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
    
}
