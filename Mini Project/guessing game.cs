using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
             Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;
            String minmax;

            while (playAgain)
            {
                Console.WriteLine("Welcome to my guessing game in this game you should guess a number between " + min + " - " + max);
                Console.WriteLine("Do you want to change the minimum and maximum numbers? (Y/N):");
                minmax = Console.ReadLine();
                minmax = minmax.ToUpper();
                if (minmax == "Y")
                {
                    Console.WriteLine("Enter the minimum number: ");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Now enter the maximum number: ");
                    max = Convert.ToInt32(Console.ReadLine());
                }
                    
                
                    guess = 0;
                    guesses = 0;
                    response = "";
                    number = random.Next(min, max + 1);
                
                    while (guess != number)
                    {
                        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);

                        if (guess > number)
                        {
                            Console.WriteLine(guess + " is too high!");
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(guess + " is too low!");
                        }
                        guesses++;
                    }
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine("Guesses: " + guesses);

                    Console.WriteLine("Would you like to play again (Y/N): ");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

            Console.WriteLine("Thanks for playing! ... I guess");
        }
    }
}
