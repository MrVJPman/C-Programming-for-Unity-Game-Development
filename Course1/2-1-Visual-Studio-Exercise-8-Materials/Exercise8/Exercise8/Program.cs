using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die diceOne = new Die();
            Die diceTwo = new Die();
            // tell the dice to roll themselves
            diceOne.Roll();
            diceTwo.Roll();
            // print the top sides and the sum of the dice
            int sumOfDie = diceOne.TopSide + diceTwo.TopSide;
            Console.WriteLine("Dice 1: " + diceOne.TopSide + ", Dice 2: " + diceTwo.TopSide + ", Sum: " + sumOfDie);
        }
    }
}
