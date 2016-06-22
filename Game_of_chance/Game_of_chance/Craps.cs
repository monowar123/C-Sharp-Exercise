using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_of_chance
{
    //Roll two dice. if the sum is 7 or 11 you will won.
    //if the sum is 2, 3 or 12 you lost.
    //if the sum is 4, 5, 6, 8, 9 or 10, the sum becomes your point.
    //you must continue rolling the dice until you make your point.
    //you lost by rolling a 7 before making your point.
    public class Craps
    {
        private Random randomNumbers = new Random();
        private enum Status { CONTINUE, WON, LOST };
        private enum DiceNames
        {
            TWO = 2, THREE = 3, SEVEN = 7, ELEVEN = 11, TWELVE = 12
        };
        public void Play()
        {
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;
            int sumOfDice = RollDice();

            switch ((DiceNames)sumOfDice)
            {
                case DiceNames.SEVEN:
                case DiceNames.ELEVEN:
                    gameStatus = Status.WON;
                    break;
                case DiceNames.TWO:
                case DiceNames.THREE:
                case DiceNames.TWELVE:
                    gameStatus = Status.LOST;
                    break;
                default:
                    gameStatus = Status.CONTINUE;
                    myPoint = sumOfDice;
                    Console.WriteLine("Your point is {0}.", myPoint);
                    break;
            }
            // while the game is not complete
            while (gameStatus == Status.CONTINUE)
            {
                sumOfDice = RollDice();
                if (sumOfDice == myPoint)
                {
                    gameStatus = Status.WON;
                }
                else if (sumOfDice == (int)DiceNames.SEVEN)
                {
                    gameStatus = Status.LOST;
                }
            }
            // display won or lost message
            if (gameStatus == Status.WON)
            {
                Console.WriteLine("Player won.");
            }
            else
                Console.WriteLine("Player loses.");
        }
        public int RollDice()
        {
            int die1 = randomNumbers.Next(1, 7);
            int die2 = randomNumbers.Next(1, 7);
            int sum = die1 + die2;
            Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
            return sum;
        }
    }
}
