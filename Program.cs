using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerMove = string.Empty;
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string input = Console.ReadLine();

            if (input == "r" || input == "rock")
            {
                playerMove = "Rock";
            }
            else if (input == "p" || input == "Paper")
            {
                playerMove = "Paper";
            }
            else if (input == "s" || input == "Scissors")
            {
                playerMove = "Scossors";
            }
            else
            {
                Console.WriteLine("Wrong input. Try agen . . .");
                return;
            }

            Random random= new Random();
            int computRandomMove = random.Next(1,4);

            string ComputerMove = String.Empty;
            if (computRandomMove == 1)
            {
                ComputerMove = "Rock";
            }
            else if (computRandomMove == 2) 
            {
                ComputerMove = "Paper";
            }
            else if (computRandomMove == 3)
            {
                ComputerMove = "Scissors";
            }
            Console.WriteLine($"Computer chose {ComputerMove}");
            if ((playerMove == "Rock" && ComputerMove == "Scissors") || (playerMove == "Scissors" && ComputerMove == "Paper") || (playerMove == "Paper" && ComputerMove == "Rock"))
            {
                Console.WriteLine("You win");
            }
            else if ((playerMove == "Scissors" && ComputerMove == "Rock") || (playerMove == "Paper" && ComputerMove == "Scissors") || (playerMove == "Rock" && ComputerMove == "Paper"))
            {
                Console.WriteLine("You lose"); 
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }
        }
    }
}