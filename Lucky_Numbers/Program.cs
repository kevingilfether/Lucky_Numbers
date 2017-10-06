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
            Console.WriteLine("Let's play \"Guess the Number\"");
            Console.WriteLine("I'm going to generate six (pseudo)random numbers between two that you tell me.");
            Console.WriteLine("If you guess all the numbers right, you will win 1200 ducats!");
            Console.WriteLine();

            Console.WriteLine("What's the lower bound of the numbers you want to generate?");
            int lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine("And how about the highest limit?");
            int upperBound = int.Parse(Console.ReadLine());



        }
    }
}
