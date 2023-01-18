using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIssion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRolls = Game.StartGame();
            //make dice
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            //total and count roll
            int[] countArray = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = dice1.RollDice();
                int roll2 = dice1.RollDice();
                int sumRolls = roll1 + roll2;
                countArray[sumRolls - 1] = countArray[sumRolls - 1] + 1; 
            }
            //print results
            Game.PrintResults(numRolls, countArray);
        }
    }
}
