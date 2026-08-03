using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            // We can create player objects and add them to the list like this:
            //Player player1 = new Player("Alice");
            //Player player2 = new Player("Bob");
            //Player player3 = new Player("Steve");

            //players.Add(player1);
            //players.Add(player2);
            //players.Add(player3);

            // OR we can do it like this, which is more efficient and cleaner:
            players.Add(new Player("Alice"));
            players.Add(new Player("Bob"));
            players.Add(new Player("Steve"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
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
