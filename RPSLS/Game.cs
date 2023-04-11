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
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player one please enter your username:");
                playerOne = new HumanPlayer(Console.ReadLine());
                playerTwo = new ComputerPlayer();
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player one please enter your username:");
                playerOne = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("Player two please enter your username:");
                playerTwo = new HumanPlayer(Console.ReadLine());
            }
        }

        public void CompareGestures(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine($"Its a tie! Both players choose {playerOneGesture}.");
            }
            else if ((playerOneGesture == "rock" || playerOneGesture == "Spock") && playerTwoGesture == "scissors")
            {
                playerOne.score += 1;
                Console.WriteLine($"{playerOne.name}'s gesture {playerOneGesture} beats {playerTwo.name}'s {playerTwoGesture}.");
            }
            else if ((playerOneGesture == "scissors" || playerOneGesture == "lizard") && playerTwoGesture == "paper")
            {
                playerOne.score += 1;
                Console.WriteLine($"{playerOne.name}'s gesture {playerOneGesture} beats {playerTwo.name}'s {playerTwoGesture}.");
            }
            else if ((playerOneGesture == "paper" || playerOneGesture == "Spock") && playerTwoGesture == "rock")
            {
                playerOne.score += 1;
                Console.WriteLine($"{playerOne.name}'s gesture {playerOneGesture} beats {playerTwo.name}'s {playerTwoGesture}.");
            }
            else if ((playerOneGesture == "rock" || playerOneGesture == "scissors") && playerTwoGesture == "lizard")
            {
                playerOne.score += 1;
                Console.WriteLine($"{playerOne.name}'s gesture {playerOneGesture} beats {playerTwo.name}'s {playerTwoGesture}.");
            }
            else if ((playerOneGesture == "lizard" || playerOneGesture == "paper") && playerTwoGesture == "Spock")
            {
                playerOne.score += 1;
                Console.WriteLine($"{playerOne.name}'s gesture {playerOneGesture} beats {playerTwo.name}'s {playerTwoGesture}.");
            }
            else
            {
                playerTwo.score += 1;
                Console.WriteLine($"{playerTwo.name}'s gesture {playerTwoGesture} beats {playerOne.name}'s {playerOneGesture}.");
            }
            Console.WriteLine($"The scores are now\n{playerOne.name}:{playerOne.score}\n{playerTwo.name}:{playerTwo.score}");
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine($"{playerOne.name} wins! Congrats!");
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} wins! Congrats!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            CreatePlayerObjects(ChooseNumberOfHumanPlayers());
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures(playerOne.chosenGesture, playerTwo.chosenGesture);
            }
            DisplayGameWinner();
        }
    }
}
