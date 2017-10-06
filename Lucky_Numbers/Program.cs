using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=5NV6Rdv1a3I
            //Inital "copy" to introduce game and ask for bounds

            Console.WriteLine("Let's play \"Guess the Number\"");
            Console.WriteLine("I'm going to generate six (pseudo)random numbers between two that you tell me.");
            Console.WriteLine("If you guess all the numbers right, you will win 1200 ducats!");
            Console.WriteLine();

            Console.WriteLine("What's the lower bound of the numbers you want to generate?");

            int lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine("And how about the highest limit?");
            int upperBound = int.Parse(Console.ReadLine());


            //Loop populating guess array
            int[] numGuesses = new int[6];
            for (int i = 0; i < numGuesses.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Guess a number!");

                int numGuess = int.Parse(Console.ReadLine());
                if (IsBetweenBounds(numGuess, lowerBound, upperBound))
                {
                    numGuesses[i] = numGuess;
                }
                else
                {
                    while (IsBetweenBounds(numGuess, lowerBound, upperBound) == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You must have made an error! That number is not between your bounds!");
                        Console.WriteLine("Guess again!");
                        numGuess = int.Parse(Console.ReadLine());
                    }
                    numGuesses[i] = numGuess;
                }
            }
            Console.WriteLine();

            // Generates an array of (pseudo)random lucky numbers and prints
            int[] luckyNumbers = new int[6];
            Random rand = new Random();
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = RandomNumGenerator(rand, lowerBound, upperBound);
            }

            foreach (int num in luckyNumbers)
            {
                Console.WriteLine("Lucky Number: " +num);
            }

            //Compares arrays for guesses and lucky numbers,
            //returns num guessed correctly

            int numRight = ArrayCompare(numGuesses, luckyNumbers);
            Console.WriteLine("You guessed " + numRight + " numbers correctly!");







        }
        public static bool IsBetweenBounds(int num, int lowerBound, int upperBound)
        {
            if (num >= lowerBound && num <= upperBound)
                return true;
            else
                return false;
        }
        public static int RandomNumGenerator(Random rand, int lowerBound, int upperBound)
        {
            return rand.Next(lowerBound, upperBound+1);
        }
        public static int ArrayCompare(int[] numGuesses, int[] luckyNumbers)
        {
            int numRight = 0;
            foreach (int guess in numGuesses)
            {
                for (int i = 0; i < luckyNumbers.Length; i++)
                    if (guess == luckyNumbers[i])
                    {
                        numRight++;
                        luckyNumbers[i] = -1;
                        break;
                    }
            }
            return numRight;
        }

    }
}
