using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIssion_2
{
    static class Game
    {
        public static int numRolls = 0;
        public static int StartGame()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate?: ");
            numRolls = Convert.ToInt32(Console.ReadLine());
            return numRolls;
        }
        public static string[] CalculateResults(int numGameRolls, params int[] rollCount)
        {
            string[] printArray = new string[12];
            for (int i = 0; i < rollCount.Length; i++)
            {
                int numRolls = rollCount[i];
                double numRollsCalculate = Convert.ToDouble(numRolls);
                double rollPercentage = Math.Round((numRollsCalculate / numGameRolls) * 100, 0);
                for (int j = 0; j < rollPercentage; j++)
                {
                    printArray[i] = printArray[i] + '*';
                }
            }
            return printArray;

        }
        public static void PrintResults(int numRolls, params int[] rollCount)
        {
            Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS"); 
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + Convert.ToString(numRolls) + '.');
            
            string[] printArray = CalculateResults(numRolls ,rollCount);
            
            for (int i=1; i<printArray.Length; i++)
            {
                int numRoll = i + 1;
                Console.Write(numRoll + ": " + printArray[i] + "\n");
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
