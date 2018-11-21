using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deckOfCards = new Deck();
            Card[] handWithFiveCards = new Card[5];
            deckOfCards.Shuffle();

            handWithFiveCards[0] = deckOfCards.TakeTopCard();
            handWithFiveCards[0].FlipOver();
            handWithFiveCards[0].Print();

            Console.WriteLine();

            handWithFiveCards[1] = deckOfCards.TakeTopCard();
            handWithFiveCards[1].FlipOver();
            handWithFiveCards[0].Print();
            handWithFiveCards[1].Print();

            Console.WriteLine();

        }
    }
}
