using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // Print welcoming message
            Console.WriteLine("Welcome to the most pointless card game ever!!!");
            Console.WriteLine();

            // Create and shuffle the deck
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();

            //deal first card to each player
            Card Player1Card1 = gameDeck.TakeTopCard();
            Card Player2Card1 = gameDeck.TakeTopCard();
            Card Player3Card1 = gameDeck.TakeTopCard();

            //deal second card to each player
            Card Player1Card2 = gameDeck.TakeTopCard();
            Card Player2Card2 = gameDeck.TakeTopCard();
            Card Player3Card2 = gameDeck.TakeTopCard();

            // flipover cards
            Player1Card1.FlipOver();
            Player1Card2.FlipOver();
            Player2Card1.FlipOver();
            Player2Card2.FlipOver();
            Player3Card1.FlipOver();
            Player3Card2.FlipOver();

            //print flipped cards of player one
            Console.WriteLine("Player`s one cards are:");
            Console.WriteLine(Player1Card1.Rank + " of " + Player1Card1.Suit);
            Console.WriteLine(Player1Card2.Rank + " of " + Player1Card2.Suit);
            Console.WriteLine();

            //print flipped cards for player two 
            Console.WriteLine("Player`s two cards are:");
            Console.WriteLine(Player2Card1.Rank + " of " + Player2Card1.Suit);
            Console.WriteLine(Player2Card2.Rank + " of " + Player2Card2.Suit);
            Console.WriteLine();

            //print flipped cards of player three
            Console.WriteLine("Player`s three cards are:");
            Console.WriteLine(Player3Card1.Rank + " of " + Player3Card1.Suit);
            Console.WriteLine(Player3Card2.Rank + " of " + Player3Card2.Suit);
            Console.WriteLine();
        }

    }
} */


namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to Bob's Coursera Assignment #2!");
            Console.WriteLine();
            // create and shuffle a deck
            Deck deckOfCards = new Deck();
            deckOfCards.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card playerOneCardOne = deckOfCards.TakeTopCard();
            Card playerTwoCardOne = deckOfCards.TakeTopCard();
            Card playerThreeCardOne = deckOfCards.TakeTopCard();
            Card playerOneCardTwo = deckOfCards.TakeTopCard();
            Card playerTwoCardTwo = deckOfCards.TakeTopCard();
            Card playerThreeCardTwo = deckOfCards.TakeTopCard();


            // flip all the cards over
            playerOneCardOne.FlipOver();
            playerTwoCardOne.FlipOver();
            playerThreeCardOne.FlipOver();
            playerOneCardTwo.FlipOver();
            playerTwoCardTwo.FlipOver();
            playerThreeCardTwo.FlipOver();

            // print the cards for player 1
            Console.WriteLine("The first card for player one is " + playerOneCardOne.Suit + " of " + playerOneCardOne.Rank);
            Console.WriteLine("The second card for player one is " + playerOneCardTwo.Suit + " of " + playerOneCardTwo.Rank);
            Console.WriteLine();

            // print the cards for player 2
            Console.WriteLine("The first card for player two is " + playerTwoCardOne.Suit + " of " + playerTwoCardOne.Rank);
            Console.WriteLine("The second card for player two is " + playerTwoCardTwo.Suit + " of " + playerTwoCardTwo.Rank);
            Console.WriteLine();

            // print the cards for player 3
            Console.WriteLine("The first card for player three is " + playerThreeCardOne.Suit + " of " + playerOneCardOne.Rank);
            Console.WriteLine("The second card for player three is " + playerThreeCardTwo.Suit + " of " + playerThreeCardTwo.Rank);
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
