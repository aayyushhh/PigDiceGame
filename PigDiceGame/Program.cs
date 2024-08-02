using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        public static int TurnScore(string userInput, int turnSum, int totalScore)
        {
            while (userInput != "h")
            {
                Random rnd = new Random();
                int rolledNumber = rnd.Next(1, 7);
                Console.WriteLine(rolledNumber);

                if (rolledNumber > 1)
                {
                    turnSum = turnSum + rolledNumber;
                    Console.WriteLine("Your turn score is {0} and Total score is {1}", turnSum, totalScore);
                    if (totalScore + turnSum > 20)
                    {
                        Console.WriteLine("Your Total score is {0}", totalScore + turnSum);
                        return turnSum;
                    }
                    Console.WriteLine("If you hold your total score will be {0}", totalScore + turnSum);
                }
                if (rolledNumber == 1)
                {
                    turnSum = 0;
                    Console.WriteLine("Your Turn Score is now 0 and Totalscore is {0}", totalScore);
                    return turnSum;
                }
                Console.WriteLine("Enter r to roll or h to hold");
                userInput = Console.ReadLine();
                if (userInput == "h")
                {
                    Console.WriteLine("Your Total score is {0}", totalScore + turnSum);
                }
            }
            return turnSum;
        }
        public static void TakeInputFromUser()
        {
            int totalScore = 0;
            int numberOfTurns = 0;
            while (totalScore < 20)
            {
                totalScore = totalScore + TurnStats(totalScore);
                numberOfTurns++;
            }
            Console.WriteLine("It took {0} turns to win", numberOfTurns);
        }
        public static int TurnStats(int totalScore)
        {
            Console.WriteLine("Enter r to roll or h to hold");
            string userInput = Console.ReadLine();
            int turnSum = 0;
            return TurnScore(userInput, turnSum, totalScore);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Pig!");
            TakeInputFromUser();
        }
    }
}












































































       




