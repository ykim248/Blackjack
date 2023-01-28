using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Blackjack.Models;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new deck
            Deck deck = new Deck();

            // Shuffle the deck
            deck.Shuffle();

            // Draw a card from the deck
            Card drawnCard = deck.DrawCard();

            // Print the card's suit and rank
            Console.WriteLine("Drawn card: " + drawnCard.suit + " of " + drawnCard.rank);

            // Print the card's value
            Console.WriteLine("Value: " + drawnCard.GetCardValue());
        }
    }
}
