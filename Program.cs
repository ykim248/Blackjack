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
            var deck = new Deck();
            var hand = new Hand();
            hand.Cards.Add(deck.DrawCard());
            
            hand.Cards.Add(deck.DrawCard());
            Console.WriteLine("Hand value: " + hand.CalculateHandValue());

        }
    }
}
