using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine(@"
        Welcome to RPSLS! Here are the rules:

            Rock crushes Scissors
            Scissors cuts Paper 
            Paper covers Rock
            Rock crushes Lizard
            Lizard poisons Spock
            Spock smashes Scissors
            Scissors decapitates Lizard
            Lizard eats Paper
            Paper disproves Spock
            Spock vaporizes Rock

    One to Two Players, Best of three rounds wins!

            ");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many people are playing?");
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                Console.WriteLine($"Sorry {input} is not a valid number of players. Please try again.");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            playerOne = new ComputerPlayer();
            playerOne.ChooseGesture();
        }
    }
}
