using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
                }Console.WriteLine("Player: " + player);Console.WriteLine("-------------------------");
                
                switch (random.Next(1, 4))
                {
                    case 1:
                    computer = "ROCK";
                    break;
                    case 2:
                    computer = "PAPER";
                    break;
                    case 3:
                    computer = "SCISSORS";
                    break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);
                
                switch (player)
                {
                    case "ROCK":
                    if (computer == "ROCK")
                        {
                            Console.WriteLine("It 's a draw!");
                        }
                    else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                    else 
                        {
                            Console.WriteLine("You win!");
                        }
                    break;
                    case "PAPER":
                    if (computer == "PAPER")
                        {
                            Console.WriteLine("It 's a draw!");
                        }
                    else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                        }
                    else 
                        {
                            Console.WriteLine("You win!");
                        }
                    break;
                    case "SCISSORS":
                    if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It 's a draw!");
                        }
                    else if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                    else 
                        {
                            Console.WriteLine("You win!");
                        }
                    break;
                
                }
                Console.WriteLine("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            
            Console.WriteLine("Thanks for playing!");
        }
    }
}
