using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            List<string> inputOptions = new List<string>
            {
                "0",
                "1",
                "2",
                "3",
                "4"
            };
            Console.WriteLine(@"
    What gesture would you like to select

            Please enter:
            0 for Rock
            1 for Paper
            2 for Scissors
            3 for Lizard
            4 for Spock

            ");
            string input = Console.ReadLine();
            while (!inputOptions.Contains(input))
            {
                Console.WriteLine($"Sorry {input} is not a valid entry. Please try again.");
                input = Console.ReadLine();
            }
            chosenGesture = gestures[int.Parse(input)];
        }
    }
}
