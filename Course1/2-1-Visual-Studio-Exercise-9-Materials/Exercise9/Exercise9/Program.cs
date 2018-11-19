using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deckOfCards = new Deck();
            deckOfCards.Print();
            Console.WriteLine();
            // tell the deck to shuffle and print itself
            deckOfCards.Shuffle();
            deckOfCards.Print();
            Console.WriteLine();
            // take the top card from the deck and print the card rank and suit
            Card topCard = deckOfCards.TakeTopCard();
            Console.WriteLine("The card's rank is " + topCard.Rank + " and the card's suit is " + topCard.Suit);
            // take the top card from the deck and print the card rank and suit
            Card topCardTwo = deckOfCards.TakeTopCard();
            Console.WriteLine("The card's rank is " + topCardTwo.Rank + " and the card's suit is " + topCardTwo.Suit);
            Console.WriteLine();

        }
    }
}
